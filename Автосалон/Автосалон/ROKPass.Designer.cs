namespace Автосалон
{
    partial class ROKPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROKPass));
            this.btn_ROK_go = new System.Windows.Forms.Button();
            this.btn_ext_ROK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ROK_go
            // 
            this.btn_ROK_go.Location = new System.Drawing.Point(24, 84);
            this.btn_ROK_go.Name = "btn_ROK_go";
            this.btn_ROK_go.Size = new System.Drawing.Size(75, 23);
            this.btn_ROK_go.TabIndex = 0;
            this.btn_ROK_go.Text = "Вход";
            this.btn_ROK_go.UseVisualStyleBackColor = true;
            this.btn_ROK_go.Click += new System.EventHandler(this.btn_ROK_go_Click);
            // 
            // btn_ext_ROK
            // 
            this.btn_ext_ROK.Location = new System.Drawing.Point(218, 84);
            this.btn_ext_ROK.Name = "btn_ext_ROK";
            this.btn_ext_ROK.Size = new System.Drawing.Size(75, 23);
            this.btn_ext_ROK.TabIndex = 1;
            this.btn_ext_ROK.Text = "Выход";
            this.btn_ext_ROK.UseVisualStyleBackColor = true;
            this.btn_ext_ROK.Click += new System.EventHandler(this.btn_ext_ROK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввведите пароль от учётной записи \"Отдел кадров\"";
            // 
            // ROKPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ext_ROK);
            this.Controls.Add(this.btn_ROK_go);
            this.Name = "ROKPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль от Отдела кадров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ROK_go;
        private System.Windows.Forms.Button btn_ext_ROK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}