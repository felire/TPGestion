using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<Hora> lista = new List<Hora>();
            Hora ultima = null;
            bool horaEnPunto = true;
            int i = dia.horaDesde.Hours;
            if (dia.horaDesde.Minutes != 0)//arranca y media
            {
                horaEnPunto = false;
                i++;
            }
            for ( ; i <= dia.horaHasta.Hours; i++)
            {
                if (horaEnPunto)
                {
                    TimeSpan unaHora = new TimeSpan(i, 00, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                    if (horaValida(dia, unaHora))
                    {
                        ultima = new Hora(unaHora, hora);
                        lista.Add(ultima);
                    }
                    horaEnPunto = false;
                }
                else
                {
                    i--;
                    TimeSpan unaHora = new TimeSpan(i, 30, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                    if (horaValida(dia, unaHora))
                    {
                        ultima = new Hora(unaHora, hora);
                        lista.Add(ultima);
                    }
                    horaEnPunto = true;
                }
            }
            if(ultima != null) lista.Remove(ultima);//solo se pueden pedir turnos hasta 30 min hasta de cerrar la clinica
            return lista;
        }

        private static Boolean horaValida(Fecha fecha, TimeSpan unaHora)
        {
            DateTime horaACheckear = new DateTime(fecha.dia.Year, fecha.dia.Month, fecha.dia.Day, unaHora.Hours, unaHora.Minutes, 0);
            Boolean noEsPasada = DateTime.Now.CompareTo(horaACheckear) < 0;
            Boolean noEstaOcupada = !fecha.horasOcupadas.Contains(unaHora);
            return noEsPasada && noEstaOcupada;
        }

        public static List<Hora> obtenerHorasDia(Dia dia)
        {
            List<Hora> lista = new List<Hora>();
            bool horaEnPunto = true;
            int i = dia.horaDesde.Hours;
            if (dia.horaDesde.Minutes != 0)//arranca y media
            {
                horaEnPunto = false;
                i++;
            }
            for ( ; i <= dia.horaHasta.Hours; i++)
            {
                if (horaEnPunto)
                {
                    TimeSpan unaHora = new TimeSpan(i, 00, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                    lista.Add(new Hora(unaHora, hora));
                    horaEnPunto = false;
                }
                else
                {   
                    i--;
                    TimeSpan unaHora = new TimeSpan(i, 30, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                    lista.Add(new Hora(unaHora, hora));
                    horaEnPunto = true;
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
            List<Hora> lista = new List<Hora>();
            bool horaEnPunto = true;
            int i = turno.fecha.Hour;
            if (turno.fecha.Minute != 0)//arranca y media
            {
                horaEnPunto = false;
                i++;
            }
            for ( ; i <= turno.fecha.TimeOfDay.Hours + 3; i++)
            {
                if (horaEnPunto)
                {
                    TimeSpan unaHora = new TimeSpan(i, 00, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString() + "0";
                    lista.Add(new Hora(unaHora, hora));
                    horaEnPunto = false;
                }
                else
                {
                    i--;
                    TimeSpan unaHora = new TimeSpan(i, 30, 0);
                    string hora = unaHora.Hours.ToString() + ":" + unaHora.Minutes.ToString();
                    lista.Add(new Hora(unaHora, hora));
                    horaEnPunto = true;
                }
            }
            return lista;
        }
    }
}
