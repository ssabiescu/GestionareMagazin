namespace GestionareProduseMagazin
{
    partial class AdaugareImagini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareImagini));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtImagine = new System.Windows.Forms.TextBox();
            this.btnImagine = new System.Windows.Forms.Button();
            this.btnAdaugaImagine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(193, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID produs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(193, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Imagine:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(320, 196);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(176, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtImagine
            // 
            this.txtImagine.Location = new System.Drawing.Point(320, 263);
            this.txtImagine.Name = "txtImagine";
            this.txtImagine.Size = new System.Drawing.Size(176, 20);
            this.txtImagine.TabIndex = 4;
            // 
            // btnImagine
            // 
            this.btnImagine.Location = new System.Drawing.Point(505, 263);
            this.btnImagine.Name = "btnImagine";
            this.btnImagine.Size = new System.Drawing.Size(35, 20);
            this.btnImagine.TabIndex = 5;
            this.btnImagine.Text = "...";
            this.btnImagine.UseVisualStyleBackColor = true;
            this.btnImagine.Click += new System.EventHandler(this.btnImagine_Click);
            // 
            // btnAdaugaImagine
            // 
            this.btnAdaugaImagine.BackColor = System.Drawing.Color.Transparent;
            this.btnAdaugaImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaImagine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdaugaImagine.Location = new System.Drawing.Point(264, 423);
            this.btnAdaugaImagine.Name = "btnAdaugaImagine";
            this.btnAdaugaImagine.Size = new System.Drawing.Size(263, 58);
            this.btnAdaugaImagine.TabIndex = 6;
            this.btnAdaugaImagine.Text = "Adaugare Imagine";
            this.btnAdaugaImagine.UseVisualStyleBackColor = false;
            this.btnAdaugaImagine.Click += new System.EventHandler(this.btnAdaugaImagine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(243, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adaugare imagini produse";
            this.label4.UseWaitCursor = true;
            // 
            // AdaugareImagini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 532);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdaugaImagine);
            this.Controls.Add(this.btnImagine);
            this.Controls.Add(this.txtImagine);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AdaugareImagini";
            this.Text = "AdaugareImagini";
            this.Load += new System.EventHandler(this.AdaugareImagini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtImagine;
        private System.Windows.Forms.Button btnImagine;
        private System.Windows.Forms.Button btnAdaugaImagine;
        private System.Windows.Forms.Label label4;
    }
}