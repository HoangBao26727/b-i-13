namespace bài_13
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnguon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdich = new System.Windows.Forms.TextBox();
            this.btnVNDtoUSD = new System.Windows.Forms.Button();
            this.btnVNDtoEUR = new System.Windows.Forms.Button();
            this.btnUSDtoVND = new System.Windows.Forms.Button();
            this.btnEURtoVND = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền Quy Đổi";
            // 
            // txtnguon
            // 
            this.txtnguon.Location = new System.Drawing.Point(104, 97);
            this.txtnguon.Name = "txtnguon";
            this.txtnguon.Size = new System.Drawing.Size(223, 20);
            this.txtnguon.TabIndex = 1;
            this.txtnguon.TextChanged += new System.EventHandler(this.txtnguon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết Qủa";
            // 
            // txtdich
            // 
            this.txtdich.Location = new System.Drawing.Point(99, 328);
            this.txtdich.Name = "txtdich";
            this.txtdich.Size = new System.Drawing.Size(223, 20);
            this.txtdich.TabIndex = 3;
            // 
            // btnVNDtoUSD
            // 
            this.btnVNDtoUSD.Location = new System.Drawing.Point(22, 211);
            this.btnVNDtoUSD.Name = "btnVNDtoUSD";
            this.btnVNDtoUSD.Size = new System.Drawing.Size(90, 26);
            this.btnVNDtoUSD.TabIndex = 4;
            this.btnVNDtoUSD.Text = "VNDtoUSD";
            this.btnVNDtoUSD.UseVisualStyleBackColor = true;
            this.btnVNDtoUSD.Click += new System.EventHandler(this.btnVNDtoUSD_Click);
            // 
            // btnVNDtoEUR
            // 
            this.btnVNDtoEUR.Location = new System.Drawing.Point(144, 211);
            this.btnVNDtoEUR.Name = "btnVNDtoEUR";
            this.btnVNDtoEUR.Size = new System.Drawing.Size(90, 26);
            this.btnVNDtoEUR.TabIndex = 6;
            this.btnVNDtoEUR.Text = "VNDtoEUR";
            this.btnVNDtoEUR.UseVisualStyleBackColor = true;
            this.btnVNDtoEUR.Click += new System.EventHandler(this.btnVNDtoEUR_Click);
            // 
            // btnUSDtoVND
            // 
            this.btnUSDtoVND.Location = new System.Drawing.Point(282, 211);
            this.btnUSDtoVND.Name = "btnUSDtoVND";
            this.btnUSDtoVND.Size = new System.Drawing.Size(90, 26);
            this.btnUSDtoVND.TabIndex = 7;
            this.btnUSDtoVND.Text = "USDtoVND";
            this.btnUSDtoVND.UseVisualStyleBackColor = true;
            this.btnUSDtoVND.Click += new System.EventHandler(this.btnUSDtoVND_Click);
            // 
            // btnEURtoVND
            // 
            this.btnEURtoVND.Location = new System.Drawing.Point(438, 211);
            this.btnEURtoVND.Name = "btnEURtoVND";
            this.btnEURtoVND.Size = new System.Drawing.Size(90, 26);
            this.btnEURtoVND.TabIndex = 8;
            this.btnEURtoVND.Text = "EURtoVND";
            this.btnEURtoVND.UseVisualStyleBackColor = true;
            this.btnEURtoVND.Click += new System.EventHandler(this.btnEURtoVND_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(212, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đổi Tiền";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEURtoVND);
            this.Controls.Add(this.btnUSDtoVND);
            this.Controls.Add(this.btnVNDtoEUR);
            this.Controls.Add(this.btnVNDtoUSD);
            this.Controls.Add(this.txtdich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnguon);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnguon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdich;
        private System.Windows.Forms.Button btnVNDtoUSD;
        private System.Windows.Forms.Button btnVNDtoEUR;
        private System.Windows.Forms.Button btnUSDtoVND;
        private System.Windows.Forms.Button btnEURtoVND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

