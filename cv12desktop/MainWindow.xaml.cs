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

namespace cv12desktop
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

        public void ButtonCompute_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client calculatorService = new ServiceReference1.Service1Client();

            decimal first = decimal.Parse(firstNum.Text);
            decimal second = decimal.Parse(secondNum.Text);
            string operation = operations.Text;
            decimal result = calculatorService.Compute(first, second, operation);

            Result.Text = String.Format("{0} {1} {2} = {3}", first, operation, second, result);
        }
    }
}
