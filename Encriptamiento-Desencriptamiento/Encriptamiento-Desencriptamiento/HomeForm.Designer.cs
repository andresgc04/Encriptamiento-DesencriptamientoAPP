
namespace Encriptamiento_Desencriptamiento
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenEncryptForm = new System.Windows.Forms.Button();
            this.btnOpenDecryptForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(159, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "¿Que desea realizar?";
            // 
            // btnOpenEncryptForm
            // 
            this.btnOpenEncryptForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenEncryptForm.Location = new System.Drawing.Point(153, 108);
            this.btnOpenEncryptForm.Name = "btnOpenEncryptForm";
            this.btnOpenEncryptForm.Size = new System.Drawing.Size(123, 43);
            this.btnOpenEncryptForm.TabIndex = 1;
            this.btnOpenEncryptForm.Text = "Encriptar Data";
            this.btnOpenEncryptForm.UseVisualStyleBackColor = true;
            this.btnOpenEncryptForm.Click += new System.EventHandler(this.btnOpenEncryptForm_Click);
            // 
            // btnOpenDecryptForm
            // 
            this.btnOpenDecryptForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDecryptForm.Location = new System.Drawing.Point(314, 108);
            this.btnOpenDecryptForm.Name = "btnOpenDecryptForm";
            this.btnOpenDecryptForm.Size = new System.Drawing.Size(148, 43);
            this.btnOpenDecryptForm.TabIndex = 1;
            this.btnOpenDecryptForm.Text = "Desencriptar Data";
            this.btnOpenDecryptForm.UseVisualStyleBackColor = true;
            this.btnOpenDecryptForm.Click += new System.EventHandler(this.btnOpenDecryptForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "O";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenDecryptForm);
            this.Controls.Add(this.btnOpenEncryptForm);
            this.Controls.Add(this.lblTitle);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpenEncryptForm;
        private System.Windows.Forms.Button btnOpenDecryptForm;
        private System.Windows.Forms.Label label1;
    }
}

