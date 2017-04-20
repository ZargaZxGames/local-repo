namespace Автосалон
{
    partial class AdminPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPass));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btn_ext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввведите пароль от учётной записи \"Администратор\"";
            this.label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 90);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Вход";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.UseWaitCursor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_ext
            // 
            this.btn_ext.Location = new System.Drawing.Point(215, 90);
            this.btn_ext.Name = "btn_ext";
            this.btn_ext.Size = new System.Drawing.Size(75, 23);
            this.btn_ext.TabIndex = 3;
            this.btn_ext.Text = "Выход";
            this.btn_ext.UseVisualStyleBackColor = true;
            this.btn_ext.UseWaitCursor = true;
            this.btn_ext.Click += new System.EventHandler(this.btn_ext_Click);
            // 
            // AdminPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 124);
            this.Controls.Add(this.btn_ext);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AdminPass";
            this.ShowIcon = false;
            this.Text = "Пароль от Администратора";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn_ext;
    }
}