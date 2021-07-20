using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EncryptAndDecrypt;

namespace Encriptamiento_Desencriptamiento
{
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var information = txtInformation.Text;

            if (string.IsNullOrEmpty(information) || string.IsNullOrWhiteSpace(information))
            {
                MessageBox.Show("No se pudo realizar el desencriptamiento, porque no se ingreso informacion para desencriptar!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                var resultDecrypt = EncryptsAndDecrypts.Decrypt(information);
                txtDecryptResult.Text = resultDecrypt;
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            var resultDecrypt = txtDecryptResult.Text;

            if (string.IsNullOrEmpty(resultDecrypt) || string.IsNullOrWhiteSpace(resultDecrypt))
            {
                MessageBox.Show("No se pudo copiar el desencriptamiento, porque no se encuentra informacion desencriptada!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                Clipboard.SetText(resultDecrypt);
                MessageBox.Show("La informacion desencriptada se copio en el porta papeles!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInformation.Clear();
            txtDecryptResult.Clear();
            txtInformation.Focus();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    txtInformation.Text = reader.ReadToEnd();
                }
            }
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultDecrypt = txtDecryptResult.Text;

            if (string.IsNullOrEmpty(resultDecrypt) || string.IsNullOrWhiteSpace(resultDecrypt))
            {
                MessageBox.Show("No se pudo guardar el desencriptamiento, porque no se encuentra informacion desencriptada!!");
                txtInformation.Clear();
                txtInformation.Focus();
            }
            else
            {
                SaveFileDialog saveDecrypt = new SaveFileDialog();
                saveDecrypt.Filter = "Archivo texto|*.txt";

                if (saveDecrypt.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writeDecrypt = new StreamWriter(saveDecrypt.FileName))
                    {
                        writeDecrypt.Write(resultDecrypt);
                    }
                }
            }
        }
    }
}
