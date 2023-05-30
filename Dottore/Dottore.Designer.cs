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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpInizio = new System.Windows.Forms.DateTimePicker();
            this.dtpFine = new System.Windows.Forms.DateTimePicker();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblInizio = new System.Windows.Forms.Label();
            this.cbInizio = new System.Windows.Forms.CheckBox();
            this.cbFine = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.SetColumnSpan(this.lstPrenotazioni, 6);
            this.lstPrenotazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPrenotazioni.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrenotazioni.ForeColor = System.Drawing.Color.Black;
            this.lstPrenotazioni.FullRowSelect = true;
            this.lstPrenotazioni.GridLines = true;
            this.lstPrenotazioni.HideSelection = false;
            this.lstPrenotazioni.Location = new System.Drawing.Point(4, 44);
            this.lstPrenotazioni.Margin = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.lstPrenotazioni.MultiSelect = false;
            this.lstPrenotazioni.Name = "lstPrenotazioni";
            this.lstPrenotazioni.Size = new System.Drawing.Size(778, 582);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lstPrenotazioni, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpInizio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFine, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFine, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbInizio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbFine, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInizio, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 628);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtpInizio
            // 
            this.dtpInizio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInizio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInizio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInizio.Location = new System.Drawing.Point(43, 3);
            this.dtpInizio.Name = "dtpInizio";
            this.dtpInizio.Size = new System.Drawing.Size(144, 29);
            this.dtpInizio.TabIndex = 1;
            this.dtpInizio.ValueChanged += new System.EventHandler(this.dtpInizio_ValueChanged);
            // 
            // dtpFine
            // 
            this.dtpFine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFine.Location = new System.Drawing.Point(430, 3);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(144, 29);
            this.dtpFine.TabIndex = 2;
            this.dtpFine.ValueChanged += new System.EventHandler(this.dtpFine_ValueChanged);
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFine.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(400, 0);
            this.lblFine.Name = "lblFine";
            this.lblFine.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblFine.Size = new System.Drawing.Size(24, 28);
            this.lblFine.TabIndex = 3;
            this.lblFine.Text = "A";
            // 
            // lblInizio
            // 
            this.lblInizio.AutoSize = true;
            this.lblInizio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInizio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInizio.Location = new System.Drawing.Point(3, 0);
            this.lblInizio.Name = "lblInizio";
            this.lblInizio.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblInizio.Size = new System.Drawing.Size(34, 28);
            this.lblInizio.TabIndex = 4;
            this.lblInizio.Text = "Da";
            // 
            // cbInizio
            // 
            this.cbInizio.AutoSize = true;
            this.cbInizio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInizio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInizio.Location = new System.Drawing.Point(193, 3);
            this.cbInizio.Name = "cbInizio";
            this.cbInizio.Size = new System.Drawing.Size(201, 34);
            this.cbInizio.TabIndex = 5;
            this.cbInizio.Text = "Attivo";
            this.cbInizio.UseVisualStyleBackColor = true;
            this.cbInizio.CheckedChanged += new System.EventHandler(this.cbInizio_CheckedChanged);
            // 
            // cbFine
            // 
            this.cbFine.AutoSize = true;
            this.cbFine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbFine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFine.Location = new System.Drawing.Point(580, 3);
            this.cbFine.Name = "cbFine";
            this.cbFine.Size = new System.Drawing.Size(201, 34);
            this.cbFine.TabIndex = 6;
            this.cbFine.Text = "Attivo";
            this.cbFine.UseVisualStyleBackColor = true;
            this.cbFine.CheckedChanged += new System.EventHandler(this.cbFine_CheckedChanged);
            // 
            // Dottore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dottore";
            this.Text = "Dottore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dottore_FormClosing);
            this.Load += new System.EventHandler(this.Dottore_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtpInizio;
        private System.Windows.Forms.DateTimePicker dtpFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.CheckBox cbInizio;
        private System.Windows.Forms.CheckBox cbFine;
        private System.Windows.Forms.Label lblInizio;
    }
}

