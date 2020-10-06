namespace Ko_papir_ollo
{
    partial class FrmFo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblJatekos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSzamitogep = new System.Windows.Forms.Label();
            this.pbJatekos = new System.Windows.Forms.PictureBox();
            this.pbSzamitogep = new System.Windows.Forms.PictureBox();
            this.lblGyoztes = new System.Windows.Forms.Label();
            this.btnKo = new System.Windows.Forms.Button();
            this.btnPapir = new System.Windows.Forms.Button();
            this.btnOllo = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnSzabaly = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbJatekos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSzamitogep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos: ";
            // 
            // lblJatekos
            // 
            this.lblJatekos.AutoSize = true;
            this.lblJatekos.Location = new System.Drawing.Point(124, 0);
            this.lblJatekos.Name = "lblJatekos";
            this.lblJatekos.Size = new System.Drawing.Size(51, 20);
            this.lblJatekos.TabIndex = 1;
            this.lblJatekos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Számítógép: ";
            // 
            // lblSzamitogep
            // 
            this.lblSzamitogep.AutoSize = true;
            this.lblSzamitogep.Location = new System.Drawing.Point(478, 3);
            this.lblSzamitogep.Name = "lblSzamitogep";
            this.lblSzamitogep.Size = new System.Drawing.Size(51, 20);
            this.lblSzamitogep.TabIndex = 3;
            this.lblSzamitogep.Text = "label3";
            // 
            // pbJatekos
            // 
            this.pbJatekos.Location = new System.Drawing.Point(30, 50);
            this.pbJatekos.Name = "pbJatekos";
            this.pbJatekos.Size = new System.Drawing.Size(200, 200);
            this.pbJatekos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJatekos.TabIndex = 4;
            this.pbJatekos.TabStop = false;
            // 
            // pbSzamitogep
            // 
            this.pbSzamitogep.Location = new System.Drawing.Point(352, 50);
            this.pbSzamitogep.Name = "pbSzamitogep";
            this.pbSzamitogep.Size = new System.Drawing.Size(200, 200);
            this.pbSzamitogep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSzamitogep.TabIndex = 5;
            this.pbSzamitogep.TabStop = false;
            // 
            // lblGyoztes
            // 
            this.lblGyoztes.AutoSize = true;
            this.lblGyoztes.Location = new System.Drawing.Point(264, 246);
            this.lblGyoztes.Name = "lblGyoztes";
            this.lblGyoztes.Size = new System.Drawing.Size(51, 20);
            this.lblGyoztes.TabIndex = 6;
            this.lblGyoztes.Text = "label3";
            // 
            // btnKo
            // 
            this.btnKo.Location = new System.Drawing.Point(73, 5);
            this.btnKo.Name = "btnKo";
            this.btnKo.Size = new System.Drawing.Size(75, 32);
            this.btnKo.TabIndex = 7;
            this.btnKo.Text = "Kő";
            this.btnKo.UseVisualStyleBackColor = true;
            this.btnKo.Click += new System.EventHandler(this.btnKo_Click);
            // 
            // btnPapir
            // 
            this.btnPapir.Location = new System.Drawing.Point(249, 5);
            this.btnPapir.Name = "btnPapir";
            this.btnPapir.Size = new System.Drawing.Size(75, 32);
            this.btnPapir.TabIndex = 8;
            this.btnPapir.Text = "Papír";
            this.btnPapir.UseVisualStyleBackColor = true;
            this.btnPapir.Click += new System.EventHandler(this.btnPapir_Click);
            // 
            // btnOllo
            // 
            this.btnOllo.Location = new System.Drawing.Point(418, 5);
            this.btnOllo.Name = "btnOllo";
            this.btnOllo.Size = new System.Drawing.Size(75, 32);
            this.btnOllo.TabIndex = 9;
            this.btnOllo.Text = "Olló";
            this.btnOllo.UseVisualStyleBackColor = true;
            this.btnOllo.Click += new System.EventHandler(this.btnOllo_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(27, 409);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(121, 40);
            this.btnKilepes.TabIndex = 10;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnSzabaly
            // 
            this.btnSzabaly.Location = new System.Drawing.Point(237, 409);
            this.btnSzabaly.Name = "btnSzabaly";
            this.btnSzabaly.Size = new System.Drawing.Size(121, 40);
            this.btnSzabaly.TabIndex = 11;
            this.btnSzabaly.Text = "Szabályok";
            this.btnSzabaly.UseVisualStyleBackColor = true;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(436, 409);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(121, 40);
            this.btnUj.TabIndex = 12;
            this.btnUj.Text = "Új játék";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pbSzamitogep);
            this.panel1.Controls.Add(this.pbJatekos);
            this.panel1.Controls.Add(this.lblSzamitogep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblJatekos);
            this.panel1.Controls.Add(this.lblGyoztes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 282);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnOllo);
            this.panel2.Controls.Add(this.btnPapir);
            this.panel2.Controls.Add(this.btnKo);
            this.panel2.Location = new System.Drawing.Point(9, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 48);
            this.panel2.TabIndex = 14;
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnSzabaly);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő,papír,olló";
            this.Load += new System.EventHandler(this.FrmFo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJatekos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSzamitogep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJatekos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSzamitogep;
        private System.Windows.Forms.PictureBox pbJatekos;
        private System.Windows.Forms.PictureBox pbSzamitogep;
        private System.Windows.Forms.Label lblGyoztes;
        private System.Windows.Forms.Button btnKo;
        private System.Windows.Forms.Button btnPapir;
        private System.Windows.Forms.Button btnOllo;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnSzabaly;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

