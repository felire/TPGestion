﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.UtilConexion
{
    class Hora
    {
        public string HoraAMostrar { get; set; }
        public TimeSpan LaHora { get; set; }

        public Hora(TimeSpan hora, string detalle)
        {
            HoraAMostrar = detalle;
            LaHora = hora;
        }


        public static List<Hora> obtenerHorasFecha(Fecha dia)
        {
            int cont = 0;
            List<Hora> lista = new List<Hora>();
            for (int i = dia.horaDesde.Hours; i <= dia.horaHasta.Hours; i++)
            {
                cont++;
                if (cont != 2)
                {
                    TimeSpan unaHora = new TimeSpan(i, 00, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                    if (horaValida(dia, unaHora))
                    {
                        lista.Add(new Hora(unaHora, hora));
                    }
                }
                else
                {
                    //REINICIO EL CONTADOR PORQUE ES MEDIA HORA
                    cont = 0;
                    i--;
                    TimeSpan unaHora = new TimeSpan(i, 30, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                    if (horaValida(dia, unaHora))
                    {
                        lista.Add(new Hora(unaHora, hora));
                    }
                }
            }
            return lista;
        }

        private static Boolean horaValida(Fecha dia, TimeSpan unaHora)
        {
            DateTime horaACheckear = new DateTime(dia.dia.Year, dia.dia.Month, dia.dia.Day, unaHora.Hours, unaHora.Minutes, 0);
            Boolean noEsPasada = DateTime.Now.CompareTo(horaACheckear) < 0;
            Boolean noEstaOcupada = !dia.horasOcupadas.Contains(unaHora);
            return noEsPasada && noEsPasada;
        }

        public static List<Hora> obtenerHorasDia(Dia dia)
        {
            int cont = 0;
            List<Hora> lista = new List<Hora>();
            for (int i = dia.horaDesde.Hours; i <= dia.horaHasta.Hours; i++)
            {
                cont++;
                if (cont != 2)
                {
                    TimeSpan unaHora = new TimeSpan(i, 00, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                    lista.Add(new Hora(unaHora, hora));
                }
                else
                {   
                    //REINICIO EL CONTADOR PORQUE ES MEDIA HORA
                    cont = 0;
                    i--;
                    TimeSpan unaHora = new TimeSpan(i, 30, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                    lista.Add(new Hora(unaHora, hora));
                }
            }
            return lista;
        }

        public static Boolean horasValidas(TimeSpan desde, TimeSpan hasta)
        {
            if(desde.Hours < hasta.Hours)
            { 
                return true; 
            }
            else if (desde.Hours == hasta.Hours && desde.Minutes < hasta.Minutes) 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }


        public static List<Hora> ObtenerHorasAceptables(Turno turno)
        {
            int cont;
            List<Hora> lista = new List<Hora>();
            if (turno.fecha.Minute == 0)
            {
                cont = 0;
                for (int i = turno.fecha.TimeOfDay.Hours; i <= turno.fecha.TimeOfDay.Hours + 3; i++)
                {
                    cont++;
                    if (cont != 2)
                    {
                        TimeSpan unaHora = new TimeSpan(i, 00, 0);
                        string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                        lista.Add(new Hora(unaHora, hora));
                    }
                    else
                    {
                        //REINICIO EL CONTADOR PORQUE ES MEDIA HORA
                        cont = 0;
                        i--;
                        TimeSpan unaHora = new TimeSpan(i, 30, 0);
                        string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                        lista.Add(new Hora(unaHora, hora));
                    }
                }
            }
            else
            {
                cont = 1;
                for (int i = turno.fecha.TimeOfDay.Hours + 1; i <= turno.fecha.TimeOfDay.Hours + 3; i++)
                {
                    cont++;
                    if (cont != 2)
                    {
                        TimeSpan unaHora = new TimeSpan(i, 00, 0);
                        string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                        lista.Add(new Hora(unaHora, hora));
                    }
                    else
                    {
                        //REINICIO EL CONTADOR PORQUE ES MEDIA HORA
                        cont = 0;
                        i--;
                        TimeSpan unaHora = new TimeSpan(i, 30, 0);
                        string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                        lista.Add(new Hora(unaHora, hora));
                    }
                }
            }
            return lista;
        }


    }
}

