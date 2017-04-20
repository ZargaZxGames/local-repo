namespace Автосалон
{
    partial class BuhgPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuhgPass));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Admn = new System.Windows.Forms.Button();
            this.btn_extAdmn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввведите пароль от учётной записи \"Бухгалтер\"";
            // 
            // btn_Admn
            // 
            this.btn_Admn.Location = new System.Drawing.Point(12, 80);
            this.btn_Admn.Name = "btn_Admn";
            this.btn_Admn.Size = new System.Drawing.Size(75, 23);
            this.btn_Admn.TabIndex = 1;
            this.btn_Admn.Text = "Вход";
            this.btn_Admn.UseVisualStyleBackColor = true;
            this.btn_Admn.Click += new System.EventHandler(this.btn_Admn_Click);
            // 
            // btn_extAdmn
            // 
            this.btn_extAdmn.Location = new System.Drawing.Point(187, 80);
            this.btn_extAdmn.Name = "btn_extAdmn";
            this.btn_extAdmn.Size = new System.Drawing.Size(75, 23);
            this.btn_extAdmn.TabIndex = 2;
            this.btn_extAdmn.Text = "Выход";
            this.btn_extAdmn.UseVisualStyleBackColor = true;
            this.btn_extAdmn.Click += new System.EventHandler(this.btn_extAdmn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 3;
            // 
            // BuhgPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(273, 116);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_extAdmn);
            this.Controls.Add(this.btn_Admn);
            this.Controls.Add(this.label1);
            this.Name = "BuhgPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль от Бухгалтера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Admn;
        private System.Windows.Forms.Button btn_extAdmn;
        private System.Windows.Forms.TextBox textBox1;
    }
}