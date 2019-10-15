using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace Calendario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); BrushConverter brushConverter = new BrushConverter();
            MyBrushes = new ObservableCollection<Brush>();

            for (int i = 0; i < 42; i += 2)
            {
                MyBrushes.Add(brushConverter.ConvertFrom("#317a91") as Brush);
                MyBrushes.Add(brushConverter.ConvertFrom("#22D3D3D3") as Brush);
            }

            this.DataContext = this;
        }

        public ObservableCollection<Brush> MyBrushes
        {
            get;
            set;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentanaCalendario calendario = new VentanaCalendario();
            calendario.Show();
        }
    }
}
