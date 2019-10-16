using System;

namespace Calendario
{
    public class DiaCalendario
    {
        private DateTime fecha;
        private bool esFestivo;
        private int columna;
        private int fila;

        public DateTime Fecha { get { return fecha;  }  set { fecha = value; } }
        public bool EsFestivo { get { return esFestivo;  }  set { esFestivo = value; } }
        public int Columna { get { return columna; } }
        public int Fila { get { return fila; } set { fila = value; } }

        public DiaCalendario(DateTime fecha, bool esFestivo)
        {
            Fecha = fecha;
            EsFestivo = esFestivo;

            // Sets the Grid.Column depending on which day of week it is
            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    columna = 0;
                    break;
                    
                case DayOfWeek.Tuesday:
                    columna = 1;
                    break;                    
                    
                case DayOfWeek.Wednesday:
                    columna = 2;
                    break;                    
                    
                case DayOfWeek.Thursday:
                    columna = 3;
                    break;
                    
                    
                case DayOfWeek.Friday:
                    columna = 4;
                    break;                    
                    
                case DayOfWeek.Saturday:
                    columna = 5;
                    break;                    
                    
                case DayOfWeek.Sunday:
                    columna = 6;
                    break;
            }
        }

        public DiaCalendario(DateTime fecha, bool esFestivo, int fila) : this(fecha, esFestivo)
        {
            Fila = fila;
        }

        public override string ToString()
        {
            return fecha.Day.ToString();
        }
    }
}
