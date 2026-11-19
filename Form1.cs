using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        double Dariel = 0, Edward = 0, Fatima = 0;
         
        public Form1()
        {
            InitializeComponent();
            label1.Text = "D-Dariel       E-Edward    F-Fatima ";
            label2.Text="Enter the Ential        :" ;
            label3.Text ="Amount of Sales" ;
            label4.Text = " ";
        }


        private void getselPesrson_Amount(String selintial, double sellAmount)
        {
            switch (selintial.ToUpper()) {
                case "D":
                    Dariel += sellAmount;
                    label4.Text = "sales Succesfull recorded  on file of Dariel  :" + sellAmount +"\n"+
                        "now  Dariel have Total sales Amount of" + Dariel ;
                    break;
                case "E":
                    Edward += sellAmount;
                    label4.Text = "sales Succesfull recorded  on file of Edward  :" + sellAmount + "\n" +
                        "now  Edward have Total sales Amount of" + Edward;
                    break;
                case "F":
                    Fatima += sellAmount;
                    label4.Text = "sales Succesfull recorded  on file of Fatima  :" + sellAmount + "\n" +
                         "now  Fatima have Total sales Amount of" + Fatima;
                    break;
                default :
                    MessageBox.Show("Invalid Initial..");
                    break;
            }

        }


        private void clearAll()
        {
            Edward = 0;
            Dariel = 0;
            Fatima = 0;
            selintial.Text = null;
            selintial.Clear();
            sellAmount.Clear();
            label4.Text = "succesfull Deleted the all files.";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2(Dariel, Edward, Fatima);
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(sellAmount.Text, out amount) && amount > 0)           
                getselPesrson_Amount((String)selintial.Text.Trim(), amount);        
            else 
            
                MessageBox.Show("Invalid number :");
            

        }







        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
