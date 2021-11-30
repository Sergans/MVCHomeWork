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
       public int f;
        public MainWindow()
        {  
           InitializeComponent();
           
           //TextBox1.Dispatcher.Invoke(() => TextBox1.Text = f.ToString());
            //Thread f = new Thread(Plus);
            //f.Start();
            //TextBox1.Text = f.ToString();
        }
       

        //public void Plus()
        //{
        //    Thread.Sleep(1000);
            
            
        //        Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
        //        {
        //            int i = 0;
        //            while (i < 10)
        //            {
        //                TextBox1.Text = Fibbo(i).ToString();
        //                i++;
        //            }
                        
        //        }));

        //}
        
       
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
        static int Cl()
        {
            int i = 0;
            while (i < 10)
            {
                
                return Fibbo(i);
            }
            return Fibbo(i);
        }
         void  F()
        {
            
          Application.Current.Dispatcher.BeginInvoke(() => TextBox1.Text = f.ToString());
              
            

                // TextBox1.Dispatcher.Invoke(() => TextBox1.Text = f.ToString());
                //Application.Current.Dispatcher.BeginInvoke(() => TextBox1.Text = f.ToString());



                //Thread a = new Thread(() => F());
                //a.Start();
                // TextBox1.Dispatcher.Invoke(() => TextBox1.Text = f.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            while (f < 10)
            {
                Thread a = new Thread(() => F());
                a.Start();
                Application.Current.Dispatcher.BeginInvoke(() => TextBox1.Text = f.ToString());
                //Application.Current.Dispatcher.BeginInvoke(() => TextBox1.Text = f.ToString());
                Thread.Sleep(10000);
                f++;
            }

            

             

               
            
                
            
          
        }
    }
}
