namespace calculator
{
    partial class Form1
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lstNote = new System.Windows.Forms.ListBox();
            this.grpTeza = new System.Windows.Forms.GroupBox();
            this.radFaraTeza = new System.Windows.Forms.RadioButton();
            this.radCuTeza = new System.Windows.Forms.RadioButton();
            this.pnlTeza = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeza = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMedie = new System.Windows.Forms.Label();
            this.grpTeza.SuspendLayout();
            this.pnlTeza.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(80, 72);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(215, 22);
            this.txtNote.TabIndex = 0;
            // 
            // lstNote
            // 
            this.lstNote.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNote.FormattingEnabled = true;
            this.lstNote.ItemHeight = 22;
            this.lstNote.Location = new System.Drawing.Point(94, 100);
            this.lstNote.Name = "lstNote";
            this.lstNote.Size = new System.Drawing.Size(190, 202);
            this.lstNote.TabIndex = 1;
            // 
            // grpTeza
            // 
            this.grpTeza.Controls.Add(this.radCuTeza);
            this.grpTeza.Controls.Add(this.radFaraTeza);
            this.grpTeza.Location = new System.Drawing.Point(322, 72);
            this.grpTeza.Name = "grpTeza";
            this.grpTeza.Size = new System.Drawing.Size(200, 141);
            this.grpTeza.TabIndex = 2;
            this.grpTeza.TabStop = false;
            // 
            // radFaraTeza
            // 
            this.radFaraTeza.AutoSize = true;
            this.radFaraTeza.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFaraTeza.Location = new System.Drawing.Point(35, 99);
            this.radFaraTeza.Name = "radFaraTeza";
            this.radFaraTeza.Size = new System.Drawing.Size(88, 23);
            this.radFaraTeza.TabIndex = 0;
            this.radFaraTeza.TabStop = true;
            this.radFaraTeza.Text = "Fara teza";
            this.radFaraTeza.UseVisualStyleBackColor = true;
            this.radFaraTeza.CheckedChanged += new System.EventHandler(this.radFaraTeza_CheckedChanged);
            // 
            // radCuTeza
            // 
            this.radCuTeza.AutoSize = true;
            this.radCuTeza.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCuTeza.Location = new System.Drawing.Point(35, 53);
            this.radCuTeza.Name = "radCuTeza";
            this.radCuTeza.Size = new System.Drawing.Size(76, 23);
            this.radCuTeza.TabIndex = 1;
            this.radCuTeza.TabStop = true;
            this.radCuTeza.Text = "Cu teza";
            this.radCuTeza.UseVisualStyleBackColor = true;
            this.radCuTeza.CheckedChanged += new System.EventHandler(this.radCuTeza_CheckedChanged);
            // 
            // pnlTeza
            // 
            this.pnlTeza.Controls.Add(this.txtTeza);
            this.pnlTeza.Controls.Add(this.label1);
            this.pnlTeza.Location = new System.Drawing.Point(322, 219);
            this.pnlTeza.Name = "pnlTeza";
            this.pnlTeza.Size = new System.Drawing.Size(200, 198);
            this.pnlTeza.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota in teza:";
            // 
            // txtTeza
            // 
            this.txtTeza.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeza.Location = new System.Drawing.Point(115, 92);
            this.txtTeza.Name = "txtTeza";
            this.txtTeza.Size = new System.Drawing.Size(62, 22);
            this.txtTeza.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(543, 110);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(164, 38);
            this.btnAdauga.TabIndex = 4;
            this.btnAdauga.Text = "Adauga nota!";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(543, 183);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(164, 30);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge o nota!";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeaza.Location = new System.Drawing.Point(543, 250);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(164, 28);
            this.btnCalculeaza.TabIndex = 6;
            this.btnCalculeaza.Text = "Calculeaza media!";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(543, 311);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 32);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reseteaza lista!";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMedie
            // 
            this.lblMedie.AutoSize = true;
            this.lblMedie.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedie.Location = new System.Drawing.Point(150, 323);
            this.lblMedie.Name = "lblMedie";
            this.lblMedie.Size = new System.Drawing.Size(78, 28);
            this.lblMedie.TabIndex = 8;
            this.lblMedie.Text = "Media";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdauga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 633);
            this.Controls.Add(this.lblMedie);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculeaza);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.pnlTeza);
            this.Controls.Add(this.grpTeza);
            this.Controls.Add(this.lstNote);
            this.Controls.Add(this.txtNote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTeza.ResumeLayout(false);
            this.grpTeza.PerformLayout();
            this.pnlTeza.ResumeLayout(false);
            this.pnlTeza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListBox lstNote;
        private System.Windows.Forms.GroupBox grpTeza;
        private System.Windows.Forms.RadioButton radCuTeza;
        private System.Windows.Forms.RadioButton radFaraTeza;
        private System.Windows.Forms.Panel pnlTeza;
        private System.Windows.Forms.TextBox txtTeza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMedie;
    }
}

