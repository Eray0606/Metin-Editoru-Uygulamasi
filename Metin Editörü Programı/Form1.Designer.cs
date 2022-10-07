namespace Metin_Editörü_Programı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAlan = new System.Windows.Forms.RichTextBox();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıKaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiBoyutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunaKüçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripYeni = new System.Windows.Forms.ToolStripButton();
            this.toolStripDosyaAc = new System.Windows.Forms.ToolStripButton();
            this.toolStripKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripKes = new System.Windows.Forms.ToolStripButton();
            this.toolStripKopyala = new System.Windows.Forms.ToolStripButton();
            this.toolStripYapıştır = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGeeriAl = new System.Windows.Forms.ToolStripButton();
            this.toolStripYenile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripYazıFontu = new System.Windows.Forms.ToolStripButton();
            this.toolStripYazıRengiDegiştir = new System.Windows.Forms.ToolStripButton();
            this.toolStripZeminRengi = new System.Windows.Forms.ToolStripButton();
            this.toolStripEkranıKapla = new System.Windows.Forms.ToolStripButton();
            this.toolStripÖncekiBoyut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSimgeDurumunaKücült = new System.Windows.Forms.ToolStripButton();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAlan
            // 
            this.txtAlan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAlan.Location = new System.Drawing.Point(0, 58);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(800, 392);
            this.txtAlan.TabIndex = 1;
            this.txtAlan.Text = "";
            this.txtAlan.TextChanged += new System.EventHandler(this.txtAlan_TextChanged);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.toolStripSeparator1,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştıtToolStripMenuItem,
            this.toolStripSeparator4,
            this.yazıRengiToolStripMenuItem,
            this.zeminRengiToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.geriAlToolStripMenuItem.Text = "Geri al";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yineleToolStripMenuItem.Text = "Yinele";
            this.yineleToolStripMenuItem.Click += new System.EventHandler(this.yineleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştıtToolStripMenuItem
            // 
            this.yapıştıtToolStripMenuItem.Name = "yapıştıtToolStripMenuItem";
            this.yapıştıtToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yapıştıtToolStripMenuItem.Text = "Yapıştır";
            this.yapıştıtToolStripMenuItem.Click += new System.EventHandler(this.yapıştıtToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // yazıRengiToolStripMenuItem
            // 
            this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.yazıRengiToolStripMenuItem_Click);
            // 
            // zeminRengiToolStripMenuItem
            // 
            this.zeminRengiToolStripMenuItem.Name = "zeminRengiToolStripMenuItem";
            this.zeminRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.zeminRengiToolStripMenuItem.Text = "Zemin  Rengi";
            this.zeminRengiToolStripMenuItem.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranıKaplaToolStripMenuItem,
            this.öncekiBoyutToolStripMenuItem,
            this.simgeDurumunaKüçültToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // ekranıKaplaToolStripMenuItem
            // 
            this.ekranıKaplaToolStripMenuItem.Name = "ekranıKaplaToolStripMenuItem";
            this.ekranıKaplaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.ekranıKaplaToolStripMenuItem.Text = "Ekranı Kapla";
            this.ekranıKaplaToolStripMenuItem.Click += new System.EventHandler(this.ekranıKaplaToolStripMenuItem_Click);
            // 
            // öncekiBoyutToolStripMenuItem
            // 
            this.öncekiBoyutToolStripMenuItem.Name = "öncekiBoyutToolStripMenuItem";
            this.öncekiBoyutToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.öncekiBoyutToolStripMenuItem.Text = "Önceki Boyut";
            this.öncekiBoyutToolStripMenuItem.Click += new System.EventHandler(this.öncekiBoyutToolStripMenuItem_Click);
            // 
            // simgeDurumunaKüçültToolStripMenuItem
            // 
            this.simgeDurumunaKüçültToolStripMenuItem.Name = "simgeDurumunaKüçültToolStripMenuItem";
            this.simgeDurumunaKüçültToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.simgeDurumunaKüçültToolStripMenuItem.Text = "Simge Durumuna Küçült";
            this.simgeDurumunaKüçültToolStripMenuItem.Click += new System.EventHandler(this.simgeDurumunaKüçültToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripYeni,
            this.toolStripDosyaAc,
            this.toolStripKaydet,
            this.toolStripSeparator5,
            this.toolStripKes,
            this.toolStripKopyala,
            this.toolStripYapıştır,
            this.toolStripSeparator6,
            this.toolStripGeeriAl,
            this.toolStripYenile,
            this.toolStripSeparator7,
            this.toolStripYazıFontu,
            this.toolStripYazıRengiDegiştir,
            this.toolStripZeminRengi,
            this.toolStripEkranıKapla,
            this.toolStripÖncekiBoyut,
            this.toolStripSimgeDurumunaKücült});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripYeni
            // 
            this.toolStripYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripYeni.Image = ((System.Drawing.Image)(resources.GetObject("toolStripYeni.Image")));
            this.toolStripYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripYeni.Name = "toolStripYeni";
            this.toolStripYeni.Size = new System.Drawing.Size(29, 24);
            this.toolStripYeni.Text = "Yeni";
            this.toolStripYeni.Click += new System.EventHandler(this.toolStripYeni_Click);
            // 
            // toolStripDosyaAc
            // 
            this.toolStripDosyaAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDosyaAc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDosyaAc.Image")));
            this.toolStripDosyaAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDosyaAc.Name = "toolStripDosyaAc";
            this.toolStripDosyaAc.Size = new System.Drawing.Size(29, 24);
            this.toolStripDosyaAc.Text = "DosyaAc";
            this.toolStripDosyaAc.Click += new System.EventHandler(this.toolStripDosyaAc_Click);
            // 
            // toolStripKaydet
            // 
            this.toolStripKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripKaydet.Image")));
            this.toolStripKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKaydet.Name = "toolStripKaydet";
            this.toolStripKaydet.Size = new System.Drawing.Size(29, 24);
            this.toolStripKaydet.Text = "Kaydet";
            this.toolStripKaydet.Click += new System.EventHandler(this.toolStripKaydet_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripKes
            // 
            this.toolStripKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripKes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripKes.Image")));
            this.toolStripKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKes.Name = "toolStripKes";
            this.toolStripKes.Size = new System.Drawing.Size(29, 24);
            this.toolStripKes.Text = "Kes";
            this.toolStripKes.Click += new System.EventHandler(this.toolStripKes_Click);
            // 
            // toolStripKopyala
            // 
            this.toolStripKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripKopyala.Image = ((System.Drawing.Image)(resources.GetObject("toolStripKopyala.Image")));
            this.toolStripKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripKopyala.Name = "toolStripKopyala";
            this.toolStripKopyala.Size = new System.Drawing.Size(29, 24);
            this.toolStripKopyala.Text = "Kopyala";
            this.toolStripKopyala.Click += new System.EventHandler(this.toolStripKopyala_Click);
            // 
            // toolStripYapıştır
            // 
            this.toolStripYapıştır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripYapıştır.Image = ((System.Drawing.Image)(resources.GetObject("toolStripYapıştır.Image")));
            this.toolStripYapıştır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripYapıştır.Name = "toolStripYapıştır";
            this.toolStripYapıştır.Size = new System.Drawing.Size(29, 24);
            this.toolStripYapıştır.Text = "Yapıştır";
            this.toolStripYapıştır.Click += new System.EventHandler(this.toolStripYapıştır_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripGeeriAl
            // 
            this.toolStripGeeriAl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGeeriAl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGeeriAl.Image")));
            this.toolStripGeeriAl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGeeriAl.Name = "toolStripGeeriAl";
            this.toolStripGeeriAl.Size = new System.Drawing.Size(29, 24);
            this.toolStripGeeriAl.Text = "GeriAl";
            this.toolStripGeeriAl.Click += new System.EventHandler(this.toolStripGeeriAl_Click);
            // 
            // toolStripYenile
            // 
            this.toolStripYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripYenile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripYenile.Image")));
            this.toolStripYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripYenile.Name = "toolStripYenile";
            this.toolStripYenile.Size = new System.Drawing.Size(29, 24);
            this.toolStripYenile.Text = "Yenile";
            this.toolStripYenile.Click += new System.EventHandler(this.toolStripYenile_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripYazıFontu
            // 
            this.toolStripYazıFontu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripYazıFontu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripYazıFontu.Image")));
            this.toolStripYazıFontu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripYazıFontu.Name = "toolStripYazıFontu";
            this.toolStripYazıFontu.Size = new System.Drawing.Size(29, 24);
            this.toolStripYazıFontu.Text = "Yazı Fontunu Degiştir";
            this.toolStripYazıFontu.Click += new System.EventHandler(this.toolStripYazıFontu_Click);
            // 
            // toolStripYazıRengiDegiştir
            // 
            this.toolStripYazıRengiDegiştir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripYazıRengiDegiştir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripYazıRengiDegiştir.Image")));
            this.toolStripYazıRengiDegiştir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripYazıRengiDegiştir.Name = "toolStripYazıRengiDegiştir";
            this.toolStripYazıRengiDegiştir.Size = new System.Drawing.Size(29, 24);
            this.toolStripYazıRengiDegiştir.Text = "Yazı Rengi Degiştir";
            this.toolStripYazıRengiDegiştir.Click += new System.EventHandler(this.toolStripYazıRengiDegiştir_Click);
            // 
            // toolStripZeminRengi
            // 
            this.toolStripZeminRengi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZeminRengi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripZeminRengi.Image")));
            this.toolStripZeminRengi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZeminRengi.Name = "toolStripZeminRengi";
            this.toolStripZeminRengi.Size = new System.Drawing.Size(29, 24);
            this.toolStripZeminRengi.Text = "Zemin Rengini Degiştir";
            this.toolStripZeminRengi.Click += new System.EventHandler(this.toolStripZeminRengi_Click);
            // 
            // toolStripEkranıKapla
            // 
            this.toolStripEkranıKapla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEkranıKapla.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEkranıKapla.Image")));
            this.toolStripEkranıKapla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEkranıKapla.Name = "toolStripEkranıKapla";
            this.toolStripEkranıKapla.Size = new System.Drawing.Size(29, 24);
            this.toolStripEkranıKapla.Text = "Ekranı kapla";
            this.toolStripEkranıKapla.Click += new System.EventHandler(this.toolStripEkranıKapla_Click);
            // 
            // toolStripÖncekiBoyut
            // 
            this.toolStripÖncekiBoyut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripÖncekiBoyut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripÖncekiBoyut.Image")));
            this.toolStripÖncekiBoyut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripÖncekiBoyut.Name = "toolStripÖncekiBoyut";
            this.toolStripÖncekiBoyut.Size = new System.Drawing.Size(29, 24);
            this.toolStripÖncekiBoyut.Text = "Önceki  Boyut";
            // 
            // toolStripSimgeDurumunaKücült
            // 
            this.toolStripSimgeDurumunaKücült.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSimgeDurumunaKücült.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSimgeDurumunaKücült.Image")));
            this.toolStripSimgeDurumunaKücült.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSimgeDurumunaKücült.Name = "toolStripSimgeDurumunaKücült";
            this.toolStripSimgeDurumunaKücült.Size = new System.Drawing.Size(29, 24);
            this.toolStripSimgeDurumunaKücült.Text = " ";
            this.toolStripSimgeDurumunaKücült.Click += new System.EventHandler(this.toolStripSimgeDurumunaKücült_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hakkındaToolStripMenuItem.Text = "Hakkında ";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Metin Editörü Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAlan;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıKaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiBoyutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunaKüçültToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripYeni;
        private System.Windows.Forms.ToolStripButton toolStripDosyaAc;
        private System.Windows.Forms.ToolStripButton toolStripKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripKes;
        private System.Windows.Forms.ToolStripButton toolStripKopyala;
        private System.Windows.Forms.ToolStripButton toolStripYapıştır;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripGeeriAl;
        private System.Windows.Forms.ToolStripButton toolStripYenile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripYazıFontu;
        private System.Windows.Forms.ToolStripButton toolStripYazıRengiDegiştir;
        private System.Windows.Forms.ToolStripButton toolStripZeminRengi;
        private System.Windows.Forms.ToolStripButton toolStripEkranıKapla;
        private System.Windows.Forms.ToolStripButton toolStripÖncekiBoyut;
        private System.Windows.Forms.ToolStripButton toolStripSimgeDurumunaKücült;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

