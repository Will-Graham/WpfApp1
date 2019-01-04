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
        private void D10_Click(object sender, RoutedEventArgs e)
        {
            lstD10Results.Items.Clear();
            Random rand = new Random();
            DiceGen dicegen = new DiceGen();
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++) {
                lstD10Results.Items.Add(counter + ": "+dicegen.DiceGenerator(11)); counter++;
            }
            //int result = rand.Next(1, 11);
            //int result = dicegen.DiceGenerator(11);
            //lblD10Result.Content = result;
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

                //lblD6Result.Content = result;
                lstD8Results.Items.Add(counter + ": " + result);
                counter++;

                //Random rand = new Random();

                //int result = rand.Next(1, 9);

                //lblD8Result.Content = result;
            }
        }
        private void D10x10_Click(object sender, RoutedEventArgs e)
        {
            lstD10x10Results.Items.Clear();
            Random rand = new Random();
            DiceGen dicegen = new DiceGen();
            DiceValidator(false);
            int counter = 1;
            for (int i = 0; i < Convert.ToInt32(txtDiceAmount.Text); i++)
            {
                lstD10x10Results.Items.Add(counter + ": " + (dicegen.DiceGenerator(11)*10-10)); counter++;
            }
            //Random rand = new Random();

            //int result = rand.Next(1, 11) * 10;

            //lblD10x10Result.Content = result;
        }

        private void D12_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int result = rand.Next(1, 13);

            lblD12Result.Content = result;
        }

        private void D20_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int result = rand.Next(1, 21);

            lblD20Result.Content = result;
        }


        private void Dx_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int customNum = Convert.ToInt32(txtDxCustom.Text);
                string customString = txtDxCustom.Text;
                Random rand = new Random();

                int result = rand.Next(1, customNum);

                lblDxResult.Content = result;
                lblDX.Content = ("D(" + customNum + "): result:");
            }
            catch
            {
                MessageBox.Show("error, number may be too large,small"
                   + ", or is otherwise invalid", "Number Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void txtDiceAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtDiceAmount.Text != "")
                DiceValidator(true);
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
    public class DiceGen
    {
        Random rand = new Random();
        public int DiceGenerator(int DiceNum)
        {
            int result = rand.Next(1, DiceNum);
            return result;
        }
    }
}
