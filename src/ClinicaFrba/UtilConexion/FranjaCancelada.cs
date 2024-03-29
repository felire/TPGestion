﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.UtilConexion;

namespace ClinicaFrba.UtilConexion
{
    class FranjaCancelada
    {
        private DateTime desde { get; set; }
        private DateTime hasta { get; set; }

        public FranjaCancelada(DateTime desde, DateTime hasta)
        {
            this.desde = desde;
            this.hasta = hasta;
        }

        public Boolean fechaFueCancelada(Fecha fecha)
        {
            return (fecha.CompareTo(desde) >= 0 && fecha.CompareTo(hasta) <= 0);
        }
    }
}
