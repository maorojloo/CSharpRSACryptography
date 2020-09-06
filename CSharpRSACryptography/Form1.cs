using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CSharpRSACryptography
{
    public partial class Form1 : Form
    {
        private readonly RSACryptoServiceProvider _cryptoServiceProvider;

        public Form1()
        {
            InitializeComponent();
            _cryptoServiceProvider = new RSACryptoServiceProvider(2048);
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            // تولید کلید عمومی
            var publicKey = _cryptoServiceProvider.ExportParameters(false);
            // تبدیل کلید به رشته
            var publicKeyString = RsaCryptography.GetKeyString(publicKey);
            // رمزگذاری متن ساده
            var result = RsaCryptography.Encrypt(TxtPlainText.Text, publicKeyString);
            // نمایش متن رمزگذاری شده
            TxtEncryptedText.Text = result;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            // تولید کلید خصوصی
            var privateKey = _cryptoServiceProvider.ExportParameters(true);
            // تبدیل کلید به رشته
            var privateKeyString = RsaCryptography.GetKeyString(privateKey);
            // رمزگشایی متن رمزگذاری شده
            var result = RsaCryptography.Decrypt(TxtEncryptedText.Text, privateKeyString);
            // نمایش متن رمزگشایی شده
            TxtDecrytedText.Text = result;
        }
    }
}
