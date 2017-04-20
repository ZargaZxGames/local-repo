namespace Автосалон
{
    partial class MarketPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketPass));
            this.btn_go_market = new System.Windows.Forms.Button();
            this.btn_ext_Market = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_go_market
            // 
            this.btn_go_market.Location = new System.Drawing.Point(12, 72);
            this.btn_go_market.Name = "btn_go_market";
            this.btn_go_market.Size = new System.Drawing.Size(75, 23);
            this.btn_go_market.TabIndex = 0;
            this.btn_go_market.Text = "Вход";
            this.btn_go_market.UseVisualStyleBackColor = true;
            this.btn_go_market.Click += new System.EventHandler(this.btn_go_market_Click);
            // 
            // btn_ext_Market
            // 
            this.btn_ext_Market.Location = new System.Drawing.Point(197, 72);
            this.btn_ext_Market.Name = "btn_ext_Market";
            this.btn_ext_Market.Size = new System.Drawing.Size(75, 23);
            this.btn_ext_Market.TabIndex = 1;
            this.btn_ext_Market.Text = "Выход";
            this.btn_ext_Market.UseVisualStyleBackColor = true;
            this.btn_ext_Market.Click += new System.EventHandler(this.btn_ext_Market_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввведите пароль от учётной записи \"Маркетинга\"";
            // 
            // MarketPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ext_Market);
            this.Controls.Add(this.btn_go_market);
            this.Name = "MarketPass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пароль от Отдела маркетанга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go_market;
        private System.Windows.Forms.Button btn_ext_Market;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}