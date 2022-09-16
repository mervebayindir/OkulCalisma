
namespace hafta11
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.textBoxBirim = new System.Windows.Forms.TextBox();
            this.labelBirim = new System.Windows.Forms.Label();
            this.textBoxMaas = new System.Windows.Forms.TextBox();
            this.labelMaas = new System.Windows.Forms.Label();
            this.labelGorev = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(465, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(27, 25);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.labelAdSoyad.TabIndex = 1;
            this.labelAdSoyad.Text = "Ad Soyad";
            this.labelAdSoyad.Click += new System.EventHandler(this.labelAdSoyad_Click);
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(94, 22);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdSoyad.TabIndex = 2;
            // 
            // textBoxBirim
            // 
            this.textBoxBirim.Location = new System.Drawing.Point(94, 66);
            this.textBoxBirim.Name = "textBoxBirim";
            this.textBoxBirim.Size = new System.Drawing.Size(100, 20);
            this.textBoxBirim.TabIndex = 4;
            // 
            // labelBirim
            // 
            this.labelBirim.AutoSize = true;
            this.labelBirim.Location = new System.Drawing.Point(27, 66);
            this.labelBirim.Name = "labelBirim";
            this.labelBirim.Size = new System.Drawing.Size(29, 13);
            this.labelBirim.TabIndex = 3;
            this.labelBirim.Text = "Birim";
            // 
            // textBoxMaas
            // 
            this.textBoxMaas.Location = new System.Drawing.Point(94, 108);
            this.textBoxMaas.Name = "textBoxMaas";
            this.textBoxMaas.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaas.TabIndex = 6;
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(27, 108);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(33, 13);
            this.labelMaas.TabIndex = 5;
            this.labelMaas.Text = "Maaş";
            // 
            // labelGorev
            // 
            this.labelGorev.AutoSize = true;
            this.labelGorev.Location = new System.Drawing.Point(27, 148);
            this.labelGorev.Name = "labelGorev";
            this.labelGorev.Size = new System.Drawing.Size(36, 13);
            this.labelGorev.TabIndex = 7;
            this.labelGorev.Text = "Görev";
            this.labelGorev.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yönetici",
            "Memur",
            "Mühendis"});
            this.comboBox1.Location = new System.Drawing.Point(85, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(12, 188);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonEkle.TabIndex = 9;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(156, 188);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 10;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(85, 235);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonGuncelle.TabIndex = 11;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelGorev);
            this.Controls.Add(this.textBoxMaas);
            this.Controls.Add(this.labelMaas);
            this.Controls.Add(this.textBoxBirim);
            this.Controls.Add(this.labelBirim);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.TextBox textBoxBirim;
        private System.Windows.Forms.Label labelBirim;
        private System.Windows.Forms.TextBox textBoxMaas;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.Label labelGorev;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
    }
}

