using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptamiento_Desencriptamiento
{
    public partial class HomeForm : Form
    {
        //Instanciar Formulario para encriptar informaciones:
        EncryptForm encryptForm;

        //Instanciar Formulario para desencriptar informaciones:
        DecryptForm decryptForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnOpenEncryptForm_Click(object sender, EventArgs e)
        {
            encryptForm = new EncryptForm();

            encryptForm.ShowDialog();
        }

        private void btnOpenDecryptForm_Click(object sender, EventArgs e)
        {
            decryptForm = new DecryptForm();

            decryptForm.ShowDialog();
        }
    }
}
