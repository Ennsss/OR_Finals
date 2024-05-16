namespace OR_Finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void UpdateSlackLabelInForm2(ComboBox comboBox, string labelName, Form2 solveform)
        {
            string constraintType = comboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(constraintType))
            {
                solveform.UpdateSlackLabel(constraintType, labelName);
            }
        }
        private void ChangeConstraint()
        {

        }
        private void UpdateConstraints(Form2 solveform)
        {
            try
            {

                solveform.UpdateConstraintLabel(cons1.Text, 1);
                solveform.UpdateConstraintLabel(cons2.Text, 2);
                solveform.UpdateConstraintLabel(cons3.Text, 3);
                solveform.UpdateConstraintLabel(cons4.Text, 4);
                solveform.UpdateConstraintLabel(cons21.Text, 5);
                solveform.UpdateConstraintLabel(cons22.Text, 6);
                solveform.UpdateConstraintLabel(cons23.Text, 7);
                solveform.UpdateConstraintLabel(cons24.Text, 8);
                solveform.UpdateConstraintLabel(cons31.Text, 9);
                solveform.UpdateConstraintLabel(cons32.Text, 10);
                solveform.UpdateConstraintLabel(cons33.Text, 11);
                solveform.UpdateConstraintLabel(cons34.Text, 12);
                solveform.UpdateConstraintLabel(cons41.Text, 13);
                solveform.UpdateConstraintLabel(cons42.Text, 14);
                solveform.UpdateConstraintLabel(cons43.Text, 15);
                solveform.UpdateConstraintLabel(cons44.Text, 16);
                solveform.UpdateConstraintLabel(cons51.Text, 17);
                solveform.UpdateConstraintLabel(cons52.Text, 18);
                solveform.UpdateConstraintLabel(cons53.Text, 19);
                solveform.UpdateConstraintLabel(cons54.Text, 20);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TransferVariables(Form2 solveform)
        {
            try
            {

                solveform.UpdateVariableLabel(txtVar1.Text, 1);

                solveform.UpdateVariableLabel(txtVar2.Text, 2);

                solveform.UpdateVariableLabel(txtVar3.Text, 3);

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
                UpdateConstraints(solveform);
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

        private void cbNoofCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfCons = cbNoofCons.SelectedIndex + 1; 

            for (int i = 2; i <= 5; i++)
            {
                bool isVisible = i <= numberOfCons; 

                Controls.Find($"cons{i}1", true)[0].Visible = isVisible;
                Controls.Find($"cons{i}2", true)[0].Visible = isVisible;
                Controls.Find($"cons{i}3", true)[0].Visible = isVisible;
                Controls.Find($"cons{i}4", true)[0].Visible = isVisible;
                Controls.Find($"labelcons{i}1", true)[0].Visible = isVisible;
                Controls.Find($"labelcons{i}2", true)[0].Visible = isVisible;
                Controls.Find($"labelcons{i}3", true)[0].Visible = isVisible;
                Controls.Find($"labelcons{i}4", true)[0].Visible = isVisible;
                Controls.Find($"cbtypofcons{i}", true)[0].Visible = isVisible;
                Controls.Find($"txtrhs{i}", true)[0].Visible = isVisible;
            }
        }

        private void cbNoofVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfVars = cbNoofVar.SelectedIndex + 1; 

            for (int i = 2; i <= 4; i++)
            {
                bool isVisible = i <= numberOfVars;

                Controls.Find($"txtVar{i}", true)[0].Visible = isVisible;
                Controls.Find($"labelx{i}", true)[0].Visible = isVisible;
            }
        }


        private void labelcons34_Click(object sender, EventArgs e)
        {

        }
    }
}
