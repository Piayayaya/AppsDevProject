﻿namespace WindowsFormsApplication2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(125, 124);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(194, 20);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "Enter First Name";
            this.FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(125, 185);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(194, 20);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Enter Last Name";
            this.LastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(165, 249);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(122, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(165, 296);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Greetings Generator";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
    }
}

