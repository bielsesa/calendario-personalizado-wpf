﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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

            Console.WriteLine(DiaItemsControl.Items.Count);
        }
        public ObservableCollection<DiaCalendario> ListaDias
        {
            get;
            set;
        }

        private void LabelDia_GotMouseCapture(object sender, MouseEventArgs e)
        {
            Console.WriteLine("MouseCapture LabelDia");
            ContentPresenter cp = DiaItemsControl.ItemContainerGenerator.ContainerFromItem(DiaItemsControl) as ContentPresenter;
            // he de recoger la label que se ha seleccionado en la grid

            //Label labelDia = (Label)DiaItemsControl.ItemTemplate.FindName("LabelDia", DiaItemsControl); 
        }
    }
}
