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
                    lblconstraint5.Text = labelText;
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
        public void UpdateConstraintLabel(string ConstraintText, int ConstraintNumber)
        {
            switch (ConstraintNumber)
            {
                case 1:
                    lblconstraint1.Text = ConstraintText;
                    break;
                case 2:
                    lblconstraint2.Text = ConstraintText;
                    break;
                case 3:
                    lblconstraint3.Text = ConstraintText;
                    break;
                case 4:
                    lblconstraint4.Text = ConstraintText;
                    break;
                case 5:
                    lblconstraint21.Text = ConstraintText;
                    break;
                case 6:
                    lblconstraint22.Text = ConstraintText;
                    break;
                case 7:
                    lblconstraint23.Text = ConstraintText;
                    break;
                case 8:
                    lblconstraint24.Text = ConstraintText;
                    break;
                case 9:
                    lblconstraint31.Text = ConstraintText;
                    break;
                case 10:
                    lblconstraint32.Text = ConstraintText;
                    break;
                case 11:
                    lblconstraint33.Text = ConstraintText;
                    break;
                case 12:
                    lblconstraint34.Text = ConstraintText;
                    break;
                case 13:
                    lblconstraint41.Text = ConstraintText;
                    break;
                case 14:
                    lblconstraint42.Text = ConstraintText;
                    break;
                case 15:
                    lblconstraint43.Text = ConstraintText;
                    break;
                case 16:
                    lblconstraint44.Text = ConstraintText;
                    break;
                case 17:
                    lblconstraint51.Text = ConstraintText;
                    break;
                case 18:
                    lblconstraint52.Text = ConstraintText;
                    break;
                case 19:
                    lblconstraint53.Text = ConstraintText;
                    break;
                case 20:
                    lblconstraint54.Text = ConstraintText;
                    break;
                default:
                  
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
