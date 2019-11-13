using System;
using System.Windows;

namespace CalculoPacMan
{
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
    public partial class ResolverCalculo : Window
    {
        private readonly (int n1, int n2) numeros;

        public ResolverCalculo((int, int) numeros)
        {
            InitializeComponent();
            this.numeros = numeros;
            Numero1_txt.Text = numeros.Item1.ToString();
            Numero2_txt.Text = numeros.Item2.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Resultado_txt.Text))
            {
                if (Resultado_txt.Text == (numeros.n1 + numeros.n2).ToString())
                {
                    //da a moeda
                    _ = MessageBox.Show("Parabens, vc ganhou a moeda");
                    //fecha a janela
                    Close();
                }
                else
                    _ = MessageBox.Show("Resposta errada.");
            }
            else
                _ = MessageBox.Show("Informe um resultado.");
        }
    }
}
