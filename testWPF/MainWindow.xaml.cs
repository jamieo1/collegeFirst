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
using System.Data.Entity;


namespace testWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            //remember user input after they have click to calculate
            if (Data.weight != 0 && Data.goal != null && Data.age != 0 && Data.height != 0 && Data.gender != null && Data.activity != null)
            {
                textBoxStone.Text = Data.stone.ToString();
                textBoxPounds.Text = Data.pounds.ToString();

                textBoxAge.Text = Data.age.ToString();

                textBoxFeet.Text = Data.feet.ToString();
                textBoxInches.Text = Data.inches.ToString();

                listBoxGoal.SelectedIndex = Data.goalIndex;
                listBoxGender.SelectedIndex = Data.genderIndex;
                listBoxActivity.SelectedIndex = Data.activityIndex;

            }

        }

        //function to calculate calories
        public double dailyCalories(double weight, int age, double height, string gender, string goal, string activity)
        {
            double bmr = 0;
            double cals = 0;
            double multiplyBy = 0;

            //calc only differs for the last addition or subtraction
            double standard = (weight * 10) + (height * 6.25) - (age * 5);

            if (gender == listBoxMale.ToString())
            {
                bmr = standard + 5;
            }
            else
            {
                bmr = standard - 161;
            }


            switch (goal)
            {//addition and subtraction are opposite of what you might expect as they are subtracted from total later in function
                case "System.Windows.Controls.ListBoxItem: Lose weight - 1lb per week":
                    cals = 500;
                    break;
                case "System.Windows.Controls.ListBoxItem: Lose weight - 2lb per week":
                     cals = 1000;
                    break;
                case "System.Windows.Controls.ListBoxItem: Gain weight - 1lb per week":
                    cals = -500;
                    break;
                case "System.Windows.Controls.ListBoxItem: Gain weight - 2lb per week":
                    cals = -1000;
                    break;
                default:
                    break;
            }


            switch (activity)
            {//depeding on the activity level selected, give relevant multiplaction to BMR
                case "System.Windows.Controls.ListBoxItem: Little to no exercise":
                    /*System.Windows.Controls.ListBoxItem:*/
                    multiplyBy = 1.2;
                    break;
                case "System.Windows.Controls.ListBoxItem: Light exercise (1–3 days per week)":
                    multiplyBy = 1.375;
                    break;
                case "System.Windows.Controls.ListBoxItem: Moderate exercise (3–5 days per week)":
                    multiplyBy = 1.55;
                    break;
                case "System.Windows.Controls.ListBoxItem: Heavy exercise (6–7 days per week)":
                    multiplyBy = 1.725;
                    break;
                case "System.Windows.Controls.ListBoxItem: Very heavy exercise (twice per day, extra heavy workouts)":
                    multiplyBy = 1.9;
                    break;
                default:
                    break;
            }


            return (bmr * multiplyBy) - cals;

        }

        public double heightToCm(int feet, int inches)
        {
            double x;

            x = (feet * 30.48) + (inches * 2.54);


            return x;
        }

        public double weightToKg(int stone, int pounds)
        {
            double x;

            x = (stone * 6.35029) + (pounds * 0.453592);

            return x;
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            try
            {   //catch all for incorrect input in main form.
               

                if (listBoxGoal.SelectedItem == null || listBoxGender.SelectedItem == null ||
                    listBoxActivity.SelectedItem == null)
                {
                    MessageBox.Show("There has been either no Goal, Gender or Activity level selcted. Please check your input.");
                }

                else
                {
                    //take and parse all required user input for main form, if parsing fails catch it
                    Data.stone = int.Parse(textBoxStone.Text);
                    Data.pounds = int.Parse(textBoxPounds.Text);
                    Data.weight = weightToKg(Data.stone, Data.pounds);

                    Data.age = int.Parse(textBoxAge.Text);

                    Data.feet = int.Parse(textBoxFeet.Text);
                    Data.inches = int.Parse(textBoxInches.Text);
                    Data.height = heightToCm(Data.feet, Data.inches);

                    Data.goal = listBoxGoal.SelectedItem.ToString();
                    Data.goalIndex = listBoxGoal.SelectedIndex;

                    Data.gender = listBoxGender.SelectedItem.ToString();
                    Data.genderIndex = listBoxGender.SelectedIndex;

                    Data.activity = listBoxActivity.SelectedItem.ToString();
                    Data.activityIndex = listBoxActivity.SelectedIndex;

                    //work out daily cals using function 
                    Data.dailyCals = dailyCalories(Data.weight, Data.age, Data.height, Data.gender, Data.goal, Data.activity);


                    //work out total carbs for the day
                    Data.carbs = Data.dailyCals * .25;
                    //work out total protein for the day
                    Data.protein = Data.dailyCals * .55;
                    //work out total fat for the day
                    Data.fat = Data.dailyCals * .2;


                    //work out amount of grams for each meal and each type(protein, fat and carbs)
                    //breakfast
                    Data.breakfastPro = (Data.protein * .0252) / 4;
                    Data.breakfastCarbs = (Data.carbs * .0933) / 4;
                    Data.breakfastFat = (Data.fat * .3467) / 8;

                    //snack
                    Data.snacktPro = (Data.protein * .0573) / 4;
                    Data.snackCarbs = (Data.carbs * .1295) / 4;
                    Data.snackFat = (Data.fat * .04) / 8;


                    //main meal
                    Data.mealPro = (Data.protein * .4014) / 4;
                    Data.mealCarbs = (Data.carbs * .2591) / 4;
                    Data.mealFat = (Data.fat * .2666) / 8;


                    //close this window and open input
                    Window2 win2 = new Window2();
                    this.Close();
                    win2.Show();
                }
            }
            catch (Exception)
            {//throw error messsage for any incorrect input.
                MessageBox.Show("There has been an error, please check your input.");
                
            }
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
