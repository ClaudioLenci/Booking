namespace Dottore
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.dtpGiorno = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDurata = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbAltro = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipologia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpGiorno
            // 
            resources.ApplyResources(this.dtpGiorno, "dtpGiorno");
            this.dtpGiorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGiorno.Name = "dtpGiorno";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cmbOrario
            // 
            resources.ApplyResources(this.cmbOrario, "cmbOrario");
            this.cmbOrario.FormattingEnabled = true;
            this.cmbOrario.Name = "cmbOrario";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // nudDurata
            // 
            resources.ApplyResources(this.nudDurata, "nudDurata");
            this.nudDurata.Name = "nudDurata";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // rtbAltro
            // 
            resources.ApplyResources(this.rtbAltro, "rtbAltro");
            this.rtbAltro.Name = "rtbAltro";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnModifica
            // 
            resources.ApplyResources(this.btnModifica, "btnModifica");
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnCancella
            // 
            resources.ApplyResources(this.btnCancella, "btnCancella");
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.UseVisualStyleBackColor = true;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.Name = "lblNome";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblData
            // 
            resources.ApplyResources(this.lblData, "lblData");
            this.lblData.Name = "lblData";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblTipologia
            // 
            resources.ApplyResources(this.lblTipologia, "lblTipologia");
            this.lblTipologia.Name = "lblTipologia";
            // 
            // Editor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTipologia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbAltro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudDurata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOrario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpGiorno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGiorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOrario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDurata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbAltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipologia;
    }
}