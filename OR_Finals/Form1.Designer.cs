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
            labelx4 = new Label();
            txtVar4 = new TextBox();
            labelx3 = new Label();
            txtVar3 = new TextBox();
            labelx2 = new Label();
            txtVar2 = new TextBox();
            label26 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtrhs5 = new TextBox();
            cbtypofcons5 = new ComboBox();
            labelcons54 = new Label();
            cons54 = new TextBox();
            cons52 = new TextBox();
            labelcons53 = new Label();
            labelcons51 = new Label();
            cons53 = new TextBox();
            cons51 = new TextBox();
            labelcons52 = new Label();
            txtrhs4 = new TextBox();
            cbtypofcons4 = new ComboBox();
            labelcons44 = new Label();
            cons44 = new TextBox();
            cons42 = new TextBox();
            labelcons43 = new Label();
            labelcons41 = new Label();
            cons43 = new TextBox();
            cons41 = new TextBox();
            labelcons42 = new Label();
            txtrhs3 = new TextBox();
            cbtypofcons3 = new ComboBox();
            labelcons34 = new Label();
            cons34 = new TextBox();
            cons32 = new TextBox();
            labelcons33 = new Label();
            labelcons31 = new Label();
            cons33 = new TextBox();
            cons31 = new TextBox();
            labelcons32 = new Label();
            txtrhs2 = new TextBox();
            cbtypofcons2 = new ComboBox();
            labelcons24 = new Label();
            cons24 = new TextBox();
            cons22 = new TextBox();
            labelcons23 = new Label();
            labelcons21 = new Label();
            cons23 = new TextBox();
            cons21 = new TextBox();
            labelcons22 = new Label();
            txtrhs1 = new TextBox();
            labelcons4 = new Label();
            label8 = new Label();
            cons4 = new TextBox();
            cons2 = new TextBox();
            labelcons3 = new Label();
            label12 = new Label();
            cons3 = new TextBox();
            cons1 = new TextBox();
            labelcons2 = new Label();
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
            cbNoofCons.SelectedIndexChanged += cbNoofCons_SelectedIndexChanged;
            // 
            // cbNoofVar
            // 
            cbNoofVar.FormattingEnabled = true;
            cbNoofVar.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbNoofVar.Location = new Point(268, 57);
            cbNoofVar.Name = "cbNoofVar";
            cbNoofVar.Size = new Size(60, 23);
            cbNoofVar.TabIndex = 1;
            cbNoofVar.SelectedIndexChanged += cbNoofVar_SelectedIndexChanged;
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
            txtVar1.TextChanged += txtVar1_TextChanged;
            // 
            // cbtypofcons1
            // 
            cbtypofcons1.FormattingEnabled = true;
            cbtypofcons1.Items.AddRange(new object[] { "=", "<=", ">=" });
            cbtypofcons1.Location = new Point(677, 101);
            cbtypofcons1.Name = "cbtypofcons1";
            cbtypofcons1.Size = new Size(50, 23);
            cbtypofcons1.TabIndex = 22;
            cbtypofcons1.SelectedIndexChanged += cbtypofcons1_SelectedIndexChanged;
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
            panel1.Controls.Add(labelx4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtVar4);
            panel1.Controls.Add(cbNoofCons);
            panel1.Controls.Add(labelx3);
            panel1.Controls.Add(cbNoofVar);
            panel1.Controls.Add(txtVar3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelx2);
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
            // labelx4
            // 
            labelx4.Font = new Font("Tahoma", 10F);
            labelx4.Location = new Point(907, 57);
            labelx4.Name = "labelx4";
            labelx4.Size = new Size(49, 23);
            labelx4.TabIndex = 66;
            labelx4.Text = "x4 ";
            labelx4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar4
            // 
            txtVar4.Location = new Point(844, 57);
            txtVar4.Name = "txtVar4";
            txtVar4.Size = new Size(57, 23);
            txtVar4.TabIndex = 65;
            txtVar4.TextChanged += txtVar4_TextChanged;
            // 
            // labelx3
            // 
            labelx3.Font = new Font("Tahoma", 10F);
            labelx3.Location = new Point(789, 57);
            labelx3.Name = "labelx3";
            labelx3.Size = new Size(49, 23);
            labelx3.TabIndex = 64;
            labelx3.Text = "x3 + ";
            labelx3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar3
            // 
            txtVar3.Location = new Point(726, 57);
            txtVar3.Name = "txtVar3";
            txtVar3.Size = new Size(57, 23);
            txtVar3.TabIndex = 63;
            txtVar3.TextChanged += txtVar3_TextChanged;
            // 
            // labelx2
            // 
            labelx2.Font = new Font("Tahoma", 10F);
            labelx2.Location = new Point(671, 57);
            labelx2.Name = "labelx2";
            labelx2.Size = new Size(49, 23);
            labelx2.TabIndex = 62;
            labelx2.Text = "x2 + ";
            labelx2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtVar2
            // 
            txtVar2.Location = new Point(608, 57);
            txtVar2.Name = "txtVar2";
            txtVar2.Size = new Size(57, 23);
            txtVar2.TabIndex = 61;
            txtVar2.TextChanged += txtVar2_TextChanged;
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
            panel2.Controls.Add(labelcons54);
            panel2.Controls.Add(cons54);
            panel2.Controls.Add(cons52);
            panel2.Controls.Add(labelcons53);
            panel2.Controls.Add(labelcons51);
            panel2.Controls.Add(cons53);
            panel2.Controls.Add(cons51);
            panel2.Controls.Add(labelcons52);
            panel2.Controls.Add(txtrhs4);
            panel2.Controls.Add(cbtypofcons4);
            panel2.Controls.Add(labelcons44);
            panel2.Controls.Add(cons44);
            panel2.Controls.Add(cons42);
            panel2.Controls.Add(labelcons43);
            panel2.Controls.Add(labelcons41);
            panel2.Controls.Add(cons43);
            panel2.Controls.Add(cons41);
            panel2.Controls.Add(labelcons42);
            panel2.Controls.Add(txtrhs3);
            panel2.Controls.Add(cbtypofcons3);
            panel2.Controls.Add(labelcons34);
            panel2.Controls.Add(cons34);
            panel2.Controls.Add(cons32);
            panel2.Controls.Add(labelcons33);
            panel2.Controls.Add(labelcons31);
            panel2.Controls.Add(cons33);
            panel2.Controls.Add(cons31);
            panel2.Controls.Add(labelcons32);
            panel2.Controls.Add(txtrhs2);
            panel2.Controls.Add(cbtypofcons2);
            panel2.Controls.Add(labelcons24);
            panel2.Controls.Add(cons24);
            panel2.Controls.Add(cons22);
            panel2.Controls.Add(labelcons23);
            panel2.Controls.Add(labelcons21);
            panel2.Controls.Add(cons23);
            panel2.Controls.Add(cons21);
            panel2.Controls.Add(labelcons22);
            panel2.Controls.Add(txtrhs1);
            panel2.Controls.Add(cbtypofcons1);
            panel2.Controls.Add(labelcons4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cons4);
            panel2.Controls.Add(cons2);
            panel2.Controls.Add(labelcons3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cons3);
            panel2.Controls.Add(cons1);
            panel2.Controls.Add(labelcons2);
            panel2.Location = new Point(-2, 206);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 476);
            panel2.TabIndex = 59;
            panel2.Paint += panel2_Paint;
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
            cbtypofcons5.SelectedIndexChanged += cbtypofcons5_SelectedIndexChanged;
            // 
            // labelcons54
            // 
            labelcons54.Font = new Font("Tahoma", 10F);
            labelcons54.Location = new Point(622, 282);
            labelcons54.Name = "labelcons54";
            labelcons54.Size = new Size(49, 23);
            labelcons54.TabIndex = 114;
            labelcons54.Text = "x4 ";
            labelcons54.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons53
            // 
            labelcons53.Font = new Font("Tahoma", 10F);
            labelcons53.Location = new Point(504, 282);
            labelcons53.Name = "labelcons53";
            labelcons53.Size = new Size(49, 23);
            labelcons53.TabIndex = 112;
            labelcons53.Text = "x3 + ";
            labelcons53.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcons51
            // 
            labelcons51.Font = new Font("Tahoma", 10F);
            labelcons51.Location = new Point(271, 282);
            labelcons51.Name = "labelcons51";
            labelcons51.Size = new Size(49, 23);
            labelcons51.TabIndex = 108;
            labelcons51.Text = "x1 + ";
            labelcons51.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons52
            // 
            labelcons52.Font = new Font("Tahoma", 10F);
            labelcons52.Location = new Point(386, 282);
            labelcons52.Name = "labelcons52";
            labelcons52.Size = new Size(49, 23);
            labelcons52.TabIndex = 110;
            labelcons52.Text = "x2 + ";
            labelcons52.TextAlign = ContentAlignment.MiddleCenter;
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
            cbtypofcons4.SelectedIndexChanged += cbtypofcons4_SelectedIndexChanged;
            // 
            // labelcons44
            // 
            labelcons44.Font = new Font("Tahoma", 10F);
            labelcons44.Location = new Point(622, 235);
            labelcons44.Name = "labelcons44";
            labelcons44.Size = new Size(49, 23);
            labelcons44.TabIndex = 104;
            labelcons44.Text = "x4 ";
            labelcons44.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons43
            // 
            labelcons43.Font = new Font("Tahoma", 10F);
            labelcons43.Location = new Point(504, 235);
            labelcons43.Name = "labelcons43";
            labelcons43.Size = new Size(49, 23);
            labelcons43.TabIndex = 102;
            labelcons43.Text = "x3 + ";
            labelcons43.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcons41
            // 
            labelcons41.Font = new Font("Tahoma", 10F);
            labelcons41.Location = new Point(271, 235);
            labelcons41.Name = "labelcons41";
            labelcons41.Size = new Size(49, 23);
            labelcons41.TabIndex = 98;
            labelcons41.Text = "x1 + ";
            labelcons41.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons42
            // 
            labelcons42.Font = new Font("Tahoma", 10F);
            labelcons42.Location = new Point(386, 235);
            labelcons42.Name = "labelcons42";
            labelcons42.Size = new Size(49, 23);
            labelcons42.TabIndex = 100;
            labelcons42.Text = "x2 + ";
            labelcons42.TextAlign = ContentAlignment.MiddleCenter;
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
            cbtypofcons3.SelectedIndexChanged += cbtypofcons3_SelectedIndexChanged;
            // 
            // labelcons34
            // 
            labelcons34.Font = new Font("Tahoma", 10F);
            labelcons34.Location = new Point(622, 189);
            labelcons34.Name = "labelcons34";
            labelcons34.Size = new Size(49, 23);
            labelcons34.TabIndex = 94;
            labelcons34.Text = "x4 ";
            labelcons34.TextAlign = ContentAlignment.MiddleCenter;
            labelcons34.Click += labelcons34_Click;
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
            // labelcons33
            // 
            labelcons33.Font = new Font("Tahoma", 10F);
            labelcons33.Location = new Point(504, 189);
            labelcons33.Name = "labelcons33";
            labelcons33.Size = new Size(49, 23);
            labelcons33.TabIndex = 92;
            labelcons33.Text = "x3 + ";
            labelcons33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcons31
            // 
            labelcons31.Font = new Font("Tahoma", 10F);
            labelcons31.Location = new Point(271, 189);
            labelcons31.Name = "labelcons31";
            labelcons31.Size = new Size(49, 23);
            labelcons31.TabIndex = 88;
            labelcons31.Text = "x1 + ";
            labelcons31.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons32
            // 
            labelcons32.Font = new Font("Tahoma", 10F);
            labelcons32.Location = new Point(386, 189);
            labelcons32.Name = "labelcons32";
            labelcons32.Size = new Size(49, 23);
            labelcons32.TabIndex = 90;
            labelcons32.Text = "x2 + ";
            labelcons32.TextAlign = ContentAlignment.MiddleCenter;
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
            cbtypofcons2.SelectedIndexChanged += cbtypofcons2_SelectedIndexChanged;
            // 
            // labelcons24
            // 
            labelcons24.Font = new Font("Tahoma", 10F);
            labelcons24.Location = new Point(622, 144);
            labelcons24.Name = "labelcons24";
            labelcons24.Size = new Size(49, 23);
            labelcons24.TabIndex = 84;
            labelcons24.Text = "x4 ";
            labelcons24.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons23
            // 
            labelcons23.Font = new Font("Tahoma", 10F);
            labelcons23.Location = new Point(504, 144);
            labelcons23.Name = "labelcons23";
            labelcons23.Size = new Size(49, 23);
            labelcons23.TabIndex = 82;
            labelcons23.Text = "x3 + ";
            labelcons23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelcons21
            // 
            labelcons21.Font = new Font("Tahoma", 10F);
            labelcons21.Location = new Point(271, 144);
            labelcons21.Name = "labelcons21";
            labelcons21.Size = new Size(49, 23);
            labelcons21.TabIndex = 78;
            labelcons21.Text = "x1 + ";
            labelcons21.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons22
            // 
            labelcons22.Font = new Font("Tahoma", 10F);
            labelcons22.Location = new Point(386, 144);
            labelcons22.Name = "labelcons22";
            labelcons22.Size = new Size(49, 23);
            labelcons22.TabIndex = 80;
            labelcons22.Text = "x2 + ";
            labelcons22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtrhs1
            // 
            txtrhs1.Location = new Point(746, 101);
            txtrhs1.Name = "txtrhs1";
            txtrhs1.Size = new Size(57, 23);
            txtrhs1.TabIndex = 75;
            // 
            // labelcons4
            // 
            labelcons4.Font = new Font("Tahoma", 10F);
            labelcons4.Location = new Point(622, 100);
            labelcons4.Name = "labelcons4";
            labelcons4.Size = new Size(49, 23);
            labelcons4.TabIndex = 74;
            labelcons4.Text = "x4 ";
            labelcons4.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons3
            // 
            labelcons3.Font = new Font("Tahoma", 10F);
            labelcons3.Location = new Point(504, 100);
            labelcons3.Name = "labelcons3";
            labelcons3.Size = new Size(49, 23);
            labelcons3.TabIndex = 72;
            labelcons3.Text = "x3 + ";
            labelcons3.TextAlign = ContentAlignment.MiddleCenter;
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
            // labelcons2
            // 
            labelcons2.Font = new Font("Tahoma", 10F);
            labelcons2.Location = new Point(386, 100);
            labelcons2.Name = "labelcons2";
            labelcons2.Size = new Size(49, 23);
            labelcons2.TabIndex = 70;
            labelcons2.Text = "x2 + ";
            labelcons2.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label labelx4;
        private TextBox txtVar4;
        private Label labelx3;
        private TextBox txtVar3;
        private Label labelx2;
        private TextBox txtVar2;
        private Panel panel2;
        private Label label8;
        private TextBox txtrhs1;
        private Label labelcons4;
        private TextBox cons4;
        private TextBox cons2;
        private Label labelcons3;
        private Label label12;
        private TextBox cons3;
        private TextBox cons1;
        private Label labelcons2;
        private TextBox txtrhs5;
        private ComboBox cbtypofcons5;
        private Label labelcons54;
        private TextBox cons54;
        private TextBox cons52;
        private Label labelcons53;
        private Label labelcons51;
        private TextBox cons53;
        private TextBox cons51;
        private Label labelcons52;
        private TextBox txtrhs4;
        private ComboBox cbtypofcons4;
        private Label labelcons44;
        private TextBox cons44;
        private TextBox cons42;
        private Label labelcons43;
        private Label labelcons41;
        private TextBox cons43;
        private TextBox cons41;
        private Label labelcons42;
        private TextBox txtrhs3;
        private ComboBox cbtypofcons3;
        private Label labelcons34;
        private TextBox cons34;
        private TextBox cons32;
        private Label labelcons33;
        private Label labelcons31;
        private TextBox cons33;
        private TextBox cons31;
        private Label labelcons32;
        private TextBox txtrhs2;
        private ComboBox cbtypofcons2;
        private Label labelcons24;
        private TextBox cons24;
        private TextBox cons22;
        private Label labelcons23;
        private Label labelcons21;
        private TextBox cons23;
        private TextBox cons21;
        private Label labelcons22;
    }
}
