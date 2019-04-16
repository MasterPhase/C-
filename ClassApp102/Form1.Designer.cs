namespace ClassApp102
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnHover = new System.Windows.Forms.Button();
            this.btnVariables = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtBoxAuth = new System.Windows.Forms.TextBox();
            this.txtBoxPsw = new System.Windows.Forms.TextBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.chkBoxSub = new System.Windows.Forms.Button();
            this.txtBoxOkay = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.txtBoxSwitch = new System.Windows.Forms.TextBox();
            this.mathInputOne = new System.Windows.Forms.TextBox();
            this.mathInputTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.array = new System.Windows.Forms.Button();
            this.btnLists = new System.Windows.Forms.Button();
            this.forEach = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.txtDoWhile = new System.Windows.Forms.TextBox();
            this.btnTry = new System.Windows.Forms.Button();
            this.btnMethods = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(145, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Message Box";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHover
            // 
            this.btnHover.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHover.Location = new System.Drawing.Point(19, 176);
            this.btnHover.Name = "btnHover";
            this.btnHover.Size = new System.Drawing.Size(230, 45);
            this.btnHover.TabIndex = 0;
            this.btnHover.Text = "Button Hover";
            this.btnHover.UseVisualStyleBackColor = false;
            this.btnHover.Click += new System.EventHandler(this.btnHover_MouseHover);
            this.btnHover.MouseHover += new System.EventHandler(this.btnHover_MouseHover);
            // 
            // btnVariables
            // 
            this.btnVariables.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVariables.Location = new System.Drawing.Point(131, 146);
            this.btnVariables.Name = "btnVariables";
            this.btnVariables.Size = new System.Drawing.Size(118, 24);
            this.btnVariables.TabIndex = 0;
            this.btnVariables.Text = "Variables";
            this.btnVariables.UseVisualStyleBackColor = false;
            this.btnVariables.Click += new System.EventHandler(this.btnVariables_Click);
            this.btnVariables.MouseHover += new System.EventHandler(this.btnHover_MouseHover);
            // 
            // btnProp
            // 
            this.btnProp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProp.Location = new System.Drawing.Point(100, 65);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(63, 23);
            this.btnProp.TabIndex = 1;
            this.btnProp.Text = "Properties";
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Location = new System.Drawing.Point(131, 120);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox.Location = new System.Drawing.Point(135, 94);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(111, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.Text = "TextBox";
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMember.Location = new System.Drawing.Point(169, 65);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(77, 23);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Member?";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTest.Location = new System.Drawing.Point(174, 308);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Authenticate";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtBoxAuth
            // 
            this.txtBoxAuth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxAuth.Location = new System.Drawing.Point(149, 256);
            this.txtBoxAuth.Name = "txtBoxAuth";
            this.txtBoxAuth.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAuth.TabIndex = 5;
            this.txtBoxAuth.Text = "Name";
            // 
            // txtBoxPsw
            // 
            this.txtBoxPsw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxPsw.Location = new System.Drawing.Point(149, 282);
            this.txtBoxPsw.Name = "txtBoxPsw";
            this.txtBoxPsw.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPsw.TabIndex = 6;
            this.txtBoxPsw.Text = "Password";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkBox.Location = new System.Drawing.Point(18, 272);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(93, 17);
            this.chkBox.TabIndex = 7;
            this.chkBox.Text = "I\'m not a robot";
            this.chkBox.UseVisualStyleBackColor = false;
            // 
            // chkBoxSub
            // 
            this.chkBoxSub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkBoxSub.Location = new System.Drawing.Point(19, 308);
            this.chkBoxSub.Name = "chkBoxSub";
            this.chkBoxSub.Size = new System.Drawing.Size(75, 23);
            this.chkBoxSub.TabIndex = 8;
            this.chkBoxSub.Text = "Submit";
            this.chkBoxSub.UseVisualStyleBackColor = false;
            this.chkBoxSub.Click += new System.EventHandler(this.chkBoxSub_Click);
            // 
            // txtBoxOkay
            // 
            this.txtBoxOkay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBoxOkay.Location = new System.Drawing.Point(19, 227);
            this.txtBoxOkay.Name = "txtBoxOkay";
            this.txtBoxOkay.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOkay.TabIndex = 9;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(19, 120);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 10;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // txtBoxSwitch
            // 
            this.txtBoxSwitch.Location = new System.Drawing.Point(19, 149);
            this.txtBoxSwitch.Name = "txtBoxSwitch";
            this.txtBoxSwitch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSwitch.TabIndex = 11;
            // 
            // mathInputOne
            // 
            this.mathInputOne.Location = new System.Drawing.Point(19, 13);
            this.mathInputOne.Name = "mathInputOne";
            this.mathInputOne.Size = new System.Drawing.Size(43, 20);
            this.mathInputOne.TabIndex = 12;
            // 
            // mathInputTwo
            // 
            this.mathInputTwo.Location = new System.Drawing.Point(19, 39);
            this.mathInputTwo.Name = "mathInputTwo";
            this.mathInputTwo.Size = new System.Drawing.Size(43, 20);
            this.mathInputTwo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Value 2";
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(19, 65);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(75, 23);
            this.math.TabIndex = 16;
            this.math.Text = "Math";
            this.math.UseVisualStyleBackColor = true;
            this.math.Click += new System.EventHandler(this.math_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(19, 94);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(100, 20);
            this.rez.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mathInputOne);
            this.panel1.Controls.Add(this.chkBoxSub);
            this.panel1.Controls.Add(this.txtBoxOkay);
            this.panel1.Controls.Add(this.chkBox);
            this.panel1.Controls.Add(this.txtBoxSwitch);
            this.panel1.Controls.Add(this.txtBoxPsw);
            this.panel1.Controls.Add(this.rez);
            this.panel1.Controls.Add(this.txtBoxAuth);
            this.panel1.Controls.Add(this.btnSwitch);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.mathInputTwo);
            this.panel1.Controls.Add(this.math);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHover);
            this.panel1.Controls.Add(this.btnVariables);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtBox);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Location = new System.Drawing.Point(246, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 334);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(13, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 335);
            this.panel2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(0, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 42);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(13, -94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 119);
            this.panel3.TabIndex = 20;
            // 
            // array
            // 
            this.array.Location = new System.Drawing.Point(552, 40);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(75, 23);
            this.array.TabIndex = 21;
            this.array.Text = "Array";
            this.array.UseVisualStyleBackColor = true;
            this.array.Click += new System.EventHandler(this.array_Click);
            // 
            // btnLists
            // 
            this.btnLists.Location = new System.Drawing.Point(551, 96);
            this.btnLists.Name = "btnLists";
            this.btnLists.Size = new System.Drawing.Size(75, 23);
            this.btnLists.TabIndex = 22;
            this.btnLists.Text = "List";
            this.btnLists.UseVisualStyleBackColor = true;
            this.btnLists.Click += new System.EventHandler(this.btnLists_Click);
            // 
            // forEach
            // 
            this.forEach.Location = new System.Drawing.Point(552, 151);
            this.forEach.Name = "forEach";
            this.forEach.Size = new System.Drawing.Size(75, 23);
            this.forEach.TabIndex = 23;
            this.forEach.Text = "For Each";
            this.forEach.UseVisualStyleBackColor = true;
            this.forEach.Click += new System.EventHandler(this.forEach_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(552, 207);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 24;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // txtDoWhile
            // 
            this.txtDoWhile.Location = new System.Drawing.Point(552, 237);
            this.txtDoWhile.Name = "txtDoWhile";
            this.txtDoWhile.Size = new System.Drawing.Size(100, 20);
            this.txtDoWhile.TabIndex = 25;
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(552, 287);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(75, 23);
            this.btnTry.TabIndex = 26;
            this.btnTry.Text = "Try Catch";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // btnMethods
            // 
            this.btnMethods.Location = new System.Drawing.Point(552, 317);
            this.btnMethods.Name = "btnMethods";
            this.btnMethods.Size = new System.Drawing.Size(75, 23);
            this.btnMethods.TabIndex = 27;
            this.btnMethods.Text = "Methods";
            this.btnMethods.UseVisualStyleBackColor = true;
            this.btnMethods.Click += new System.EventHandler(this.btnMethods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.btnMethods);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.txtDoWhile);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.forEach);
            this.Controls.Add(this.btnLists);
            this.Controls.Add(this.array);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class App - CDL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHover;
        private System.Windows.Forms.Button btnVariables;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtBoxAuth;
        private System.Windows.Forms.TextBox txtBoxPsw;
        private System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.Button chkBoxSub;
        private System.Windows.Forms.TextBox txtBoxOkay;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.TextBox txtBoxSwitch;
        private System.Windows.Forms.TextBox mathInputOne;
        private System.Windows.Forms.TextBox mathInputTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button array;
        private System.Windows.Forms.Button btnLists;
        private System.Windows.Forms.Button forEach;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.TextBox txtDoWhile;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Button btnMethods;
    }
}

