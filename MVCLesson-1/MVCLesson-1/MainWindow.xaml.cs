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

namespace MVCLesson_1
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
        
        public int f = 0;
        static int Fibbo(int n)
        {
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
        
        public void Fibb()
        {
            
            TextBox1.Dispatcher.Invoke(() => TextBox1.Text= f.ToString()); 
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int i = 0;
           // Thread.Sleep(1000);
            while (i<10)
            {
                Thread.Sleep(1000);
                Fibb();
                f =Fibbo(i);
                
                
                i++;
            }
        }
    }
}
