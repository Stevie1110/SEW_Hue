namespace _11_HÜ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.txt_Vorname = new System.Windows.Forms.TextBox();
            this.txt_Nachname = new System.Windows.Forms.TextBox();
            this.btn_Hinzufügen = new System.Windows.Forms.Button();
            this.btn_Löschen = new System.Windows.Forms.Button();
            this.txt_Liste = new System.Windows.Forms.TextBox();
            this.lbl_Anwesenheit = new System.Windows.Forms.Label();
            this.lbl_Anzahl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Vorname.Location = new System.Drawing.Point(66, 51);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(76, 21);
            this.lbl_Vorname.TabIndex = 0;
            this.lbl_Vorname.Text = "Vorname:";
            this.lbl_Vorname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nachname.Location = new System.Drawing.Point(66, 103);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(88, 21);
            this.lbl_Nachname.TabIndex = 1;
            this.lbl_Nachname.Text = "Nachname:";
            // 
            // txt_Vorname
            // 
            this.txt_Vorname.Location = new System.Drawing.Point(228, 51);
            this.txt_Vorname.Name = "txt_Vorname";
            this.txt_Vorname.Size = new System.Drawing.Size(148, 23);
            this.txt_Vorname.TabIndex = 2;
            // 
            // txt_Nachname
            // 
            this.txt_Nachname.Location = new System.Drawing.Point(228, 100);
            this.txt_Nachname.Name = "txt_Nachname";
            this.txt_Nachname.Size = new System.Drawing.Size(148, 23);
            this.txt_Nachname.TabIndex = 3;
            // 
            // btn_Hinzufügen
            // 
            this.btn_Hinzufügen.Location = new System.Drawing.Point(282, 171);
            this.btn_Hinzufügen.Name = "btn_Hinzufügen";
            this.btn_Hinzufügen.Size = new System.Drawing.Size(94, 23);
            this.btn_Hinzufügen.TabIndex = 4;
            this.btn_Hinzufügen.Text = "Hinzufügen";
            this.btn_Hinzufügen.UseVisualStyleBackColor = true;
            this.btn_Hinzufügen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Löschen
            // 
            this.btn_Löschen.Location = new System.Drawing.Point(282, 229);
            this.btn_Löschen.Name = "btn_Löschen";
            this.btn_Löschen.Size = new System.Drawing.Size(93, 23);
            this.btn_Löschen.TabIndex = 5;
            this.btn_Löschen.Text = "Liste löschen";
            this.btn_Löschen.UseVisualStyleBackColor = true;
            this.btn_Löschen.Click += new System.EventHandler(this.btn_Löschen_Click);
            // 
            // txt_Liste
            // 
            this.txt_Liste.AcceptsReturn = true;
            this.txt_Liste.Location = new System.Drawing.Point(493, 50);
            this.txt_Liste.Multiline = true;
            this.txt_Liste.Name = "txt_Liste";
            this.txt_Liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Liste.Size = new System.Drawing.Size(179, 202);
            this.txt_Liste.TabIndex = 6;
            // 
            // lbl_Anwesenheit
            // 
            this.lbl_Anwesenheit.AutoSize = true;
            this.lbl_Anwesenheit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Anwesenheit.Location = new System.Drawing.Point(493, 21);
            this.lbl_Anwesenheit.Name = "lbl_Anwesenheit";
            this.lbl_Anwesenheit.Size = new System.Drawing.Size(161, 21);
            this.lbl_Anwesenheit.TabIndex = 7;
            this.lbl_Anwesenheit.Text = "Anwesende Personen:";
            // 
            // lbl_Anzahl
            // 
            this.lbl_Anzahl.AutoSize = true;
            this.lbl_Anzahl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Anzahl.Location = new System.Drawing.Point(228, 345);
            this.lbl_Anzahl.Name = "lbl_Anzahl";
            this.lbl_Anzahl.Size = new System.Drawing.Size(159, 21);
            this.lbl_Anzahl.TabIndex = 8;
            this.lbl_Anzahl.Text = "x Personen anwesend";
            this.lbl_Anzahl.Click += new System.EventHandler(this.lbl_Anzahl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 427);
            this.Controls.Add(this.lbl_Anzahl);
            this.Controls.Add(this.lbl_Anwesenheit);
            this.Controls.Add(this.txt_Liste);
            this.Controls.Add(this.btn_Löschen);
            this.Controls.Add(this.btn_Hinzufügen);
            this.Controls.Add(this.txt_Nachname);
            this.Controls.Add(this.txt_Vorname);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.lbl_Vorname);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.TextBox txt_Vorname;
        private System.Windows.Forms.TextBox txt_Nachname;
        private System.Windows.Forms.Button btn_Hinzufügen;
        private System.Windows.Forms.Button btn_Löschen;
        private System.Windows.Forms.TextBox txt_Liste;
        private System.Windows.Forms.Label lbl_Anwesenheit;
        private System.Windows.Forms.Label lbl_Anzahl;
    }
}

