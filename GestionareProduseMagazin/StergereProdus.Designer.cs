using System;
using System.Windows.Forms;

namespace GestionareProduseMagazin
{
    partial class Stergere
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTara = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTara
            // 
            this.txtTara.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTara.Location = new System.Drawing.Point(225, 105);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(195, 22);
            this.txtTara.TabIndex = 1;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSterge.ForeColor = System.Drawing.Color.White;
            this.btnSterge.Location = new System.Drawing.Point(180, 179);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 40);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(20, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(360, 30);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTara
            // 
            this.lblTara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTara.Location = new System.Drawing.Point(12, 75);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(189, 55);
            this.lblTara.TabIndex = 0;
            this.lblTara.Text = "Introdu id-ul produsului pe care doresti sa il stergi:";
            this.lblTara.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stergere produs";
            // 
            // Stergere
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Stergere";
            this.Text = "Ștergere Produs";
            this.Load += new System.EventHandler(this.Stergere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblResult;
        private Label lblTara;
        private Label label1;
    }
}