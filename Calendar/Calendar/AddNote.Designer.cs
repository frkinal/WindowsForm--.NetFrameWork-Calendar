
namespace Calendar
{
    partial class AddNote
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
            System.Windows.Forms.Button btnGoster;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            System.Windows.Forms.Button btnGuncelle;
            this.btnBul = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.listViewNotlariniz = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBul2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKapat = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            btnGoster = new System.Windows.Forms.Button();
            btnGuncelle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            btnGoster.FlatAppearance.BorderSize = 0;
            btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnGoster.Image")));
            btnGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGoster.Location = new System.Drawing.Point(3, 0);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new System.Drawing.Size(234, 72);
            btnGoster.TabIndex = 42;
            btnGoster.Text = "Goster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGuncelle
            // 
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGuncelle.Location = new System.Drawing.Point(243, 0);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(244, 72);
            btnGuncelle.TabIndex = 43;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Transparent;
            this.btnBul.FlatAppearance.BorderSize = 0;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Image = ((System.Drawing.Image)(resources.GetObject("btnBul.Image")));
            this.btnBul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBul.Location = new System.Drawing.Point(0, 27);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(196, 55);
            this.btnBul.TabIndex = 25;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpSaat
            // 
            this.dtpSaat.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSaat.Location = new System.Drawing.Point(443, 85);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(186, 22);
            this.dtpSaat.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(150, 86);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(129, 22);
            this.dtpTarih.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Notunuz";
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.LightGray;
            this.txtNot.Location = new System.Drawing.Point(150, 187);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(630, 56);
            this.txtNot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(376, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Saat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(51, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Konu";
            // 
            // txtKonu
            // 
            this.txtKonu.BackColor = System.Drawing.Color.LightGray;
            this.txtKonu.Location = new System.Drawing.Point(150, 142);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(222, 22);
            this.txtKonu.TabIndex = 2;
            // 
            // listViewNotlariniz
            // 
            this.listViewNotlariniz.BackColor = System.Drawing.Color.LightGray;
            this.listViewNotlariniz.CheckBoxes = true;
            this.listViewNotlariniz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewNotlariniz.HideSelection = false;
            this.listViewNotlariniz.Location = new System.Drawing.Point(54, 301);
            this.listViewNotlariniz.Name = "listViewNotlariniz";
            this.listViewNotlariniz.Size = new System.Drawing.Size(818, 249);
            this.listViewNotlariniz.TabIndex = 35;
            this.listViewNotlariniz.UseCompatibleStateImageBehavior = false;
            this.listViewNotlariniz.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Saat";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Konu";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Notunuz";
            this.columnHeader4.Width = 529;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(51, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Notlariniz";
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(493, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(245, 72);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBul2
            // 
            this.btnBul2.FlatAppearance.BorderSize = 0;
            this.btnBul2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul2.Image = ((System.Drawing.Image)(resources.GetObject("btnBul2.Image")));
            this.btnBul2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBul2.Location = new System.Drawing.Point(0, 110);
            this.btnBul2.Name = "btnBul2";
            this.btnBul2.Size = new System.Drawing.Size(196, 53);
            this.btnBul2.TabIndex = 38;
            this.btnBul2.Text = "Bul";
            this.btnBul2.UseVisualStyleBackColor = true;
            this.btnBul2.Click += new System.EventHandler(this.btnBul2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tarih ve Saat ile Arama Yap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(26, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tarih ile Arama Yap";
            // 
            // txtKapat
            // 
            this.txtKapat.FlatAppearance.BorderSize = 0;
            this.txtKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtKapat.Image = ((System.Drawing.Image)(resources.GetObject("txtKapat.Image")));
            this.txtKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtKapat.Location = new System.Drawing.Point(744, 0);
            this.txtKapat.Name = "txtKapat";
            this.txtKapat.Size = new System.Drawing.Size(240, 72);
            this.txtKapat.TabIndex = 41;
            this.txtKapat.Text = "Kapat";
            this.txtKapat.UseVisualStyleBackColor = true;
            this.txtKapat.Click += new System.EventHandler(this.txtKapat_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(btnGoster);
            this.panel1.Controls.Add(this.txtKapat);
            this.panel1.Controls.Add(btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Location = new System.Drawing.Point(-2, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 72);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnBul);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnBul2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(786, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 242);
            this.panel2.TabIndex = 45;
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewNotlariniz);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpSaat);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNote";
            this.Load += new System.EventHandler(this.AddNote_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.ListView listViewNotlariniz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBul2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtKapat;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}