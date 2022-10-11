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
            if (allocatedCases.Text != "0")
            {
                decimal calculate_percentage = ((Convert.ToDecimal(closedCases.Text)) / (Convert.ToDecimal(allocatedCases.Text)) * 100);
                if (calculate_percentage <= 100 && userbox.Text != "")
                {
                    percentageRes.Text = calculate_percentage.ToString("0.00") + "%";
                    string directory = @"C:\Users\Nathan.Morphett\Desktop\Visual_Studio\Percentage_Calculator";
                    string filename = String.Format("{0:dd-MM-yyyy}.txt", DateTime.Now);
                    string path = Path.Combine(directory, filename);

                    using (StreamWriter SW = File.AppendText(path))
                    {
                        SW.WriteLine(userbox.Text);
                        SW.WriteLine(percentageRes.Text);
                        SW.Close();
                    }
                }
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