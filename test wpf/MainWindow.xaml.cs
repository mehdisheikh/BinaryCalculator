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
using test_wpf.Interfaces;
using test_wpf.Services;

namespace test_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IBiCalculator _biCalculator;
        public MainWindow(IBiCalculator biCalculator)
        {
            _biCalculator = biCalculator;

            InitializeComponent();
        }

        private void test1(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.Enter.ToString().ToLower());
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(e.Key.ToString().ToLower()); 
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content= _biCalculator.Input(Key.D0.ToString().ToLower());
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.D1.ToString().ToLower());
        }

        private void btnClearAll_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.Escape.ToString().ToLower());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.Space.ToString().ToLower());
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.Add.ToString().ToLower());
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Content = _biCalculator.Input(Key.Subtract.ToString().ToLower());
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double heighScale = (ActualHeight / 350.0f);
            double widthScale = (ActualWidth / 390.0f);
            double fontSize= heighScale * widthScale*22<100?heighScale* widthScale*22:75;
            //btnEnter
            btnEnter.Height = heighScale * 165;
            btnEnter.Margin = new Thickness(widthScale*287,heighScale * 151, widthScale * 3, heighScale * 3);//285,149,0,0
            btnEnter.Width = (ActualWidth/ 390.0f)*85;
            btnEnter.FontSize = fontSize;
            //btnPlus 
            btnPlus.Height = heighScale * 80;
            btnPlus.Margin = new Thickness(widthScale * 200, heighScale * 236, widthScale * 3, heighScale * 3);//200,234,0,0
            btnPlus.Width = (ActualWidth / 390.0f) * 85;
            btnPlus.FontSize = fontSize;
            //btnMinun
            btnMinus.Height = heighScale * 80;
            btnMinus.Margin = new Thickness(widthScale * 200, heighScale * 151, widthScale * 3, heighScale * 3);//200,149,0,0
            btnMinus.Width = (ActualWidth / 390.0f) * 85;
            btnMinus.FontSize = fontSize;
            //btnOne
            btnOne.Height = heighScale * 80;
            btnOne.Margin = new Thickness(widthScale * 115, heighScale * 236, widthScale * 3, heighScale * 3);//115,234,0,0
            btnOne.Width = (ActualWidth / 390.0f) * 85;
            btnOne.FontSize = fontSize;
            //btnZero
            btnZero.Height = heighScale * 80;
            btnZero.Margin = new Thickness(widthScale * 115, heighScale * 151, widthScale * 3, heighScale * 3);//115,149,0,0
            btnZero.Width = (ActualWidth / 390.0f) * 85;
            btnZero.FontSize = fontSize;
            //btnClearAll
            btnClearAll.Height = heighScale * 80;
            btnClearAll.Margin = new Thickness(widthScale * 30, heighScale * 236, widthScale * 3, heighScale * 3);//30,234,0,0
            btnClearAll.Width = (ActualWidth / 390.0f) * 85;
            btnClearAll.FontSize = fontSize;
            //btnClearEntry
            btnClearEntry.Height = heighScale * 80;
            btnClearEntry.Margin = new Thickness(widthScale * 30, heighScale * 151, widthScale * 3, heighScale * 3);//30,149,0,0
            btnClearEntry.Width = (ActualWidth / 390.0f) * 85;
            btnClearEntry.FontSize = fontSize;
            //txtResult
            txtResult.Height = heighScale * 80;
            //btnClearEntry.Margin = new Thickness(widthScale * 30, heighScale * 149, widthScale * 3, heighScale * 3);//30,149,0,0
            txtResult.Width = widthScale * 330;
            txtResult.FontSize = fontSize;

        }
    }
}
