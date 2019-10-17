using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Calendario
{
    /// <summary>
    /// Lógica de interacción para VentanaCalendario.xaml
    /// </summary>
    public partial class VentanaCalendario : Window
    {
        public VentanaCalendario()
        {
            InitializeComponent(); 
            ListaDias = new ObservableCollection<DiaCalendario>();

            bool festivo = false;
            int fila = 0;
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            for (int i = 0; i < 42; i += 2)
            {
                now = now.AddDays(1);
                ListaDias.Add(new DiaCalendario(now, festivo, fila));
                festivo = !festivo;
                if (now.DayOfWeek == DayOfWeek.Sunday) fila++;
            }

            this.DataContext = this;
        }
        public ObservableCollection<DiaCalendario> ListaDias
        {
            get;
            set;
        }
        private void LabelDiaLaborable_GotMouseCapture(object sender, MouseEventArgs e)
        {
            Console.WriteLine("DiaLaborable");
        }
        private void LabelDiaFestivo_GotMouseCapture(object sender, MouseEventArgs e)
        {
            Console.WriteLine("DiaFestivo");
        }

        private void LabelDia_GotMouseCapture(object sender, MouseEventArgs e)
        {
            var template = DiaItemsControl.Template;
        }
    }
}
