using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.LinkLabel;
namespace Percentage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //will only function if allocated cases is not 0
            if (allocatedCases.Text != "0")
            {
                //calculates the percentage of closed/allocated cases
                decimal calculate_percentage = ((Convert.ToDecimal(closedCases.Text)) / (Convert.ToDecimal(allocatedCases.Text)) * 100);
                //ensures that closed cases can't exceed allocated cases and that the username box has a name
                if (calculate_percentage <= 100 && userbox.Text != "")
                {
                    //prints the calculated result to the display box, formatted to two decimals with a % 
                    percentageRes.Text = calculate_percentage.ToString("0.00") + "%";
                    //creating variables to set the path and file name for the text file
                    string directory = @"C:\Users\Nathan.Morphett\Desktop\Visual_Studio\Percentage_Calculator";
                    string filename = String.Format("{0:dd-MM-yyyy}.txt", DateTime.Now);
                    string path = Path.Combine(directory, filename);
                    //saving the text output to username box and result box to a text file, appending any entries
                    //done on the same day
                    using (StreamWriter SW = File.AppendText(path))
                    {
                        SW.WriteLine(userbox.Text);
                        SW.WriteLine(percentageRes.Text);
                        SW.Close();
                    }
                }
                //prints error if invalid inputs
                else
                {
                    MessageBox.Show("Please check inputs", "ERROR 451", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //prints error if invalid inputs
            else
            {
                MessageBox.Show("Please check inputs", "ERROR 451", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closedCases_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
