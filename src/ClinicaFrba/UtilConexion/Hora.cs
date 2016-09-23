using System;
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
    }
}

