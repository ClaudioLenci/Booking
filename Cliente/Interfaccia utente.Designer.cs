namespace Cliente
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datatimeNascita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datatimeOrario = new System.Windows.Forms.DateTimePicker();
            this.datatimeGiorno = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumUpDownDurata = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nascita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Giorno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inizio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Altro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(126, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(111, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtAltro
            // 
            this.txtAltro.Location = new System.Drawing.Point(126, 375);
            this.txtAltro.Name = "txtAltro";
            this.txtAltro.Size = new System.Drawing.Size(111, 22);
            this.txtAltro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // datatimeNascita
            // 
            this.datatimeNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datatimeNascita.Location = new System.Drawing.Point(126, 104);
            this.datatimeNascita.Name = "datatimeNascita";
            this.datatimeNascita.Size = new System.Drawing.Size(111, 22);
            this.datatimeNascita.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data nascita";
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Location = new System.Drawing.Point(126, 162);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(111, 24);
            this.cmbTipologia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipologia";
            // 
            // datatimeOrario
            // 
            this.datatimeOrario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datatimeOrario.Location = new System.Drawing.Point(327, 233);
            this.datatimeOrario.Name = "datatimeOrario";
            this.datatimeOrario.Size = new System.Drawing.Size(113, 22);
            this.datatimeOrario.TabIndex = 7;
            // 
            // datatimeGiorno
            // 
            this.datatimeGiorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datatimeGiorno.Location = new System.Drawing.Point(126, 233);
            this.datatimeGiorno.Name = "datatimeGiorno";
            this.datatimeGiorno.Size = new System.Drawing.Size(111, 22);
            this.datatimeGiorno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giorno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Orario";
            // 
            // NumUpDownDurata
            // 
            this.NumUpDownDurata.Location = new System.Drawing.Point(126, 302);
            this.NumUpDownDurata.Name = "NumUpDownDurata";
            this.NumUpDownDurata.Size = new System.Drawing.Size(111, 22);
            this.NumUpDownDurata.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Altro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aggiungi prenotazione";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstCliente
            // 
            this.lstCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome,
            this.Nascita,
            this.Tipologia,
            this.Giorno,
            this.Inizio,
            this.Durata,
            this.Altro});
            this.lstCliente.GridLines = true;
            this.lstCliente.HideSelection = false;
            this.lstCliente.Location = new System.Drawing.Point(524, 12);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(810, 536);
            this.lstCliente.TabIndex = 15;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            this.lstCliente.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Nascita
            // 
            this.Nascita.Text = "Nascita";
            // 
            // Tipologia
            // 
            this.Tipologia.Text = "Tipologia";
            this.Tipologia.Width = 79;
            // 
            // Giorno
            // 
            this.Giorno.Text = "Giorno";
            this.Giorno.Width = 100;
            // 
            // Inizio
            // 
            this.Inizio.DisplayIndex = 5;
            this.Inizio.Text = "Inizio";
            this.Inizio.Width = 74;
            // 
            // Durata
            // 
            this.Durata.DisplayIndex = 6;
            this.Durata.Text = "Durata";
            this.Durata.Width = 83;
            // 
            // Altro
            // 
            this.Altro.Text = "Altro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 553);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumUpDownDurata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datatimeGiorno);
            this.Controls.Add(this.datatimeOrario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipologia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datatimeNascita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltro);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datatimeNascita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipologia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datatimeOrario;
        private System.Windows.Forms.DateTimePicker datatimeGiorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumUpDownDurata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Nascita;
        private System.Windows.Forms.ColumnHeader Tipologia;
        private System.Windows.Forms.ColumnHeader Giorno;
        private System.Windows.Forms.ColumnHeader Inizio;
        private System.Windows.Forms.ColumnHeader Durata;
        private System.Windows.Forms.ColumnHeader Altro;
    }
}

