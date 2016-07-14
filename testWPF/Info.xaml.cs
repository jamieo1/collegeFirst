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
using System.Windows.Shapes;

namespace testWPF
{
    /// <summary>
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        public Info()
        {
            InitializeComponent();
        }

    private void buttonHowTo_Click(object sender, RoutedEventArgs e)
        {
            string about = "This app aims to take the user's details (weight, height, activity level etc) and provide the total calories required to meet their goal, along with a breakdown of meals.\n\n";
            string picture = "Picture: You can add any .jpeg, .jpg, .gif or .png image and it will appear the top of the main screen.\n\n";
            string routines = "Routines: The idea would be to show exercise routines and/or links to sites to get more info on this. \n\n";
            string details = "Details: To begin the app.";

            MessageBox.Show(about + picture + routines + details, "Hot to...");

            //TO DO: explain how to use the app, add tips for excercising? links to sites?

        }


        #region //About Button
        private void buttonAbout_Click(object sender, RoutedEventArgs e)
        {
            string mess = "Created for HNC Computing unit; Software Development: Developing a small Standalone Application.\n\n";

            mess += "Made by Jamie O'Hara.";

            MessageBox.Show(mess);
        }
        #endregion

        private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            //close this window and open home window
            Home win = new Home();
            this.Close();
            win.Show();
        }
    }
}
