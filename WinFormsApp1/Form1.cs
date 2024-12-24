using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private RSACryptoServiceProvider? _rsa;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSaveKeys_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Ключі ще не згенеровані!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML файли|*.xml",
                Title = "Зберегти ключі"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, _rsa.ToXmlString(true));
                MessageBox.Show("Ключі успішно збережені!");
            }
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстові файли|*.txt",
                Title = "Вибрати файл із підписом"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSignature.Text = File.ReadAllText(openFileDialog.FileName);
                MessageBox.Show("Файл із підписом завантажено!");
            }
        }
        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            _rsa = new RSACryptoServiceProvider();
            txtPublicKey.Text = _rsa.ToXmlString(false);
            MessageBox.Show("Ключі згенеровано!");
        }

        private void btnSignMessage_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Спочатку згенеруйте ключі!");
                return;
            }

            string message = txtMessage.Text;
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(messageBytes);
                byte[] signature = _rsa.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
                txtSignature.Text = Convert.ToBase64String(signature);
            }
        }

        private void btnVerifySignature_Click(object sender, EventArgs e)
        {
            if (_rsa == null)
            {
                MessageBox.Show("Спочатку згенеруйте ключі!");
                return;
            }

            string message = txtMessage.Text;
            string signatureBase64 = txtSignature.Text;

            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            byte[] signature = Convert.FromBase64String(signatureBase64);

            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(messageBytes);
                bool isVerified = _rsa.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"), signature);
                MessageBox.Show(isVerified ? "Підпис вірний!" : "Підпис НЕ вірний!");
            }
        }
    }
}
