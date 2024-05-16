using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OR_Finals
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        public void UpdateSlackLabel(string constraintType, string labelName)
        {
            string labelText = string.Empty;
            switch (constraintType)
            {
                case ">=":
                    labelText = "-s1";
                    break;
                case "=":
                    labelText = " ";
                    break;
                case "<=":
                    labelText = "+s1";
                    break;
                default:
                    labelText = string.Empty;
                    break;
            }

            switch (labelName)
            {
                case "lblslacks1":
                    lblslacks1.Text = labelText;
                    break;
                case "lblslacks22":
                    lblslacks22.Text = labelText;
                    break;
                case "lblslacks33":
                    lblslacks33.Text = labelText;
                    break;
                case "lblslacks44":
                    lblslacks44.Text = labelText;
                    break;
                case "lblslacks55":
                    lblslacks55.Text = labelText;
                    break;
                default:
                    break;
            }
        }
        public void UpdateVariableLabel(string varText, int variableNumber)
        {
            switch (variableNumber)
            {
                case 1:
                    variable11.Text = varText;
                    break;
                case 2:
                    variable22.Text = varText;
                    break;
                case 3:
                    variable3.Text = varText;
                    break;
                case 4:
                    variable4.Text = varText;
                    break;
                default:
                    // Handle if needed
                    break;
            }
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblslacks1_Click(object sender, EventArgs e)
        {

        }

        private void artificial1_Click(object sender, EventArgs e)
        {

        }

        private void artificial1_Click_1(object sender, EventArgs e)
        {

        }

        private void variable1_TextChanged(object sender, EventArgs e)
        {

        }

        private void variable2_TextChanged(object sender, EventArgs e)
        {

        }

        private void variable3_TextChanged(object sender, EventArgs e)
        {

        }

        private void variable4_TextChanged(object sender, EventArgs e)
        {

        }

        private void variable1_Click(object sender, EventArgs e)
        {

        }
    }
}
