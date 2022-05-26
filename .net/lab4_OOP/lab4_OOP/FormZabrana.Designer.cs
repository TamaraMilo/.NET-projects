
namespace lab4_OOP
{
    partial class FormZabrana
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
            this.lblKategorija_z = new System.Windows.Forms.Label();
            this.lblDatumOdZ = new System.Windows.Forms.Label();
            this.lblDatumDoZ = new System.Windows.Forms.Label();
            this.cbxKategorijaZ = new System.Windows.Forms.ComboBox();
            this.dtpOd_Z = new System.Windows.Forms.DateTimePicker();
            this.dtpDo_z = new System.Windows.Forms.DateTimePicker();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategorija_z
            // 
            this.lblKategorija_z.AutoSize = true;
            this.lblKategorija_z.Location = new System.Drawing.Point(55, 64);
            this.lblKategorija_z.Name = "lblKategorija_z";
            this.lblKategorija_z.Size = new System.Drawing.Size(153, 32);
            this.lblKategorija_z.TabIndex = 0;
            this.lblKategorija_z.Text = "Kategorije:";
            // 
            // lblDatumOdZ
            // 
            this.lblDatumOdZ.AutoSize = true;
            this.lblDatumOdZ.Location = new System.Drawing.Point(55, 153);
            this.lblDatumOdZ.Name = "lblDatumOdZ";
            this.lblDatumOdZ.Size = new System.Drawing.Size(145, 32);
            this.lblDatumOdZ.TabIndex = 1;
            this.lblDatumOdZ.Text = "Datum od:";
            // 
            // lblDatumDoZ
            // 
            this.lblDatumDoZ.AutoSize = true;
            this.lblDatumDoZ.Location = new System.Drawing.Point(55, 246);
            this.lblDatumDoZ.Name = "lblDatumDoZ";
            this.lblDatumDoZ.Size = new System.Drawing.Size(145, 32);
            this.lblDatumDoZ.TabIndex = 2;
            this.lblDatumDoZ.Text = "Datum do:";
            // 
            // cbxKategorijaZ
            // 
            this.cbxKategorijaZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategorijaZ.FormattingEnabled = true;
            this.cbxKategorijaZ.Location = new System.Drawing.Point(269, 57);
            this.cbxKategorijaZ.Name = "cbxKategorijaZ";
            this.cbxKategorijaZ.Size = new System.Drawing.Size(273, 39);
            this.cbxKategorijaZ.TabIndex = 3;
            // 
            // dtpOd_Z
            // 
            this.dtpOd_Z.CustomFormat = "dd.MM.yyyy.";
            this.dtpOd_Z.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOd_Z.Location = new System.Drawing.Point(269, 146);
            this.dtpOd_Z.Name = "dtpOd_Z";
            this.dtpOd_Z.Size = new System.Drawing.Size(287, 38);
            this.dtpOd_Z.TabIndex = 4;
            // 
            // dtpDo_z
            // 
            this.dtpDo_z.CustomFormat = "dd.MM.yyyy.";
            this.dtpDo_z.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDo_z.Location = new System.Drawing.Point(269, 240);
            this.dtpDo_z.Name = "dtpDo_z";
            this.dtpDo_z.Size = new System.Drawing.Size(287, 38);
            this.dtpDo_z.TabIndex = 5;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(132, 415);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(203, 77);
            this.btnProsledi.TabIndex = 6;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(559, 415);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(205, 77);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // FormZabrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 695);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.dtpDo_z);
            this.Controls.Add(this.dtpOd_Z);
            this.Controls.Add(this.cbxKategorijaZ);
            this.Controls.Add(this.lblDatumDoZ);
            this.Controls.Add(this.lblDatumOdZ);
            this.Controls.Add(this.lblKategorija_z);
            this.Name = "FormZabrana";
            this.Text = "FormZabrana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorija_z;
        private System.Windows.Forms.Label lblDatumOdZ;
        private System.Windows.Forms.Label lblDatumDoZ;
        private System.Windows.Forms.ComboBox cbxKategorijaZ;
        private System.Windows.Forms.DateTimePicker dtpOd_Z;
        private System.Windows.Forms.DateTimePicker dtpDo_z;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}