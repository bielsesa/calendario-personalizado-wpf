using System;

namespace Calendario
{
    public class DiaCalendario
    {
        private DateTime fecha;
        private bool esFestivo;


        public DateTime Fecha { get { return fecha;  }  set { fecha = value; } }
        public bool EsFestivo { get { return esFestivo;  }  set { esFestivo = value; } }

        public DiaCalendario(DateTime fecha, bool esFestivo)
        {
            Fecha = fecha;
            EsFestivo = esFestivo;
        }

        public override string ToString()
        {
            return fecha.Day.ToString();
        }
    }
}
