namespace HomeLog
{
    partial class CihazForm
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
            lblCihazAdi = new DevExpress.XtraEditors.LabelControl();
            txtCihazAdi = new DevExpress.XtraEditors.TextEdit();
            txtMarka = new DevExpress.XtraEditors.TextEdit();
            lblMarka = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtCihazAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblCihazAdi
            // 
            lblCihazAdi.Appearance.ForeColor = Color.FromArgb(36, 36, 36);
            lblCihazAdi.Appearance.Options.UseForeColor = true;
            lblCihazAdi.Location = new Point(53, 37);
            lblCihazAdi.Name = "lblCihazAdi";
            lblCihazAdi.Size = new Size(44, 13);
            lblCihazAdi.TabIndex = 0;
            lblCihazAdi.Text = "Cihaz Adı";
            // 
            // txtCihazAdi
            // 
            txtCihazAdi.Location = new Point(118, 30);
            txtCihazAdi.Name = "txtCihazAdi";
            txtCihazAdi.Size = new Size(94, 28);
            txtCihazAdi.TabIndex = 1;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(118, 72);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(94, 28);
            txtMarka.TabIndex = 3;
            // 
            // lblMarka
            // 
            lblMarka.Appearance.ForeColor = Color.FromArgb(36, 36, 36);
            lblMarka.Appearance.Options.UseForeColor = true;
            lblMarka.Location = new Point(53, 79);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(29, 13);
            lblMarka.TabIndex = 2;
            lblMarka.Text = "Marka";
            // 
            // CihazForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMarka);
            Controls.Add(lblMarka);
            Controls.Add(txtCihazAdi);
            Controls.Add(lblCihazAdi);
            Name = "CihazForm";
            Text = "Cihaz Bilgileri";
            Load += CihazForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtCihazAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMarka.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCihazAdi;
        private DevExpress.XtraEditors.TextEdit txtCihazAdi;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl lblMarka;
    }
}