﻿
namespace Supermarket
{
    partial class EmployeesForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_sort_by = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_employee_since = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 123);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(1238, 488);
            this.checkedListBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1156, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(1056, 29);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(94, 29);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1056, 78);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(70, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(125, 27);
            this.txt_name.TabIndex = 7;
            // 
            // txt_nif
            // 
            this.txt_nif.Location = new System.Drawing.Point(70, 65);
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(125, 27);
            this.txt_nif.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "NIF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(268, 68);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(125, 27);
            this.txt_phone.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(268, 15);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(125, 27);
            this.txt_id.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(482, 15);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(125, 27);
            this.txt_email.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sort by:";
            // 
            // combo_sort_by
            // 
            this.combo_sort_by.FormattingEnabled = true;
            this.combo_sort_by.Location = new System.Drawing.Point(907, 70);
            this.combo_sort_by.Name = "combo_sort_by";
            this.combo_sort_by.Size = new System.Drawing.Size(125, 28);
            this.combo_sort_by.TabIndex = 17;
            this.combo_sort_by.Text = "Select Type";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(1156, 29);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Salary:";
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(679, 18);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(125, 27);
            this.txt_job.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(621, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Job:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(679, 67);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(125, 27);
            this.txt_salary.TabIndex = 22;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(482, 70);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(125, 27);
            this.txt_address.TabIndex = 24;
            this.txt_address.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Address:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_employee_since
            // 
            this.txt_employee_since.Location = new System.Drawing.Point(907, 19);
            this.txt_employee_since.Name = "txt_employee_since";
            this.txt_employee_since.Size = new System.Drawing.Size(125, 27);
            this.txt_employee_since.TabIndex = 26;
            this.txt_employee_since.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(817, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Emp. Since:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.txt_employee_since);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_job);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.combo_sort_by);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_sort_by;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_employee_since;
        private System.Windows.Forms.Label label10;
    }
}