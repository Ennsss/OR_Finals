namespace OR_Finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbNoofCons = new ComboBox();
            cbNoofVar = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txt_title = new Label();
            txtVar1 = new TextBox();
            cbtypofcons1 = new ComboBox();
            btnSolve = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            txtVar4 = new TextBox();
            label6 = new Label();
            txtVar3 = new TextBox();
            label5 = new Label();
            txtVar2 = new TextBox();
            label26 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtrhs5 = new TextBox();
            cbtypofcons5 = new ComboBox();
            label25 = new Label();
            cons54 = new TextBox();
            cons52 = new TextBox();
            label27 = new Label();
            label28 = new Label();
            cons53 = new TextBox();
            cons51 = new TextBox();
            label29 = new Label();
            txtrhs4 = new TextBox();
            cbtypofcons4 = new ComboBox();
            label21 = new Label();
            cons44 = new TextBox();
            cons42 = new TextBox();
            label22 = new Label();
            label23 = new Label();
            cons43 = new TextBox();
            cons41 = new TextBox();
            label24 = new Label();
            txtrhs3 = new TextBox();
            cbtypofcons3 = new ComboBox();
            label17 = new Label();
            cons34 = new TextBox();
            cons32 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            cons33 = new TextBox();
            cons31 = new TextBox();
            label20 = new Label();
            txtrhs2 = new TextBox();
            cbtypofcons2 = new ComboBox();
            label13 = new Label();
            cons24 = new TextBox();
            cons22 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            cons23 = new TextBox();
            cons21 = new TextBox();
            label16 = new Label();
            txtrhs1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            cons4 = new TextBox();
            cons2 = new TextBox();
            label10 = new Label();
            label12 = new Label();
            cons3 = new TextBox();
            cons1 = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbNoofCons
            // 
            cbNoofCons.FormattingEnabled = true;
            cbNoofCons.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbNoofCons.Location = new Point(268, 28);
            cbNoofCons.Name = "cbNoofCons";
            cbNoofCons.Size = new Size(60, 23);
            cbNoofCons.TabIndex = 0;
            // 
            // cbNoofVar
            // 
            cbNoofVar.FormattingEnabled = true;
            cbNoofVar.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbNoofVar.Location = new Point(268, 57);
            cbNoofVar.Name = "cbNoofVar";
            cbNoofVar.Size = new Size(60, 23);
            cbNoofVar.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 28);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 2;
            label1.Text = "Number of Constraints:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 57);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 3;
            label2.Text = "Number of Variables:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.FromArgb(14, 70, 163);
            txt_title.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_title.ForeColor = SystemColors.Control;
            txt_title.Location = new Point(-2, 0);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(1008, 87);
            txt_title.TabIndex = 4;
            txt_title.Text = "Minimization";
            txt_title.TextAlign = ContentAlignment.MiddleCenter;
            txt_title.Click += txt_title_Click;
            // 
            // txtVar1
            // 
            txtVar1.Location = new Point(493, 57);
            txtVar1.Name = "txtVar1";
            txtVar1.Size = new Size(57, 23);
            txtVar1.TabIndex = 5;
            // 
            // cbtypofcons1
            // 
            cbtypofcons1.FormattingEnabled = true;
            cbtypofcons1.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons1.Location = new Point(677, 101);
            cbtypofcons1.Name = "cbtypofcons1";
            cbtypofcons1.Size = new Size(50, 23);
            cbtypofcons1.TabIndex = 22;
            // 
            // btnSolve
            // 
            btnSolve.Cursor = Cursors.Hand;
            btnSolve.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSolve.Location = new Point(462, 379);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(88, 30);
            btnSolve.TabIndex = 54;
            btnSolve.Text = "Calculate";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(428, 25);
            label3.Name = "label3";
            label3.Size = new Size(294, 23);
            label3.TabIndex = 57;
            label3.Text = "Enter the values of the objective function:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtVar4);
            panel1.Controls.Add(cbNoofCons);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbNoofVar);
            panel1.Controls.Add(txtVar3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtVar1);
            panel1.Controls.Add(txtVar2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-2, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 110);
            panel1.TabIndex = 58;
            // 
            // label7
            // 
            label7.Font = new Font("Tahoma", 10F);
            label7.Location = new Point(907, 57);
            label7.Name = "label7";
            label7.Size = new Size(49, 23);
            label7.TabIndex = 66;
            label7.Text = "x4 ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar4
            // 
            txtVar4.Location = new Point(844, 57);
            txtVar4.Name = "txtVar4";
            txtVar4.Size = new Size(57, 23);
            txtVar4.TabIndex = 65;
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 10F);
            label6.Location = new Point(789, 57);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 64;
            label6.Text = "x3 + ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar3
            // 
            txtVar3.Location = new Point(726, 57);
            txtVar3.Name = "txtVar3";
            txtVar3.Size = new Size(57, 23);
            txtVar3.TabIndex = 63;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10F);
            label5.Location = new Point(671, 57);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 62;
            label5.Text = "x2 + ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar2
            // 
            txtVar2.Location = new Point(608, 57);
            txtVar2.Name = "txtVar2";
            txtVar2.Size = new Size(57, 23);
            txtVar2.TabIndex = 61;
            // 
            // label26
            // 
            label26.Font = new Font("Tahoma", 10F);
            label26.Location = new Point(556, 57);
            label26.Name = "label26";
            label26.Size = new Size(49, 23);
            label26.TabIndex = 60;
            label26.Text = "x1 + ";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            label26.Click += label26_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(434, 56);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 59;
            label4.Text = "f(x) = ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtrhs5);
            panel2.Controls.Add(btnSolve);
            panel2.Controls.Add(cbtypofcons5);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(cons54);
            panel2.Controls.Add(cons52);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(cons53);
            panel2.Controls.Add(cons51);
            panel2.Controls.Add(label29);
            panel2.Controls.Add(txtrhs4);
            panel2.Controls.Add(cbtypofcons4);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(cons44);
            panel2.Controls.Add(cons42);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(cons43);
            panel2.Controls.Add(cons41);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(txtrhs3);
            panel2.Controls.Add(cbtypofcons3);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(cons34);
            panel2.Controls.Add(cons32);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(cons33);
            panel2.Controls.Add(cons31);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(txtrhs2);
            panel2.Controls.Add(cbtypofcons2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(cons24);
            panel2.Controls.Add(cons22);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(cons23);
            panel2.Controls.Add(cons21);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtrhs1);
            panel2.Controls.Add(cbtypofcons1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cons4);
            panel2.Controls.Add(cons2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cons3);
            panel2.Controls.Add(cons1);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(-2, 206);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 476);
            panel2.TabIndex = 59;
            // 
            // txtrhs5
            // 
            txtrhs5.Location = new Point(746, 283);
            txtrhs5.Name = "txtrhs5";
            txtrhs5.Size = new Size(57, 23);
            txtrhs5.TabIndex = 115;
            // 
            // cbtypofcons5
            // 
            cbtypofcons5.FormattingEnabled = true;
            cbtypofcons5.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons5.Location = new Point(677, 283);
            cbtypofcons5.Name = "cbtypofcons5";
            cbtypofcons5.Size = new Size(50, 23);
            cbtypofcons5.TabIndex = 106;
            // 
            // label25
            // 
            label25.Font = new Font("Tahoma", 10F);
            label25.Location = new Point(622, 282);
            label25.Name = "label25";
            label25.Size = new Size(49, 23);
            label25.TabIndex = 114;
            label25.Text = "x4 ";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons54
            // 
            cons54.Location = new Point(559, 282);
            cons54.Name = "cons54";
            cons54.Size = new Size(57, 23);
            cons54.TabIndex = 113;
            cons54.TextChanged += textBox26_TextChanged;
            // 
            // cons52
            // 
            cons52.Location = new Point(323, 282);
            cons52.Name = "cons52";
            cons52.Size = new Size(57, 23);
            cons52.TabIndex = 109;
            // 
            // label27
            // 
            label27.Font = new Font("Tahoma", 10F);
            label27.Location = new Point(504, 282);
            label27.Name = "label27";
            label27.Size = new Size(49, 23);
            label27.TabIndex = 112;
            label27.Text = "x3 + ";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            label28.Font = new Font("Tahoma", 10F);
            label28.Location = new Point(271, 282);
            label28.Name = "label28";
            label28.Size = new Size(49, 23);
            label28.TabIndex = 108;
            label28.Text = "x1 + ";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons53
            // 
            cons53.Location = new Point(441, 282);
            cons53.Name = "cons53";
            cons53.Size = new Size(57, 23);
            cons53.TabIndex = 111;
            // 
            // cons51
            // 
            cons51.Location = new Point(208, 282);
            cons51.Name = "cons51";
            cons51.Size = new Size(57, 23);
            cons51.TabIndex = 107;
            cons51.TextChanged += textBox29_TextChanged;
            // 
            // label29
            // 
            label29.Font = new Font("Tahoma", 10F);
            label29.Location = new Point(386, 282);
            label29.Name = "label29";
            label29.Size = new Size(49, 23);
            label29.TabIndex = 110;
            label29.Text = "x2 + ";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtrhs4
            // 
            txtrhs4.Location = new Point(746, 236);
            txtrhs4.Name = "txtrhs4";
            txtrhs4.Size = new Size(57, 23);
            txtrhs4.TabIndex = 105;
            // 
            // cbtypofcons4
            // 
            cbtypofcons4.FormattingEnabled = true;
            cbtypofcons4.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons4.Location = new Point(677, 236);
            cbtypofcons4.Name = "cbtypofcons4";
            cbtypofcons4.Size = new Size(50, 23);
            cbtypofcons4.TabIndex = 96;
            // 
            // label21
            // 
            label21.Font = new Font("Tahoma", 10F);
            label21.Location = new Point(622, 235);
            label21.Name = "label21";
            label21.Size = new Size(49, 23);
            label21.TabIndex = 104;
            label21.Text = "x4 ";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons44
            // 
            cons44.Location = new Point(559, 235);
            cons44.Name = "cons44";
            cons44.Size = new Size(57, 23);
            cons44.TabIndex = 103;
            cons44.TextChanged += textBox21_TextChanged;
            // 
            // cons42
            // 
            cons42.Location = new Point(323, 235);
            cons42.Name = "cons42";
            cons42.Size = new Size(57, 23);
            cons42.TabIndex = 99;
            // 
            // label22
            // 
            label22.Font = new Font("Tahoma", 10F);
            label22.Location = new Point(504, 235);
            label22.Name = "label22";
            label22.Size = new Size(49, 23);
            label22.TabIndex = 102;
            label22.Text = "x3 + ";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Font = new Font("Tahoma", 10F);
            label23.Location = new Point(271, 235);
            label23.Name = "label23";
            label23.Size = new Size(49, 23);
            label23.TabIndex = 98;
            label23.Text = "x1 + ";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons43
            // 
            cons43.Location = new Point(441, 235);
            cons43.Name = "cons43";
            cons43.Size = new Size(57, 23);
            cons43.TabIndex = 101;
            // 
            // cons41
            // 
            cons41.Location = new Point(208, 235);
            cons41.Name = "cons41";
            cons41.Size = new Size(57, 23);
            cons41.TabIndex = 97;
            // 
            // label24
            // 
            label24.Font = new Font("Tahoma", 10F);
            label24.Location = new Point(386, 235);
            label24.Name = "label24";
            label24.Size = new Size(49, 23);
            label24.TabIndex = 100;
            label24.Text = "x2 + ";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtrhs3
            // 
            txtrhs3.Location = new Point(746, 190);
            txtrhs3.Name = "txtrhs3";
            txtrhs3.Size = new Size(57, 23);
            txtrhs3.TabIndex = 95;
            // 
            // cbtypofcons3
            // 
            cbtypofcons3.FormattingEnabled = true;
            cbtypofcons3.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons3.Location = new Point(677, 190);
            cbtypofcons3.Name = "cbtypofcons3";
            cbtypofcons3.Size = new Size(50, 23);
            cbtypofcons3.TabIndex = 86;
            // 
            // label17
            // 
            label17.Font = new Font("Tahoma", 10F);
            label17.Location = new Point(622, 189);
            label17.Name = "label17";
            label17.Size = new Size(49, 23);
            label17.TabIndex = 94;
            label17.Text = "x4 ";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons34
            // 
            cons34.Location = new Point(559, 189);
            cons34.Name = "cons34";
            cons34.Size = new Size(57, 23);
            cons34.TabIndex = 93;
            // 
            // cons32
            // 
            cons32.Location = new Point(323, 189);
            cons32.Name = "cons32";
            cons32.Size = new Size(57, 23);
            cons32.TabIndex = 89;
            // 
            // label18
            // 
            label18.Font = new Font("Tahoma", 10F);
            label18.Location = new Point(504, 189);
            label18.Name = "label18";
            label18.Size = new Size(49, 23);
            label18.TabIndex = 92;
            label18.Text = "x3 + ";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Font = new Font("Tahoma", 10F);
            label19.Location = new Point(271, 189);
            label19.Name = "label19";
            label19.Size = new Size(49, 23);
            label19.TabIndex = 88;
            label19.Text = "x1 + ";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons33
            // 
            cons33.Location = new Point(441, 189);
            cons33.Name = "cons33";
            cons33.Size = new Size(57, 23);
            cons33.TabIndex = 91;
            // 
            // cons31
            // 
            cons31.Location = new Point(208, 189);
            cons31.Name = "cons31";
            cons31.Size = new Size(57, 23);
            cons31.TabIndex = 87;
            // 
            // label20
            // 
            label20.Font = new Font("Tahoma", 10F);
            label20.Location = new Point(386, 189);
            label20.Name = "label20";
            label20.Size = new Size(49, 23);
            label20.TabIndex = 90;
            label20.Text = "x2 + ";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtrhs2
            // 
            txtrhs2.Location = new Point(746, 145);
            txtrhs2.Name = "txtrhs2";
            txtrhs2.Size = new Size(57, 23);
            txtrhs2.TabIndex = 85;
            // 
            // cbtypofcons2
            // 
            cbtypofcons2.FormattingEnabled = true;
            cbtypofcons2.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons2.Location = new Point(677, 145);
            cbtypofcons2.Name = "cbtypofcons2";
            cbtypofcons2.Size = new Size(50, 23);
            cbtypofcons2.TabIndex = 76;
            // 
            // label13
            // 
            label13.Font = new Font("Tahoma", 10F);
            label13.Location = new Point(622, 144);
            label13.Name = "label13";
            label13.Size = new Size(49, 23);
            label13.TabIndex = 84;
            label13.Text = "x4 ";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons24
            // 
            cons24.Location = new Point(559, 144);
            cons24.Name = "cons24";
            cons24.Size = new Size(57, 23);
            cons24.TabIndex = 83;
            // 
            // cons22
            // 
            cons22.Location = new Point(323, 144);
            cons22.Name = "cons22";
            cons22.Size = new Size(57, 23);
            cons22.TabIndex = 79;
            // 
            // label14
            // 
            label14.Font = new Font("Tahoma", 10F);
            label14.Location = new Point(504, 144);
            label14.Name = "label14";
            label14.Size = new Size(49, 23);
            label14.TabIndex = 82;
            label14.Text = "x3 + ";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Tahoma", 10F);
            label15.Location = new Point(271, 144);
            label15.Name = "label15";
            label15.Size = new Size(49, 23);
            label15.TabIndex = 78;
            label15.Text = "x1 + ";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons23
            // 
            cons23.Location = new Point(441, 144);
            cons23.Name = "cons23";
            cons23.Size = new Size(57, 23);
            cons23.TabIndex = 81;
            // 
            // cons21
            // 
            cons21.Location = new Point(208, 144);
            cons21.Name = "cons21";
            cons21.Size = new Size(57, 23);
            cons21.TabIndex = 77;
            // 
            // label16
            // 
            label16.Font = new Font("Tahoma", 10F);
            label16.Location = new Point(386, 144);
            label16.Name = "label16";
            label16.Size = new Size(49, 23);
            label16.TabIndex = 80;
            label16.Text = "x2 + ";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtrhs1
            // 
            txtrhs1.Location = new Point(746, 101);
            txtrhs1.Name = "txtrhs1";
            txtrhs1.Size = new Size(57, 23);
            txtrhs1.TabIndex = 75;
            // 
            // label9
            // 
            label9.Font = new Font("Tahoma", 10F);
            label9.Location = new Point(622, 100);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 74;
            label9.Text = "x4 ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Tahoma", 10F);
            label8.Location = new Point(348, 32);
            label8.Name = "label8";
            label8.Size = new Size(294, 23);
            label8.TabIndex = 67;
            label8.Text = "Enter the values of the system of constraints:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons4
            // 
            cons4.Location = new Point(559, 100);
            cons4.Name = "cons4";
            cons4.Size = new Size(57, 23);
            cons4.TabIndex = 73;
            // 
            // cons2
            // 
            cons2.Location = new Point(323, 100);
            cons2.Name = "cons2";
            cons2.Size = new Size(57, 23);
            cons2.TabIndex = 69;
            cons2.TextChanged += textBox8_TextChanged;
            // 
            // label10
            // 
            label10.Font = new Font("Tahoma", 10F);
            label10.Location = new Point(504, 100);
            label10.Name = "label10";
            label10.Size = new Size(49, 23);
            label10.TabIndex = 72;
            label10.Text = "x3 + ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Tahoma", 10F);
            label12.Location = new Point(271, 100);
            label12.Name = "label12";
            label12.Size = new Size(49, 23);
            label12.TabIndex = 68;
            label12.Text = "x1 + ";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cons3
            // 
            cons3.Location = new Point(441, 100);
            cons3.Name = "cons3";
            cons3.Size = new Size(57, 23);
            cons3.TabIndex = 71;
            // 
            // cons1
            // 
            cons1.Location = new Point(208, 100);
            cons1.Name = "cons1";
            cons1.Size = new Size(57, 23);
            cons1.TabIndex = 67;
            // 
            // label11
            // 
            label11.Font = new Font("Tahoma", 10F);
            label11.Location = new Point(386, 100);
            label11.Name = "label11";
            label11.Size = new Size(49, 23);
            label11.TabIndex = 70;
            label11.Text = "x2 + ";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 681);
            Controls.Add(panel1);
            Controls.Add(txt_title);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Minimization - Simplex Merthod";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbNoofCons;
        private ComboBox cbNoofVar;
        private Label label1;
        private Label label2;
        private Label txt_title;
        private TextBox txtVar1;
        private ComboBox cbtypofcons1;
        private Button btnSolve;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label26;
        private Label label7;
        private TextBox txtVar4;
        private Label label6;
        private TextBox txtVar3;
        private Label label5;
        private TextBox txtVar2;
        private Panel panel2;
        private Label label8;
        private TextBox txtrhs1;
        private Label label9;
        private TextBox cons4;
        private TextBox cons2;
        private Label label10;
        private Label label12;
        private TextBox cons3;
        private TextBox cons1;
        private Label label11;
        private TextBox txtrhs5;
        private ComboBox cbtypofcons5;
        private Label label25;
        private TextBox cons54;
        private TextBox cons52;
        private Label label27;
        private Label label28;
        private TextBox cons53;
        private TextBox cons51;
        private Label label29;
        private TextBox txtrhs4;
        private ComboBox cbtypofcons4;
        private Label label21;
        private TextBox cons44;
        private TextBox cons42;
        private Label label22;
        private Label label23;
        private TextBox cons43;
        private TextBox cons41;
        private Label label24;
        private TextBox txtrhs3;
        private ComboBox cbtypofcons3;
        private Label label17;
        private TextBox cons34;
        private TextBox cons32;
        private Label label18;
        private Label label19;
        private TextBox cons33;
        private TextBox cons31;
        private Label label20;
        private TextBox txtrhs2;
        private ComboBox cbtypofcons2;
        private Label label13;
        private TextBox cons24;
        private TextBox cons22;
        private Label label14;
        private Label label15;
        private TextBox cons23;
        private TextBox cons21;
        private Label label16;
    }
}
