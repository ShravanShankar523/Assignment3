namespace Assignment3
{
    partial class Register
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
            lbltitle = new Label();
            lblusername = new Label();
            lblPass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btn_register = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(114, 138);
            lbltitle.Margin = new Padding(4, 0, 4, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(373, 65);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "User Registraion";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(489, 265);
            lblusername.Margin = new Padding(4, 0, 4, 0);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(148, 36);
            lblusername.TabIndex = 1;
            lblusername.Text = "User Name:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(505, 387);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(128, 36);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(697, 271);
            txtuser.Margin = new Padding(4, 4, 4, 4);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(208, 42);
            txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(697, 379);
            txtpass.Margin = new Padding(4, 4, 4, 4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(208, 42);
            txtpass.TabIndex = 4;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(697, 485);
            btn_register.Margin = new Padding(4, 4, 4, 4);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(161, 49);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(532, 491);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 36);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 1164);
            Controls.Add(linkLabel1);
            Controls.Add(btn_register);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblPass);
            Controls.Add(lblusername);
            Controls.Add(lbltitle);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label lblusername;
        private Label lblPass;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btn_register;
        private LinkLabel linkLabel1;
    }
}
