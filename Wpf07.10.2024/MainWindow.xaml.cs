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

namespace Wpf07._10._2024
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var button1 = new Button();
            button1.Content = "Кнопка 5";
            var button2 = new Button { 
                Content = "Кнопка 6"
            };

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(button1);
            stackPanel.Children.Add(button2);
            
            var dockPanel = new DockPanel();
            //dockPanel.Children.Add(button1);
            //dockPanel.Children.Add(button2);

            //DockPanel.SetDock(button1, Dock.Bottom);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пока, User!");
            Close();
        }
    }
}
