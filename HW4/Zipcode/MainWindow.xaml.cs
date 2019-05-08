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
using System.Text.RegularExpressions;

namespace Zipcode
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

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Success!");
        }

        private bool IsUSOrCanadianZipCode(string zipCode)
        {
            var usZip = @"^\d{5}(?:[-\s]\d{4})?$";
            var canadaZip = @"(?i:^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$)";
            var validZipCode = true;
            if ((!Regex.Match(zipCode, usZip).Success) && (!Regex.Match(zipCode, canadaZip).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }
        private void zipInput_TextChanged(object sender, TextChangedEventArgs e)
        {

            submitButton.IsEnabled = IsUSOrCanadianZipCode(zipInput.Text);


        }
    }
}
