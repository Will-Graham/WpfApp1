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

namespace WpfApp1
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
        private void DiceValidator(bool a)
        {
            try
            {
                int valuecheck = Convert.ToInt32(txtDiceAmount.Text);
                if (valuecheck < 1)
                {
                    if (a == true) { MessageBox.Show("The number entered as the no. of dices is less than 1." + Environment.NewLine + "Make sure the no. of dice is equal to or greater than 1", "Number Too Small", MessageBoxButton.OK, MessageBoxImage.Error); }
                    txtDiceAmount.Text = "1";

                }
            }
            catch
            {
                if (a == true) { MessageBox.Show("The character entered as the no. of dices is likely not valid" + Environment.NewLine + "Ensure the character is a number greater than or equal to 1", "Invalid Character", MessageBoxButton.OK, MessageBoxImage.Error); }
                txtDiceAmount.Text = "1";
            }
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {

            //lblD2Result.Content = null;
            lstD2Results.Items.Clear();
            //try
            //{
            DiceValidator(false);
                int counter = 1;
                int customNum = Convert.ToInt32(txtDiceAmount.Text);
                int htotal = 0;
                int ttotal = 0;
                Random rand = new Random();
                for (int i = 0; i < customNum; i++)
                {

                    int result = rand.Next(1, 3);
                    if (result == 1)
                    {
                        lstD2Results.Items.Add(counter + ": Heads");
                        //lblD2Result.Content = lblD2Result.Content + "Heads " + Environment.NewLine;
                        htotal = htotal + 1;
                        counter++;
                    }
                    else if (result == 2)
                    {
                        lstD2Results.Items.Add(counter + ": Tails");
                        //lblD2Result.Content = lblD2Result.Content + "Tails " + Environment.NewLine;
                        ttotal = ttotal + 1;
                        counter++;
                    }
                    else
                    {
                        MessageBox.Show("Unacceptable Result: " + rand);
                        
                        
                    }
                }
            //}
            //catch
            //{
            //    MessageBox.Show("error, number may be too large, small"
            //       + ", or is otherwise invalid", "Number Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    txtDiceAmount.Text = "1";
            //}
            // MessageBox.Show("Htotal=" + htotal + " ttotal=" + ttotal);
            //  }
        }

        private void D6_Click(object sender, RoutedEventArgs e)
        {
            lstD6Results.Items.Clear();
            int counter = 1;
            DiceValidator(false);
            int dicenum = Convert.ToInt32(txtDiceAmount.Text);
            Random rand = new Random();
            for (int i = 0; i < dicenum; i++)
            {

                int result = rand.Next(1, 7);

                //lblD6Result.Content = result;
                lstD6Results.Items.Add(counter + ": " + result);
                counter++;
            }

        }

        private void D8_Click(object sender, RoutedEventArgs e)
        {
            lstD8Results.Items.Clear();
            int counter = 1;
            DiceValidator(false);
            int dicenum = Convert.ToInt32(txtDiceAmount.Text);
            Random rand = new Random();
            for (int i = 0; i < dicenum; i++)
            {

                int result = rand.Next(1, 9);
                lstD8Results.Items.Add(counter + ": " + result);
                counter++;

                //Random rand = new Random();

                //int result = rand.Next(1, 9);

                //lblD8Result.Content = result;
            }
        }
        private void D10_Click(object sender, RoutedEventArgs e)
        {
            D10Roll();
            //lstD10Results.Items.Clear();
            //Random rand = new Random();
            //DiceGen dicegen = new DiceGen();
            //DiceValidator(false);
            //int counter = 1;
            //for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++) {
            //    lstD10Results.Items.Add(counter + ": "+dicegen.DiceGenerator(0,10)); counter++;
            //}
            ////int result = rand.Next(1, 11);
            ////int result = dicegen.DiceGenerator(11);
            ////lblD10Result.Content = result;
        }
        private void D10Roll()
        {
            lstD10Results.Items.Clear();
            Random rand = new Random();
            
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
            {
                int result = DiceGen.DiceGenerator(0, 10);
                lstD10Results.Items.Add(counter + ": " + result); counter++;
                D100Handler.setval10(result);
            }
            //int result = rand.Next(1, 11);
            //int result = dicegen.DiceGenerator(11);
            //lblD10Result.Content = result;
        }
        private void D10x10_Click(object sender, RoutedEventArgs e)
        {
            D10x10roll();
            //lstD10x10Results.Items.Clear();
            //Random rand = new Random();
            //DiceGen dicegen = new DiceGen();
            //DiceValidator(false);
            //int counter = 1;
            //for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
            //{
            //    lstD10x10Results.Items.Add(counter + ": " + (dicegen.DiceGenerator(0,10)*10)); counter++;
            //}
            ////Random rand = new Random();

            ////int result = rand.Next(1, 11) * 10;

            ////lblD10x10Result.Content = result;
        }
        private void D10x10roll()
        {
           
            lstD10x10Results.Items.Clear();
            Random rand = new Random();
        
        DiceValidator(false);
        int counter = 1;
            for (int i = 0; i<Convert.ToInt32(txtDiceAmount.Text); i++)
            {
                int result = (DiceGen.DiceGenerator(0, 10) * 10);
                lstD10x10Results.Items.Add(counter + ": " + result ); counter++;
                D100Handler.setval10x10(result);
            }
    //Random rand = new Random();

    //int result = rand.Next(1, 11) * 10;

    //lblD10x10Result.Content = result;
}
private void D12_Click(object sender, RoutedEventArgs e)
        {
            lstD12Results.Items.Clear();            
            //DiceGen dicegen = new DiceGen();
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
            {
                lstD12Results.Items.Add(counter + ": " + DiceGen.DiceGenerator(1, 13)); counter++;
            }
            //Random rand = new Random();

            //int result = rand.Next(1, 13);

            //lblD12Result.Content = result;
        }

        private void D20_Click(object sender, RoutedEventArgs e)
        {
            lstD20Results.Items.Clear();
            //DiceGen dicegen = new DiceGen();
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
            {
                lstD20Results.Items.Add(counter + ": " + DiceGen.DiceGenerator(1, 21)); counter++;
            }
            //Random rand = new Random();

            //int result = rand.Next(1, 21);

            //lblD20Result.Content = result;
        }


        private void Dx_Click(object sender, RoutedEventArgs e)
        {
            DiceValidator(false);
            //int customNum = 50;
            try
            {
                int customNum = Convert.ToInt32(txtDxCustom.Text);
                //string customString = txtDxCustom.Text;
                //Random rand = new Random();

                //int result = rand.Next(1, customNum);

                //lblDxResult.Content = result;
                //lblDX.Content = ("D(" + customNum + "): result:");
                lstDxResults.Items.Clear();
                //DiceGen dicegen = new DiceGen();
                DiceValidator(false);
                int counter = 1;
                for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
                {
                    lstDxResults.Items.Add(counter + ": " + DiceGen.DiceGenerator(1, customNum + 1)); counter++;
                }
            }
            catch
            {
                MessageBox.Show("error, max dice value may be too large,small"
                   + ", or is otherwise invalid", "Number Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void txtDiceAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDiceAmount.Text != "")
                DiceValidator(true);
        }

        private void D100_Click(object sender, RoutedEventArgs e)
        {
            D100Handler.clearout();
            D10Roll();
            D10x10roll();
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)

            {
                int D10val = D100Handler.getval10(i);
                int D10x10val = D100Handler.getval10x10(i);
                int D100val = D10val + D10x10val;
                if (D100val == 0) { D100val = 100; }
                lstD100Results.Items.Add(counter+": "+ D100val);
                counter++;
            }
        }
    }



    //    private void Flip50_Click(object sender, RoutedEventArgs e)
    //    {
    //        {
    //            int htotal = 0;
    //            int ttotal = 0;
    //            Random rand = new Random();
    //            for (int i = 0; i < 100; i++)
    //            {

    //                int result = rand.Next(1, 3);
    //                if (result == 1)
    //                {
    //                    //lblD2Result.Content = "Heads";
    //                    htotal = htotal + 1;
    //                }
    //                else if (result == 2)
    //                {
    //                    //lblD2Result.Content = "Tails";
    //                    ttotal = ttotal + 1;
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Unacceptable Result: " + rand);
    //                }

    //            }
    //            MessageBox.Show("Htotal=" + htotal + " ttotal=" + ttotal);
    //        }
    //    }
    //}
    public static class DiceGen
    {
       static Random rand = new Random();
        public static int DiceGenerator(int FirstNum, int DiceNum)
        {
            int result = rand.Next(FirstNum, DiceNum);
            return result;
        }
    }
    public static class D100Handler
    {
        private static List<int> d10 = new List<int>();
        private static List<int> d10x10 = new List<int>();
        public static void setval10(int a)
        {
            d10.Add(a);
        }
        public static int getval10(int a)
        {
            int content = d10.ElementAt(a);
            return content;

        }
        public static void setval10x10(int a)
        {
            d10x10.Add(a);
        }
        public static int getval10x10(int a)
        {
            int content = d10x10.ElementAt(a);
            return content;
        }
        public static void clearout()
        {
            d10.Clear();
            d10x10.Clear();

         }

    }



}
