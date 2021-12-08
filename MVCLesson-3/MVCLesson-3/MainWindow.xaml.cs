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


namespace MVCLesson_3
{

    public class Comand1 : ICommand
    {
       
        private Action<object> execute;
        private Func<object, bool> canExecute;
        public event EventHandler CanExecuteChanged;

        public Comand1(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {// создаем привязку команды
            CommandBinding commandBinding = new CommandBinding();
            // устанавливаем команду
            commandBinding.Command = ApplicationCommands.Help;
            // устанавливаем метод, который будет выполняться при вызове команды
            commandBinding.Executed += Button_Click;
            // добавляем привязку к коллекции привязок элемента Button
            btn1.CommandBindings.Add(commandBinding);

            // btn1.Command = ApplicationCommands.Copy;
            InitializeComponent();
            var cm = new Comand1(o => { MessageBox.Show("Команда" + o.ToString()); });
            //cm.Execute("1");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // var cm = new Comand1(o => {Text1.Text=("Команда" + o.ToString()); });

            // btn1.Command = ApplicationCommands.Help;
            MessageBox.Show("Справка по приложению");
        }
    }
}
