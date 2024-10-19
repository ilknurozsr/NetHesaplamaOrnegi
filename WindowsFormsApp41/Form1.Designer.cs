namespace WindowsFormsApp41
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbld = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblnet = new System.Windows.Forms.Label();
            this.lbltr = new System.Windows.Forms.Label();
            this.lblmat = new System.Windows.Forms.Label();
            this.lblfizik = new System.Windows.Forms.Label();
            this.txttrdogru = new System.Windows.Forms.TextBox();
            this.txtfznet = new System.Windows.Forms.TextBox();
            this.txtfzyanlis = new System.Windows.Forms.TextBox();
            this.txtfzdgru = new System.Windows.Forms.TextBox();
            this.txtmatnet = new System.Windows.Forms.TextBox();
            this.txtmatyanlis = new System.Windows.Forms.TextBox();
            this.txtmatdogru = new System.Windows.Forms.TextBox();
            this.txttrnet = new System.Windows.Forms.TextBox();
            this.txttryanlis = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbld.Location = new System.Drawing.Point(179, 131);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(23, 20);
            this.lbld.TabIndex = 0;
            this.lbld.Text = "D";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbly.Location = new System.Drawing.Point(271, 131);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(20, 20);
            this.lbly.TabIndex = 1;
            this.lbly.Text = "Y";
            // 
            // lblnet
            // 
            this.lblnet.AutoSize = true;
            this.lblnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnet.Location = new System.Drawing.Point(342, 131);
            this.lblnet.Name = "lblnet";
            this.lblnet.Size = new System.Drawing.Size(45, 20);
            this.lblnet.TabIndex = 2;
            this.lblnet.Text = "NET";
            // 
            // lbltr
            // 
            this.lbltr.AutoSize = true;
            this.lbltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltr.Location = new System.Drawing.Point(84, 184);
            this.lbltr.Name = "lbltr";
            this.lbltr.Size = new System.Drawing.Size(66, 20);
            this.lbltr.TabIndex = 3;
            this.lbltr.Text = "Türkçe";
            // 
            // lblmat
            // 
            this.lblmat.AutoSize = true;
            this.lblmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmat.Location = new System.Drawing.Point(55, 223);
            this.lblmat.Name = "lblmat";
            this.lblmat.Size = new System.Drawing.Size(95, 20);
            this.lblmat.TabIndex = 4;
            this.lblmat.Text = "Matematik";
            // 
            // lblfizik
            // 
            this.lblfizik.AutoSize = true;
            this.lblfizik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfizik.Location = new System.Drawing.Point(101, 269);
            this.lblfizik.Name = "lblfizik";
            this.lblfizik.Size = new System.Drawing.Size(49, 20);
            this.lblfizik.TabIndex = 5;
            this.lblfizik.Text = "Fizik";
            // 
            // txttrdogru
            // 
            this.txttrdogru.Location = new System.Drawing.Point(167, 182);
            this.txttrdogru.Name = "txttrdogru";
            this.txttrdogru.Size = new System.Drawing.Size(51, 22);
            this.txttrdogru.TabIndex = 6;
            // 
            // txtfznet
            // 
            this.txtfznet.Location = new System.Drawing.Point(346, 267);
            this.txtfznet.Name = "txtfznet";
            this.txtfznet.Size = new System.Drawing.Size(51, 22);
            this.txtfznet.TabIndex = 7;
            // 
            // txtfzyanlis
            // 
            this.txtfzyanlis.Location = new System.Drawing.Point(259, 267);
            this.txtfzyanlis.Name = "txtfzyanlis";
            this.txtfzyanlis.Size = new System.Drawing.Size(51, 22);
            this.txtfzyanlis.TabIndex = 8;
            // 
            // txtfzdgru
            // 
            this.txtfzdgru.Location = new System.Drawing.Point(167, 269);
            this.txtfzdgru.Name = "txtfzdgru";
            this.txtfzdgru.Size = new System.Drawing.Size(51, 22);
            this.txtfzdgru.TabIndex = 9;
            // 
            // txtmatnet
            // 
            this.txtmatnet.Location = new System.Drawing.Point(346, 223);
            this.txtmatnet.Name = "txtmatnet";
            this.txtmatnet.Size = new System.Drawing.Size(51, 22);
            this.txtmatnet.TabIndex = 10;
            // 
            // txtmatyanlis
            // 
            this.txtmatyanlis.Location = new System.Drawing.Point(259, 223);
            this.txtmatyanlis.Name = "txtmatyanlis";
            this.txtmatyanlis.Size = new System.Drawing.Size(51, 22);
            this.txtmatyanlis.TabIndex = 11;
            // 
            // txtmatdogru
            // 
            this.txtmatdogru.Location = new System.Drawing.Point(167, 223);
            this.txtmatdogru.Name = "txtmatdogru";
            this.txtmatdogru.Size = new System.Drawing.Size(51, 22);
            this.txtmatdogru.TabIndex = 12;
            // 
            // txttrnet
            // 
            this.txttrnet.Location = new System.Drawing.Point(346, 184);
            this.txttrnet.Name = "txttrnet";
            this.txttrnet.Size = new System.Drawing.Size(51, 22);
            this.txttrnet.TabIndex = 13;
            // 
            // txttryanlis
            // 
            this.txttryanlis.Location = new System.Drawing.Point(259, 182);
            this.txttryanlis.Name = "txttryanlis";
            this.txttryanlis.Size = new System.Drawing.Size(51, 22);
            this.txttryanlis.TabIndex = 14;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(214, 320);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(150, 51);
            this.btnhesapla.TabIndex = 15;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "NET HESAPLAMA SİSTEMİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bütün değerleri eksiksiz bir şekilde girin ardından \'HESAPLA\' butonuna basın.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txttryanlis);
            this.Controls.Add(this.txttrnet);
            this.Controls.Add(this.txtmatdogru);
            this.Controls.Add(this.txtmatyanlis);
            this.Controls.Add(this.txtmatnet);
            this.Controls.Add(this.txtfzdgru);
            this.Controls.Add(this.txtfzyanlis);
            this.Controls.Add(this.txtfznet);
            this.Controls.Add(this.txttrdogru);
            this.Controls.Add(this.lblfizik);
            this.Controls.Add(this.lblmat);
            this.Controls.Add(this.lbltr);
            this.Controls.Add(this.lblnet);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lbld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblnet;
        private System.Windows.Forms.Label lbltr;
        private System.Windows.Forms.Label lblmat;
        private System.Windows.Forms.Label lblfizik;
        private System.Windows.Forms.TextBox txttrdogru;
        private System.Windows.Forms.TextBox txtfznet;
        private System.Windows.Forms.TextBox txtfzyanlis;
        private System.Windows.Forms.TextBox txtfzdgru;
        private System.Windows.Forms.TextBox txtmatnet;
        private System.Windows.Forms.TextBox txtmatyanlis;
        private System.Windows.Forms.TextBox txtmatdogru;
        private System.Windows.Forms.TextBox txttrnet;
        private System.Windows.Forms.TextBox txttryanlis;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

