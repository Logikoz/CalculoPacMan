using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculoPacMan
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        //ao passar por cima da moeda
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ale = new Random();
            (int, int) numeros = (ale.Next(0, 10), ale.Next(0, 10));

            _ = new ResolverCalculo(numeros).ShowDialog();
        }
    }
}
