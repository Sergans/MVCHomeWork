using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;

namespace MVCLesson_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int f = 0;
        public MainWindow()
        {  
          InitializeComponent();
            Thread tred = new Thread(Plus);
            tred.Start();
            TextBox1.Text = f.ToString();
            

        }

        public void Plus()
        {
            
            for (int i = 0; i <= 3; i++)
            {
                f = i;
                Thread.Sleep(2000);
                TextBox1.Dispatcher.Invoke(()=>TextBox1.Text = f.ToString());
              
            }
        }


        static int Fibbo(int n)
        {
            Thread.Sleep(1000);
            if (n == 0)
            {
                n = 0;
                return n;
            }
            else if (n == 1)
            {
                n = 1;
                return n;
            }
            return Fibbo(n - 1) + Fibbo(n - 2);
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Slider1.Value = 0;
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextBox1.Text =((int)Slider1.Value).ToString();
        }
    }
}
