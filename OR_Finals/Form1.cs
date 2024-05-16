namespace OR_Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_title_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateSlackLabelInForm2(ComboBox comboBox, string labelName, Form2 solveform)
        {
            string constraintType = comboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(constraintType))
            {
                solveform.UpdateSlackLabel(constraintType, labelName);
            }
        }
        private void TransferVariables(Form2 solveform)
        {
            try
            {
                // Transfer text from txtVar1 to variable1 label in Form2
                solveform.UpdateVariableLabel(txtVar1.Text, 1);
                // Transfer text from txtVar2 to variable2 label in Form2
                solveform.UpdateVariableLabel(txtVar2.Text, 2);
                // Transfer text from txtVar3 to variable3 label in Form2
                solveform.UpdateVariableLabel(txtVar3.Text, 3);
                // Transfer text from txtVar4 to variable4 label in Form2
                solveform.UpdateVariableLabel(txtVar4.Text, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSolve_Click(object sender, EventArgs e)
        {

            try
            {
                Form2 solveform = new Form2();
                TransferVariables(solveform);
                UpdateSlackLabelInForm2(cbtypofcons1, "lblslacks1", solveform);
                UpdateSlackLabelInForm2(cbtypofcons2, "lblslacks22", solveform);
                UpdateSlackLabelInForm2(cbtypofcons3, "lblslacks33", solveform);
                UpdateSlackLabelInForm2(cbtypofcons4, "lblslacks44", solveform);
                UpdateSlackLabelInForm2(cbtypofcons5, "lblslacks55", solveform);

                solveform.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbtypofcons1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbtypofcons2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtypofcons3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtypofcons4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtypofcons5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtVar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVar2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVar3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVar4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
