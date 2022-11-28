using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBenchmark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopky = new Stopwatch();
            int pocetPrvocisel = 0;
            int pocetS = 100000;
            int pocetL = 300000;
            stopky.Start();
            if(rbShort.IsChecked == true)
            {
                for(int i = 1; i < pocetS; i++)
                {
                    for(int j = 1; j < i/2; j++)
                    {
                        if(j%i!=0)
                        {
                            pocetPrvocisel++;
                            break;
                        }
                    }
                }
            }
            else if(rbLong.IsChecked == true)
            {
                for (int i = 1; i < pocetL; i++)
                {
                    for (int j = 1; j < i / 2; j++)
                    {
                        if (j % i != 0)
                        {
                            pocetPrvocisel++;
                            break;
                        }
                    }
                }
            }
            stopky.Stop();
            MessageBox.Show($"Hotovo {stopky.Elapsed}");
        }
    }
}
