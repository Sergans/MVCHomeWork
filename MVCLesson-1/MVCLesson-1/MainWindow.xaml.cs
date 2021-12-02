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
        int func_out = 0;
        int regulator=1000;
        public MainWindow()
        {  
          InitializeComponent();
            Thread tred = new Thread(NomberOut);
            tred.Start();
            TextBox1.Text = func_out.ToString();
            TextBox2.Text = regulator.ToString();
        }

        public void NomberOut()
        {
            for (int i = 0; true; ++i)
            {
               func_out= Fibbo(i);
               Thread.Sleep(regulator);
               TextBox1.Dispatcher.Invoke(()=>TextBox1.Text = func_out.ToString());
            }
        }


        static int Fibbo(int nomber_position)
        {
           
            if (nomber_position == 0)
            {
                nomber_position = 0;
                return nomber_position;
            }
            else if (nomber_position == 1)
            {
                nomber_position = 1;
                return nomber_position;
            }
            return Fibbo(nomber_position - 1) + Fibbo(nomber_position - 2);
        }
       
        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider1.Value < 1)
            {
                regulator = 1000;
                TextBox2.Text = regulator.ToString();
            }
            else 
            { 
                regulator = (int)Slider1.Value * 1000;
                TextBox2.Text = regulator.ToString();
            }
            
        }
    }
}
