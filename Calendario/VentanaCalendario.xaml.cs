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

            for (int i = 0; i < 42; i += 2)
            {
                ListaDias.Add(new DiaCalendario(DateTime.Now, true));
                ListaDias.Add(new DiaCalendario(DateTime.Now, false));
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

        }

        private void LabelDiaFestivo_GotMouseCapture(object sender, MouseEventArgs e)
        {

        }
    }
}
