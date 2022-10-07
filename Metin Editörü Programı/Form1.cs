using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Metin_Editörü_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string aktifDosya = "Adsız";
        string baslik = "Metin Editörü Uygulaması";

        

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                yeniDosyaOluştur();
            }
            catch (Exception ex )
            {
                DosyayıKaydet();
 
            }
        }
       
        private void DosyayıKaydet()
        {

            txtAlan.SaveFile(aktifDosya);
        }

        private void yeniDosyaOluştur()
        {
            try
            {
                if (txtAlan.Text.Length > 0)
                {
                    DialogResult cevap = MessageBox.Show("Degişikleri Kaydetmek İstiyormusunuz", "Metin Editörü Uygulaması", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == cevap)
                    {
                        DosyayıFarklıKaydet();

                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DosyayıFarklıKaydet()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Zengin Metin Belgesi |*.rtf|Word Dosyası |*.docx|Metin belgesi|*.txt";
                sfd.Title = "Farklı Kaydet";
                aktifDosya = sfd.FileName;
                txtAlan.SaveFile(aktifDosya);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyayiAc();
        }

        private void DosyayiAc()
        {
            if (txtAlan.Text.Length>4)
            {
                DialogResult cevap = MessageBox.Show("Dosyayı degişikleri kayıt etmek istiyormusunuz ? ","Metin Editörü",MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
                if (DialogResult.Yes==cevap)
                {
                    if (aktifDosya=="Adısız")
                    {
                        DosyayıFarklıKaydet(); 
                    }
                    else
                    {
                        DosyayıKaydet();
                    }

                }
                
            }
          
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Dsosyayı Aç";
            ofd.Filter = "Zengin metin belgesi|*.rtf|Word belgesi|*.docx|Metin Belgesi|*.txt";
            ofd.ShowDialog();
            aktifDosya = ofd.FileName;
            txtAlan.LoadFile(aktifDosya);
            this.Text = aktifDosya + " - " + baslik;


        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aktifDosya=="adsız")
            {
                DosyayıFarklıKaydet();

            }
            else
            {
                DosyayıKaydet();

            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyayıFarklıKaydet();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CıkısYap();
        }

        private void CıkısYap()
        {
            DialogResult cevap = MessageBox.Show("Cıkış yapmak istiyormusunuz ?","Metin Editör Uygulaması",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes==cevap)
            {
                if (aktifDosya=="adsız")
                {
                    DosyayıFarklıKaydet();

                }
                else
                {
                    DosyayıKaydet();
                }

            }
            Application.Exit();
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İşlemiGeriAl();
        }

        private void İşlemiGeriAl()
        {

            if (txtAlan.CanUndo)
            {

                txtAlan.Undo();
            }

        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İslemiYenile();
        }

        private void İslemiYenile()
        {
            if (txtAlan.CanRedo)
            {

                txtAlan.Redo();
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecileniKes();
        }

        private void SecileniKes()
        {
            if (txtAlan.Text.Length>0)
            {
                txtAlan.Cut();
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecileniKopyala();
        }

        private void SecileniKopyala()
        {
            if (txtAlan.Text.Length>0)
            {
                txtAlan.Copy();
            }
        }

        private void yapıştıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecileniYapıştır();
        }

        private void SecileniYapıştır()
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                txtAlan.Paste();
            }
        }
        
        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazıRenginiDegiştir();
        }

        private void YazıRenginiDegiştir()
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            if ((txtAlan.SelectedText.Length > 0))
            {
                txtAlan.SelectionColor = cd.Color;

            }
            else
            {
                txtAlan.ForeColor = cd.Color;
            }

        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZeminRengi();
        }

        private void ZeminRengi()
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            if (txtAlan.SelectedText.Length>0)
            {
                txtAlan.SelectionBackColor=cd.Color;
            }
            else
            {
                txtAlan.BackColor = cd.Color;

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();   
            fd.ShowDialog();
            if (txtAlan.SelectedText.Length>0)
            {
                txtAlan.SelectionFont = fd.Font;

            }
            else
            {
                txtAlan.Font = fd.Font;
            }
        }

        private void ekranıKaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void öncekiBoyutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void simgeDurumunaKüçültToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripYeni_Click(object sender, EventArgs e)
        {

            try
            {
                yeniDosyaOluştur();
            }
            catch (Exception ex)
            {
                DosyayıKaydet();

            }
        }

        private void toolStripDosyaAc_Click(object sender, EventArgs e)
        {

            try
            {
                yeniDosyaOluştur();
            }
            catch (Exception ex)
            {
                DosyayıKaydet();

            }
        }

        private void toolStripKaydet_Click(object sender, EventArgs e)
        {

            if (aktifDosya == "adsız")
            {
                DosyayıFarklıKaydet();

            }
            else
            {
                DosyayıKaydet();

            }
        }

        private void toolStripKes_Click(object sender, EventArgs e)
        {
            SecileniKes();
        }

        private void toolStripKopyala_Click(object sender, EventArgs e)
        {
            SecileniKopyala();
        }

        private void toolStripYapıştır_Click(object sender, EventArgs e)
        {
            SecileniYapıştır();
        }

        private void toolStripGeeriAl_Click(object sender, EventArgs e)
        {
            İşlemiGeriAl();
        }

        private void toolStripYazıFontu_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            if (txtAlan.SelectedText.Length > 0)
            {
                txtAlan.SelectionFont = fd.Font;

            }
            else
            {
                txtAlan.Font = fd.Font;
            }
        }

        private void toolStripYazıRengiDegiştir_Click(object sender, EventArgs e)
        {
            YazıRenginiDegiştir();
        }

        private void toolStripZeminRengi_Click(object sender, EventArgs e)
        {
            ZeminRengi();
        }

        private void toolStripEkranıKapla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripSimgeDurumunaKücült_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fl = new Form2();
            fl.ShowDialog();
        }

        private void txtAlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripYenile_Click(object sender, EventArgs e)
        {
            İslemiYenile();        }
    }
    
}
