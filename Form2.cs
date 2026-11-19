using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(double d, double e, double f)
        {
            InitializeComponent();

            label1.Text = "HOME SALES SUMMARY";
            label2.Text =
                "Dariel: " + d.ToString("N2") + "\n\n" +
                "Edward: " + e.ToString("N2") + "\n\n" +
                "Fatima: " + f.ToString("N2") + "\n\n" +
                "Total Sales: " + (d + e + f).ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
