﻿namespace Автосалон
{
    partial class ProdavecPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdavecPass));
            this.btn_go_Prodav = new System.Windows.Forms.Button();
            this.btn_ext_Prodav = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_go_Prodav
            // 
            this.btn_go_Prodav.Location = new System.Drawing.Point(23, 108);
            this.btn_go_Prodav.Name = "btn_go_Prodav";
            this.btn_go_Prodav.Size = new System.Drawing.Size(75, 23);
            this.btn_go_Prodav.TabIndex = 0;
            this.btn_go_Prodav.Text = "Вход";
            this.btn_go_Prodav.UseVisualStyleBackColor = true;
            this.btn_go_Prodav.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ext_Prodav
            // 
            this.btn_ext_Prodav.Location = new System.Drawing.Point(197, 108);
            this.btn_ext_Prodav.Name = "btn_ext_Prodav";
            this.btn_ext_Prodav.Size = new System.Drawing.Size(75, 23);
            this.btn_ext_Prodav.TabIndex = 1;
            this.btn_ext_Prodav.Text = "Выход";
            this.btn_ext_Prodav.UseVisualStyleBackColor = true;
            this.btn_ext_Prodav.Click += new System.EventHandler(this.btn_ext_Prodav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввведите пароль от учётной записи \"Продавец\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 3;
            // 
            // ProdavecPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ext_Prodav);
            this.Controls.Add(this.btn_go_Prodav);
            this.Name = "ProdavecPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль от Продавца-Консультанта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go_Prodav;
        private System.Windows.Forms.Button btn_ext_Prodav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}