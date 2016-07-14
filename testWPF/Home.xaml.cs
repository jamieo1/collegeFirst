using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;


namespace testWPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {

            InitializeComponent();
        }

        private void inputDetails_Click(object sender, RoutedEventArgs e)
        {
            //close this window and open main window/input details
            MainWindow win = new MainWindow();
            this.Close();
            win.Show();
        }

        private void buttonMoreInfo_Click(object sender, RoutedEventArgs e)
        {
            //close this window and open info window
            Info win = new Info();
            this.Close();
            win.Show();
        }

        private void buttonPicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // Set filter for file extension and default file extension 
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                myPic.Source = new BitmapImage(new Uri(dlg.FileName));
            }

            if (myPic.Source != null)
            {
                buttonPicture.Content = "Change picture...";
            }

        }


    }


}
