
namespace Encriptamiento_Desencriptamiento
{
    partial class EncryptForm
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
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lblIngreseLoQueDeseeEncriptar = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtEncryptResult = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInformation
            // 
            this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformation.Location = new System.Drawing.Point(12, 76);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformation.Size = new System.Drawing.Size(776, 155);
            this.txtInformation.TabIndex = 0;
            // 
            // lblIngreseLoQueDeseeEncriptar
            // 
            this.lblIngreseLoQueDeseeEncriptar.AutoSize = true;
            this.lblIngreseLoQueDeseeEncriptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngreseLoQueDeseeEncriptar.Location = new System.Drawing.Point(12, 52);
            this.lblIngreseLoQueDeseeEncriptar.Name = "lblIngreseLoQueDeseeEncriptar";
            this.lblIngreseLoQueDeseeEncriptar.Size = new System.Drawing.Size(244, 21);
            this.lblIngreseLoQueDeseeEncriptar.TabIndex = 1;
            this.lblIngreseLoQueDeseeEncriptar.Text = "Ingrese lo que desee encriptar:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 253);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 21);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtEncryptResult
            // 
            this.txtEncryptResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEncryptResult.Location = new System.Drawing.Point(12, 277);
            this.txtEncryptResult.Multiline = true;
            this.txtEncryptResult.Name = "txtEncryptResult";
            this.txtEncryptResult.ReadOnly = true;
            this.txtEncryptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEncryptResult.Size = new System.Drawing.Size(776, 155);
            this.txtEncryptResult.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(405, 459);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(85, 35);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encriptar";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(706, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 35);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem,
            this.guardarArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // guardarArchivoToolStripMenuItem
            // 
            this.guardarArchivoToolStripMenuItem.Name = "guardarArchivoToolStripMenuItem";
            this.guardarArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarArchivoToolStripMenuItem.Text = "Guardar archivo";
            this.guardarArchivoToolStripMenuItem.Click += new System.EventHandler(this.guardarArchivoToolStripMenuItem_Click);
            // 
            // btnClipboard
            // 
            this.btnClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClipboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClipboard.Location = new System.Drawing.Point(496, 459);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(204, 35);
            this.btnClipboard.TabIndex = 2;
            this.btnClipboard.Text = "Copiar en el porta papeles";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIngreseLoQueDeseeEncriptar);
            this.Controls.Add(this.txtEncryptResult);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EncryptForm";
            this.Text = "Encriptamiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label lblIngreseLoQueDeseeEncriptar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtEncryptResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoToolStripMenuItem;
    }
}