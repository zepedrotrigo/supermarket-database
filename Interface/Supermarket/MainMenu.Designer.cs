
namespace Supermarket
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_sales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sales
            // 
            this.btn_sales.Image = ((System.Drawing.Image)(resources.GetObject("btn_sales.Image")));
            this.btn_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales.Location = new System.Drawing.Point(12, 12);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(131, 68);
            this.btn_sales.TabIndex = 4;
            this.btn_sales.Text = "Sales";
            this.btn_sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(286, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Products";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(149, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Invoices";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(149, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 68);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clients";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Image = ((System.Drawing.Image)(resources.GetObject("btn_employees.Image")));
            this.btn_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employees.Location = new System.Drawing.Point(286, 86);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(131, 68);
            this.btn_employees.TabIndex = 8;
            this.btn_employees.Text = "Employees";
            this.btn_employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click_1);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(12, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 68);
            this.button5.TabIndex = 9;
            this.button5.Text = "Suppliers";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 160);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 68);
            this.button6.TabIndex = 10;
            this.button6.Text = "Warehouse";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_employees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sales);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}