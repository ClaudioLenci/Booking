﻿namespace Cliente
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNascita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpGiorno = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDurata = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrenota = new System.Windows.Forms.Button();
            this.cmbOrario = new System.Windows.Forms.ComboBox();
            this.rtbAltro = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(153, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // dtpNascita
            // 
            this.dtpNascita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascita.Location = new System.Drawing.Point(153, 81);
            this.dtpNascita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNascita.Name = "dtpNascita";
            this.dtpNascita.Size = new System.Drawing.Size(114, 29);
            this.dtpNascita.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data nascita";
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Location = new System.Drawing.Point(153, 136);
            this.cmbTipologia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(194, 32);
            this.cmbTipologia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipologia";
            // 
            // dtpGiorno
            // 
            this.dtpGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGiorno.Location = new System.Drawing.Point(153, 243);
            this.dtpGiorno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpGiorno.Name = "dtpGiorno";
            this.dtpGiorno.Size = new System.Drawing.Size(114, 29);
            this.dtpGiorno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giorno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Orario";
            // 
            // nudDurata
            // 
            this.nudDurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDurata.Location = new System.Drawing.Point(153, 191);
            this.nudDurata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDurata.Name = "nudDurata";
            this.nudDurata.Size = new System.Drawing.Size(58, 29);
            this.nudDurata.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Durata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 301);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Altro";
            // 
            // btnPrenota
            // 
            this.btnPrenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenota.Location = new System.Drawing.Point(126, 430);
            this.btnPrenota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(247, 71);
            this.btnPrenota.TabIndex = 14;
            this.btnPrenota.Text = "PRENOTA";
            this.btnPrenota.UseVisualStyleBackColor = true;
            // 
            // cmbOrario
            // 
            this.cmbOrario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrario.FormattingEnabled = true;
            this.cmbOrario.Location = new System.Drawing.Point(353, 244);
            this.cmbOrario.Name = "cmbOrario";
            this.cmbOrario.Size = new System.Drawing.Size(116, 32);
            this.cmbOrario.TabIndex = 15;
            // 
            // rtbAltro
            // 
            this.rtbAltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAltro.Location = new System.Drawing.Point(153, 298);
            this.rtbAltro.Name = "rtbAltro";
            this.rtbAltro.Size = new System.Drawing.Size(316, 81);
            this.rtbAltro.TabIndex = 16;
            this.rtbAltro.Text = "";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 512);
            this.Controls.Add(this.rtbAltro);
            this.Controls.Add(this.cmbOrario);
            this.Controls.Add(this.btnPrenota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudDurata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGiorno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipologia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNascita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.Text = "Prenota";
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNascita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipologia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpGiorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDurata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPrenota;
        private System.Windows.Forms.ComboBox cmbOrario;
        private System.Windows.Forms.RichTextBox rtbAltro;
    }
}

