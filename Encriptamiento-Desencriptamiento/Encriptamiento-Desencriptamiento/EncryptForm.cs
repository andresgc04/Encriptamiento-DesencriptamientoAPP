using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EncryptAndDecrypt;
using System.IO;

namespace Encriptamiento_Desencriptamiento
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var information = txtInformation.Text;

            if (string.IsNullOrEmpty(information) || string.IsNullOrWhiteSpace(information))
            {
                MessageBox.Show("No se pudo realizar el encriptamiento, porque no se ingreso informacion para encriptar!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                var resultEncrypt = EncryptsAndDecrypts.Encrypt(information);
                txtEncryptResult.Text = resultEncrypt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInformation.Clear();
            txtEncryptResult.Clear();
            txtInformation.Focus();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    txtInformation.Text = reader.ReadToEnd();
                }
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            var resultEncrypt = txtEncryptResult.Text;

            if (string.IsNullOrEmpty(resultEncrypt) || string.IsNullOrWhiteSpace(resultEncrypt))
            {
                MessageBox.Show("No se pudo copiar el encriptamiento, porque no se encuentra informacion encriptada!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                Clipboard.SetText(resultEncrypt);
                MessageBox.Show("La informacion encriptada se copio en el porta papeles!!");
            }
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultEncrypt = txtEncryptResult.Text;

            if (string.IsNullOrEmpty(resultEncrypt) || string.IsNullOrWhiteSpace(resultEncrypt))
            {
                MessageBox.Show("No se pudo guardar el encriptamiento, porque no se encuentra informacion encriptada!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                SaveFileDialog saveEncrypt = new SaveFileDialog();
                saveEncrypt.Filter = "Archivo texto|*.txt";

                if (saveEncrypt.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writeEncrypt = new StreamWriter(saveEncrypt.FileName))
                    {
                        writeEncrypt.Write(resultEncrypt);
                    }
                }
            }
        }
    }
}
