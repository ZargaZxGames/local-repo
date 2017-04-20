namespace Автосалон
{
    partial class KladPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KladPass));
            this.btn_kladGo = new System.Windows.Forms.Button();
            this.btn_ext_Klad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kladGo
            // 
            this.btn_kladGo.Location = new System.Drawing.Point(12, 88);
            this.btn_kladGo.Name = "btn_kladGo";
            this.btn_kladGo.Size = new System.Drawing.Size(75, 23);
            this.btn_kladGo.TabIndex = 0;
            this.btn_kladGo.Text = "Вход";
            this.btn_kladGo.UseVisualStyleBackColor = true;
            this.btn_kladGo.Click += new System.EventHandler(this.btn_kladGo_Click);
            // 
            // btn_ext_Klad
            // 
            this.btn_ext_Klad.Location = new System.Drawing.Point(197, 88);
            this.btn_ext_Klad.Name = "btn_ext_Klad";
            this.btn_ext_Klad.Size = new System.Drawing.Size(75, 23);
            this.btn_ext_Klad.TabIndex = 1;
            this.btn_ext_Klad.Text = "Выход";
            this.btn_ext_Klad.UseVisualStyleBackColor = true;
            this.btn_ext_Klad.Click += new System.EventHandler(this.btn_ext_Klad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввведите пароль от учётной записи \"Кладовщик\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 3;
            // 
            // KladPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ext_Klad);
            this.Controls.Add(this.btn_kladGo);
            this.Name = "KladPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль от Кладовщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kladGo;
        private System.Windows.Forms.Button btn_ext_Klad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}