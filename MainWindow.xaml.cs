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

namespace HelloWorldMicah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();


        public MainWindow()
        {
            InitializeComponent();
            uxContainer.DataContext = user;
        }

        public override void EndInit()
        {
            base.EndInit();
        }
        private void UxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private void HasContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(uxName.Text) && !string.IsNullOrEmpty(uxPassword.Text))
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }

        }
    }
}
