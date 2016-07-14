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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {


        public Window2()
        {
            InitializeComponent();

            //set textblocks to show cars/protein/fat per meal
            textBlockCarbs.Text = String.Format("{0:0}", Data.carbs);
            textBlockProtein.Text = String.Format("{0:0}", Data.protein);
            textBlockFat.Text = String.Format("{0:0}", Data.fat);

            //show total daily calories
            textBlockTotalDailyCals.Text = String.Format("{0:0}", Data.dailyCals);

            //hook up breakfast figures to textblocks
            textBlockBreakfastProtein.Text = String.Format("{0:0}g", Data.breakfastPro);
            textBlockBreakfastCarbs.Text = String.Format("{0:0}g", Data.breakfastCarbs);
            textBlockBreakfastFat.Text = String.Format("{0:0}g", Data.breakfastFat);

            //hook up snack figures to textblocks
            textBlockSnackOneProtein.Text = String.Format("{0:0}g", Data.snacktPro);
            textBlockSnackOneCarbs.Text = String.Format("{0:0}g", Data.snackCarbs);
            textBlockSnackOneFat.Text = String.Format("{0:0}g", Data.snackFat);

            textBlockSnackTwoProtein.Text = String.Format("{0:0}g", Data.snacktPro);
            textBlockSnackTwoCarbs.Text = String.Format("{0:0}g", Data.snackCarbs);
            textBlockSnackTwoFat.Text = String.Format("{0:0}g", Data.snackFat);

            textBlockSnackThreeProtein.Text = String.Format("{0:0}g", Data.snacktPro);
            textBlockSnackThreeCarbs.Text = String.Format("{0:0}g", Data.snackCarbs);
            textBlockSnackThreeFat.Text = String.Format("{0:0}g", Data.snackFat);

            //hook up lunch and dinner figures to textblocks
            textBlockLunchProtein.Text = String.Format("{0:0}g", Data.mealPro);
            textBlockLunchCarbs.Text = String.Format("{0:0}g", Data.mealCarbs);
            textBlockLunchFat.Text = String.Format("{0:0}g", Data.mealFat);

            textBlockDinnerProtein.Text = String.Format("{0:0}g", Data.mealPro);
            textBlockDinnerCarbs.Text = String.Format("{0:0}g", Data.mealCarbs);
            textBlockDinnerFat.Text = String.Format("{0:0}g", Data.mealFat);

        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            //close this window and open main window/input details
            MainWindow win = new MainWindow();
            this.Close();
            win.Show();
        }

        private void buttonHome_Click(object sender, RoutedEventArgs e)
        {
            //close this window and open home window
            Home win = new Home();
            this.Close();
            win.Show();
        }
    }
}
