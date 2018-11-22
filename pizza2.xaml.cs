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

namespace classpro
{
    /// <summary>
    /// Interaction logic for pizza2.xaml
    /// </summary>
    public partial class pizza2 : Window

    {

        public int PizzaPrice = 0;
        public int Toppings = 0;
        public int counter = 0;
        public static double Tamount = 0;

        public pizza2()
        {
            InitializeComponent();

        }

        //Pizza Size
        private void Rsmall_Checked(object sender, RoutedEventArgs e)
        {
            PizzaPrice = 10;
            bill.Content = PizzaPrice.ToString();
        }
        private void Rmedium_Checked_1(object sender, RoutedEventArgs e)
        {
            PizzaPrice = 13;
            bill.Content = PizzaPrice.ToString();
        }

        private void Rlarge_Checked_1(object sender, RoutedEventArgs e)
        {
            PizzaPrice = 17;
            bill.Content = PizzaPrice.ToString();
        }
        //Crust section
        private void BSC_Checked(object sender, RoutedEventArgs e)
        {
            PizzaPrice++;
            bill.Content = PizzaPrice.ToString();
        }

        private void TC_Checked(object sender, RoutedEventArgs e)

        {
            PizzaPrice ++;
            bill.Content = PizzaPrice.ToString();
        }

        private void CSC_Checked(object sender, RoutedEventArgs e)
        {
            PizzaPrice++;
            bill.Content = PizzaPrice.ToString();
        }


        //Topping section

        public void addtopping()
        {
            Console.WriteLine("checked");


            counter++;



            if (counter >= 3)
            {
                int More = counter - 3;

                Toppings = More * 1;

            }
            else
            {
                Toppings = 0;
            }

          bill.Content = (PizzaPrice + Toppings).ToString();
        }
        public void removetopping()
        {

            Console.WriteLine("unchecked");

            Console.WriteLine("before removing " + counter);
            counter--;

            Console.WriteLine("after removing " + counter);


            if (counter >= 3)
            {
                int Less = counter - 3;

                Toppings = Less * 1;

            }
            else
            {
                Toppings = 0;
            }

            bill.Content = (PizzaPrice + Toppings).ToString();
        }


        private void CB1_Checked(object sender, RoutedEventArgs e)
        {
            if(CB1.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }
        private void CB2_Checked(object sender, RoutedEventArgs e)
        {
            if (CB2.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB3_Checked(object sender, RoutedEventArgs e)
        {
            if (CB3.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB4_Checked(object sender, RoutedEventArgs e)
        {
            if (CB4.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB5_Checked(object sender, RoutedEventArgs e)
        {
            if (CB5.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB6_Checked(object sender, RoutedEventArgs e)
        {
            if (CB6.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB7_Checked(object sender, RoutedEventArgs e)
        {
            if (CB7.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB8_Checked(object sender, RoutedEventArgs e)
        {
            if (CB8.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void CB9_Checked(object sender, RoutedEventArgs e)
        {
            if (CB9.IsChecked == true)
            {
                addtopping();
            }
            else
            {
                removetopping();
            }
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            
            Total = (double.Tamount * 13) / 100;
        }
    }
}

