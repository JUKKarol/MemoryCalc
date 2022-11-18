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

namespace MemoryCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int unit = 0;
        int newUnit = 0;

        double size = 0;
        double newSize = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBoxEnter_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void buttonCount_Click(object sender, RoutedEventArgs e)
        {          
            size = Double.Parse(textBoxEnter.Text);
            Calc.Unit(size, unit, ref newSize, ref newUnit);
            labelResultL.Content = Math.Round(size, 2) + " " + Calc.ReadUnit(unit);
            labelResultR.Content = Math.Round(newSize, 2) + " " + Calc.ReadUnit(newUnit);
        }

        //ACTUAL BUTTONS

        private void buttonBitUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 1;
            labelActive1.Content = "b";
        }

        private void buttonByteUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 2;
            labelActive1.Content = "B";
        }

        private void buttonKiloByteUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 3;
            labelActive1.Content = "KB";
        }

        private void buttonMegaByteUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 4;
            labelActive1.Content = "MB";
        }

        private void buttonGigaByteUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 5;
            labelActive1.Content = "GB";
        }

        private void buttonTerraByteUnit_Click(object sender, RoutedEventArgs e)
        {
            unit = 6;
            labelActive1.Content = "TB";
        }

        //FINAL BUTTONS

        private void buttonBitFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 1;
            labelActive2.Content = "b";
        }

        private void buttonByteFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 2;
            labelActive2.Content = "B";
        }

        private void buttonKiloByteFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 3;
            labelActive2.Content = "KB";
        }

        private void buttonMegaByteFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 4;
            labelActive2.Content = "MB";
        }

        private void buttonGigaByteFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 5;
            labelActive2.Content = "KB";
        }

        private void buttonTeraByteFUnit_Click(object sender, RoutedEventArgs e)
        {
            newUnit = 6;
            labelActive2.Content = "TB";
        }

        
    }
}
