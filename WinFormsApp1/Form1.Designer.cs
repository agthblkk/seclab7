namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnSignMessage;
        private System.Windows.Forms.Button btnVerifySignature;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Button btnSaveKeys;
        private System.Windows.Forms.Button btnLoadFile;

        private void InitializeComponent()
        {
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnSignMessage = new System.Windows.Forms.Button();
            this.btnVerifySignature = new System.Windows.Forms.Button();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.btnSaveKeys = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            
            
            this.btnSaveKeys.Text = "Зберегти ключі";
            this.btnSaveKeys.Location = new System.Drawing.Point(180, 215);
            this.btnSaveKeys.Size = new System.Drawing.Size(192, 30);
            this.btnSaveKeys.Click += new System.EventHandler(this.btnSaveKeys_Click);
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.Text = "Відкритий ключ:";
            this.lblPublicKey.Location = new System.Drawing.Point(12, 12);
            this.lblPublicKey.Size = new System.Drawing.Size(150, 20);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(12, 35);
            this.txtPublicKey.Size = new System.Drawing.Size(360, 20);
            // 
            // lblMessage
            // 
            this.lblMessage.Text = "Повідомлення:";
            this.lblMessage.Location = new System.Drawing.Point(12, 65);
            this.lblMessage.Size = new System.Drawing.Size(150, 20);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 88);
            this.txtMessage.Size = new System.Drawing.Size(360, 20);
            // 
            // lblSignature
            // 
            this.lblSignature.Text = "Підпис:";
            this.lblSignature.Location = new System.Drawing.Point(12, 118);
            this.lblSignature.Size = new System.Drawing.Size(150, 20);
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(12, 141);
            this.txtSignature.Size = new System.Drawing.Size(360, 20);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Text = "Згенерувати ключі";
            this.btnGenerateKeys.Location = new System.Drawing.Point(12, 175);
            this.btnGenerateKeys.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnSignMessage
            // 
            this.btnSignMessage.Text = "Підписати повідомлення";
            this.btnSignMessage.Location = new System.Drawing.Point(180, 175);
            this.btnSignMessage.Size = new System.Drawing.Size(192, 30);
            this.btnSignMessage.Click += new System.EventHandler(this.btnSignMessage_Click);
            // 
            // btnVerifySignature
            // 
            this.btnVerifySignature.Text = "Перевірити підпис";
            this.btnVerifySignature.Location = new System.Drawing.Point(12, 215);
            this.btnVerifySignature.Size = new System.Drawing.Size(360, 30);
            this.btnVerifySignature.Click += new System.EventHandler(this.btnVerifySignature_Click);
            
            this.btnLoadFile.Text = "Завантажити файл із підписом";
            this.btnLoadFile.Location = new System.Drawing.Point(12, 255);
            this.btnLoadFile.Size = new System.Drawing.Size(360, 30);
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblPublicKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.btnSignMessage);
            this.Controls.Add(this.btnVerifySignature);
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnSaveKeys);
            this.Controls.Add(this.btnLoadFile);
            this.Text = "Main Form";
        }
    }
}
