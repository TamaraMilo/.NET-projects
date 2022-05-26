
namespace lab4_OOP
{
    partial class LFormListaVozaca
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
            this.components = new System.ComponentModel.Container();
            this.lblTrenutnoVreme = new System.Windows.Forms.Label();
            this.lblListaVozaca = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.cmbPodaci = new System.Windows.Forms.ComboBox();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.btnIzmeniVozaca = new System.Windows.Forms.Button();
            this.btnObrisiVozaca = new System.Windows.Forms.Button();
            this.btnDodajVozaca = new System.Windows.Forms.Button();
            this.tmrTacnoVreme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrenutnoVreme
            // 
            this.lblTrenutnoVreme.AutoSize = true;
            this.lblTrenutnoVreme.Location = new System.Drawing.Point(83, 59);
            this.lblTrenutnoVreme.Name = "lblTrenutnoVreme";
            this.lblTrenutnoVreme.Size = new System.Drawing.Size(310, 32);
            this.lblTrenutnoVreme.TabIndex = 0;
            this.lblTrenutnoVreme.Text = "HH:mm:ss dd.MM.yyyy.";
            // 
            // lblListaVozaca
            // 
            this.lblListaVozaca.AutoSize = true;
            this.lblListaVozaca.Location = new System.Drawing.Point(83, 133);
            this.lblListaVozaca.Name = "lblListaVozaca";
            this.lblListaVozaca.Size = new System.Drawing.Size(173, 32);
            this.lblListaVozaca.TabIndex = 1;
            this.lblListaVozaca.Text = "Lista vozaca";
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortiraj.Location = new System.Drawing.Point(1257, 59);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(251, 81);
            this.btnSortiraj.TabIndex = 2;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            // 
            // cmbPodaci
            // 
            this.cmbPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPodaci.FormattingEnabled = true;
            this.cmbPodaci.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cmbPodaci.Location = new System.Drawing.Point(1558, 81);
            this.cmbPodaci.Name = "cmbPodaci";
            this.cmbPodaci.Size = new System.Drawing.Size(339, 39);
            this.cmbPodaci.TabIndex = 3;
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaVozaca.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.GridColor = System.Drawing.SystemColors.Window;
            this.dgvListaVozaca.Location = new System.Drawing.Point(89, 233);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.RowHeadersWidth = 102;
            this.dgvListaVozaca.RowTemplate.Height = 40;
            this.dgvListaVozaca.Size = new System.Drawing.Size(1808, 696);
            this.dgvListaVozaca.TabIndex = 4;
            // 
            // btnIzmeniVozaca
            // 
            this.btnIzmeniVozaca.Image = global::lab4_OOP.Properties.Resources.edit;
            this.btnIzmeniVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeniVozaca.Location = new System.Drawing.Point(476, 966);
            this.btnIzmeniVozaca.Name = "btnIzmeniVozaca";
            this.btnIzmeniVozaca.Size = new System.Drawing.Size(324, 112);
            this.btnIzmeniVozaca.TabIndex = 7;
            this.btnIzmeniVozaca.Text = "Izmena vozaca";
            this.btnIzmeniVozaca.UseVisualStyleBackColor = true;
            this.btnIzmeniVozaca.Click += new System.EventHandler(this.btnIzmeniVozaca_Click);
            // 
            // btnObrisiVozaca
            // 
            this.btnObrisiVozaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiVozaca.Image = global::lab4_OOP.Properties.Resources.delete;
            this.btnObrisiVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiVozaca.Location = new System.Drawing.Point(1587, 966);
            this.btnObrisiVozaca.Name = "btnObrisiVozaca";
            this.btnObrisiVozaca.Size = new System.Drawing.Size(310, 112);
            this.btnObrisiVozaca.TabIndex = 6;
            this.btnObrisiVozaca.Text = "Obrisi vozaca";
            this.btnObrisiVozaca.UseVisualStyleBackColor = true;
            this.btnObrisiVozaca.Click += new System.EventHandler(this.btnObrisiVozaca_Click);
            // 
            // btnDodajVozaca
            // 
            this.btnDodajVozaca.Image = global::lab4_OOP.Properties.Resources.add;
            this.btnDodajVozaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajVozaca.Location = new System.Drawing.Point(89, 966);
            this.btnDodajVozaca.Name = "btnDodajVozaca";
            this.btnDodajVozaca.Size = new System.Drawing.Size(340, 112);
            this.btnDodajVozaca.TabIndex = 5;
            this.btnDodajVozaca.Text = "Dodaj vozaca";
            this.btnDodajVozaca.UseVisualStyleBackColor = true;
            this.btnDodajVozaca.Click += new System.EventHandler(this.btnDodajVozaca_Click);
            // 
            // tmrTacnoVreme
            // 
            this.tmrTacnoVreme.Tick += new System.EventHandler(this.tmrTacnoVreme_Tick);
            // 
            // LFormListaVozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1966, 1138);
            this.Controls.Add(this.btnIzmeniVozaca);
            this.Controls.Add(this.btnObrisiVozaca);
            this.Controls.Add(this.btnDodajVozaca);
            this.Controls.Add(this.dgvListaVozaca);
            this.Controls.Add(this.cmbPodaci);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.lblListaVozaca);
            this.Controls.Add(this.lblTrenutnoVreme);
            this.Name = "LFormListaVozaca";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LFormListaVozaca_FormClosing);
            this.Load += new System.EventHandler(this.LFormListaVozaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrenutnoVreme;
        private System.Windows.Forms.Label lblListaVozaca;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox cmbPodaci;
        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Button btnDodajVozaca;
        private System.Windows.Forms.Button btnObrisiVozaca;
        private System.Windows.Forms.Button btnIzmeniVozaca;
        private System.Windows.Forms.Timer tmrTacnoVreme;
    }
}

