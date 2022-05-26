
namespace lab4_OOP
{
    partial class FormKategorija
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
            this.lblKategorija = new System.Windows.Forms.Label();
            this.labldatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.dtmDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtmDAtumDo = new System.Windows.Forms.DateTimePicker();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(65, 45);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(153, 32);
            this.lblKategorija.TabIndex = 0;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // labldatumOd
            // 
            this.labldatumOd.AutoSize = true;
            this.labldatumOd.Location = new System.Drawing.Point(65, 127);
            this.labldatumOd.Name = "labldatumOd";
            this.labldatumOd.Size = new System.Drawing.Size(145, 32);
            this.labldatumOd.TabIndex = 1;
            this.labldatumOd.Text = "Datum od:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(65, 201);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(145, 32);
            this.lblDatumDo.TabIndex = 2;
            this.lblDatumDo.Text = "Datum do:";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Items.AddRange(new object[] {
            "AM",
            "A1",
            "A2",
            "A",
            "B1",
            "B",
            "BE",
            "C1",
            "C1E",
            "C",
            "CE",
            "D1",
            "D1E",
            "D",
            "DE",
            "F",
            "M"});
            this.cmbKategorija.Location = new System.Drawing.Point(265, 36);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(290, 39);
            this.cmbKategorija.TabIndex = 3;
            // 
            // dtmDatumOd
            // 
            this.dtmDatumOd.CustomFormat = "dd.MM.yyyy.";
            this.dtmDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDatumOd.Location = new System.Drawing.Point(265, 120);
            this.dtmDatumOd.Name = "dtmDatumOd";
            this.dtmDatumOd.Size = new System.Drawing.Size(290, 38);
            this.dtmDatumOd.TabIndex = 4;
            // 
            // dtmDAtumDo
            // 
            this.dtmDAtumDo.CustomFormat = "dd.MM.yyyy.";
            this.dtmDAtumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDAtumDo.Location = new System.Drawing.Point(265, 195);
            this.dtmDAtumDo.Name = "dtmDAtumDo";
            this.dtmDAtumDo.Size = new System.Drawing.Size(290, 38);
            this.dtmDAtumDo.TabIndex = 5;
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(71, 295);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(192, 75);
            this.btnProsledi.TabIndex = 6;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(590, 295);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(166, 75);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 629);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.dtmDAtumDo);
            this.Controls.Add(this.dtmDatumOd);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.labldatumOd);
            this.Controls.Add(this.lblKategorija);
            this.Name = "FormKategorija";
            this.Text = "Kategorija";
            this.Load += new System.EventHandler(this.FormKategorija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label labldatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.DateTimePicker dtmDatumOd;
        private System.Windows.Forms.DateTimePicker dtmDAtumDo;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnZatvori;
    }
}