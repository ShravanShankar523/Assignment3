﻿namespace Assignment3
{
    partial class StudentAddorEdit
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
            btn_AddorEdit = new Button();
            txtfname = new TextBox();
            txtstdid = new TextBox();
            lblPass = new Label();
            lblstdid = new Label();
            lbltitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtgender = new TextBox();
            txtlname = new TextBox();
            txtage = new TextBox();
            txtclassname = new TextBox();
            txtgrade = new TextBox();
            SuspendLayout();
            // 
            // btn_AddorEdit
            // 
            btn_AddorEdit.Location = new Point(1130, 711);
            btn_AddorEdit.Margin = new Padding(4);
            btn_AddorEdit.Name = "btn_AddorEdit";
            btn_AddorEdit.Size = new Size(197, 67);
            btn_AddorEdit.TabIndex = 12;
            btn_AddorEdit.Text = "Add";
            btn_AddorEdit.UseVisualStyleBackColor = true;
            btn_AddorEdit.Click += btn_AddorEdit_Click;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(441, 333);
            txtfname.Margin = new Padding(4);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(208, 42);
            txtfname.TabIndex = 11;
            // 
            // txtstdid
            // 
            txtstdid.Location = new Point(441, 235);
            txtstdid.Margin = new Padding(4);
            txtstdid.Name = "txtstdid";
            txtstdid.Size = new Size(208, 42);
            txtstdid.TabIndex = 10;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(185, 333);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(144, 36);
            lblPass.TabIndex = 9;
            lblPass.Text = "First Name:";
            // 
            // lblstdid
            // 
            lblstdid.AutoSize = true;
            lblstdid.Location = new Point(185, 235);
            lblstdid.Margin = new Padding(4, 0, 4, 0);
            lblstdid.Name = "lblstdid";
            lblstdid.Size = new Size(140, 36);
            lblstdid.TabIndex = 8;
            lblstdid.Text = "Student Id:";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(127, 75);
            lbltitle.Margin = new Padding(4, 0, 4, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(291, 65);
            lbltitle.TabIndex = 7;
            lbltitle.Text = "Add Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 447);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 36);
            label1.TabIndex = 13;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 564);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 36);
            label2.TabIndex = 14;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(935, 241);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 36);
            label3.TabIndex = 15;
            label3.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(920, 345);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 36);
            label4.TabIndex = 16;
            label4.Text = "Class Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(935, 453);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 36);
            label5.TabIndex = 17;
            label5.Text = "Grade:";
            // 
            // txtgender
            // 
            txtgender.Location = new Point(1140, 241);
            txtgender.Margin = new Padding(4);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(208, 42);
            txtgender.TabIndex = 18;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(441, 447);
            txtlname.Margin = new Padding(4);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(208, 42);
            txtlname.TabIndex = 19;
            // 
            // txtage
            // 
            txtage.Location = new Point(441, 564);
            txtage.Margin = new Padding(4);
            txtage.Name = "txtage";
            txtage.Size = new Size(208, 42);
            txtage.TabIndex = 20;
            // 
            // txtclassname
            // 
            txtclassname.Location = new Point(1140, 339);
            txtclassname.Margin = new Padding(4);
            txtclassname.Name = "txtclassname";
            txtclassname.Size = new Size(208, 42);
            txtclassname.TabIndex = 21;
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(1140, 447);
            txtgrade.Margin = new Padding(4);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(208, 42);
            txtgrade.TabIndex = 22;
            // 
            // StudentAddorEdit
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 1385);
            Controls.Add(txtgrade);
            Controls.Add(txtclassname);
            Controls.Add(txtage);
            Controls.Add(txtlname);
            Controls.Add(txtgender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AddorEdit);
            Controls.Add(txtfname);
            Controls.Add(txtstdid);
            Controls.Add(lblPass);
            Controls.Add(lblstdid);
            Controls.Add(lbltitle);
            Margin = new Padding(4);
            Name = "StudentAddorEdit";
            Text = "StudentAddEdit";
            Load += StudentAddorEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddorEdit;
        private TextBox txtfname;
        private TextBox txtstdid;
        private Label lblPass;
        private Label lblstdid;
        private Label lbltitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtgender;
        private TextBox txtlname;
        private TextBox txtage;
        private TextBox txtclassname;
        private TextBox txtgrade;
    }
}