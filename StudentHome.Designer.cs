﻿namespace Assignment3
{
    partial class StudentHome
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
            dgv_student = new DataGridView();
            button1 = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            txtsearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.BackgroundColor = SystemColors.ActiveCaption;
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(62, 122);
            dgv_student.Margin = new Padding(4, 4, 4, 4);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 62;
            dgv_student.Size = new Size(1595, 787);
            dgv_student.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(281, 1047);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 89);
            button1.TabIndex = 1;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(717, 1047);
            btn_edit.Margin = new Padding(4, 4, 4, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(214, 89);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Update Student";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(1141, 1047);
            btn_delete.Margin = new Padding(4, 4, 4, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(214, 89);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete Student";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(308, 69);
            txtsearch.Margin = new Padding(4, 4, 4, 4);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(737, 42);
            txtsearch.TabIndex = 4;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(197, 69);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(105, 36);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search: ";
            // 
            // StudenttHome
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1777, 1244);
            Controls.Add(lblSearch);
            Controls.Add(txtsearch);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(button1);
            Controls.Add(dgv_student);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudenttHome";
            Text = "StudenttHome";
            Load += StudenttHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private Button button1;
        private Button btn_edit;
        private Button btn_delete;
        private TextBox txtsearch;
        private Label lblSearch;
    }
}