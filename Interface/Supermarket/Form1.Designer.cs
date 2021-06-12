
namespace Supermarket
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
            this.label1 = new System.Windows.Forms.Label();
            this.form_user = new System.Windows.Forms.TextBox();
            this.form_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.form_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // form_user
            // 
            this.form_user.Location = new System.Drawing.Point(188, 55);
            this.form_user.Name = "form_user";
            this.form_user.Size = new System.Drawing.Size(125, 27);
            this.form_user.TabIndex = 1;
            // 
            // form_password
            // 
            this.form_password.Location = new System.Drawing.Point(188, 105);
            this.form_password.Name = "form_password";
            this.form_password.Size = new System.Drawing.Size(125, 27);
            this.form_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // form_login
            // 
            this.form_login.Location = new System.Drawing.Point(188, 169);
            this.form_login.Name = "form_login";
            this.form_login.Size = new System.Drawing.Size(94, 29);
            this.form_login.TabIndex = 4;
            this.form_login.Text = "Login";
            this.form_login.UseVisualStyleBackColor = true;
            this.form_login.Click += new System.EventHandler(this.form_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 238);
            this.Controls.Add(this.form_login);
            this.Controls.Add(this.form_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.form_user);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Supermarket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox form_user;
        private System.Windows.Forms.TextBox form_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button form_login;
    }
}

