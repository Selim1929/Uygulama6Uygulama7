using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Uygulama6Uygulama7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DuzenKes_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void DuzenKopyala_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void DuzenYapıstır_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void kopyalaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void yapıstırToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void Anacıkıs_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz ?", "Dosya silindi",
MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cevap == DialogResult.Yes)
            {
                this.Close();
            }
            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("İşlem iptal edildi.");
            }

        }

        private void MenuKaydet_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Dosyası | *.txt | Tüm Dosyalar | *.*";
                DialogResult cevap = sfd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    txtEditor.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void MenuAc_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Dosyaları | *.txt";
                DialogResult cevap = ofd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    txtEditor.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void MenuYazdır_Click(object sender, EventArgs e)
        {
            {
                PrintDialog pd = new PrintDialog();
                DialogResult cevap = pd.ShowDialog();
                if (cevap == DialogResult.OK)
                {
                    belge.Print();
                }
            }
        }
    }
}
