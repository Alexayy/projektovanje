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

namespace Player_Video
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void powerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            reflectionRectangle.Visibility = Visibility.Visible;
            playRadioButton.IsEnabled = true;
            pauseRadioButton.IsEnabled = true;
            stopRadioButton.IsEnabled = true;
        }
        private void powerCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            videoMediaElement.Close();
            reflectionRectangle.Visibility = Visibility.Hidden;

            playRadioButton.IsChecked = false;
            pauseRadioButton.IsChecked = false;
            stopRadioButton.IsChecked = false;
            playRadioButton.IsEnabled = false;
            pauseRadioButton.IsEnabled = false;
            stopRadioButton.IsEnabled = false;
        }

        private void playRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            videoMediaElement.Play();
        }

        private void pauseRadioButton_Checked(object sender, RoutedEventArgs e)

        {
            videoMediaElement.Pause();
        }
        private void stopRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            videoMediaElement.Stop();
        }
    }
}
