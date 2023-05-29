namespace Dottore
{
    partial class Dottore
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPrenotazioni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstPrenotazioni
            // 
            this.lstPrenotazioni.BackColor = System.Drawing.SystemColors.Window;
            this.lstPrenotazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPrenotazioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader4});
            this.lstPrenotazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPrenotazioni.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrenotazioni.ForeColor = System.Drawing.Color.Black;
            this.lstPrenotazioni.FullRowSelect = true;
            this.lstPrenotazioni.GridLines = true;
            this.lstPrenotazioni.HideSelection = false;
            this.lstPrenotazioni.Location = new System.Drawing.Point(0, 0);
            this.lstPrenotazioni.Margin = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.lstPrenotazioni.MultiSelect = false;
            this.lstPrenotazioni.Name = "lstPrenotazioni";
            this.lstPrenotazioni.Size = new System.Drawing.Size(650, 506);
            this.lstPrenotazioni.TabIndex = 0;
            this.lstPrenotazioni.UseCompatibleStateImageBehavior = false;
            this.lstPrenotazioni.View = System.Windows.Forms.View.Details;
            this.lstPrenotazioni.DoubleClick += new System.EventHandler(this.lstPrenotazioni_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 25;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data di nascita";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 25;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipologia";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 25;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giorno inizio";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 25;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ora inizio";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 25;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Durata";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 25;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Altre info";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 25;
            // 
            // Dottore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 506);
            this.Controls.Add(this.lstPrenotazioni);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dottore";
            this.Text = "Dottore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dottore_FormClosing);
            this.Load += new System.EventHandler(this.Dottore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPrenotazioni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

