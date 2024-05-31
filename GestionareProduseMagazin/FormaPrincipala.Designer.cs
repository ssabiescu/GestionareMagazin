namespace GestionareProduseMagazin
{
    partial class FormaPrincipala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPrincipala));
            this.label1 = new System.Windows.Forms.Label();
            this.dGWProduse = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAdaugareInfo = new System.Windows.Forms.Button();
            this.btnAdaugareImg = new System.Windows.Forms.Button();
            this.btnVizualizareProdus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStergereProdus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(437, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online store management";
            this.label1.UseWaitCursor = true;
            // 
            // dGWProduse
            // 
            this.dGWProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWProduse.Location = new System.Drawing.Point(761, 204);
            this.dGWProduse.Name = "dGWProduse";
            this.dGWProduse.Size = new System.Drawing.Size(347, 157);
            this.dGWProduse.TabIndex = 1;
            this.dGWProduse.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cautare:";
            this.label2.UseWaitCursor = true;
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(825, 159);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(161, 20);
            this.txtCautare.TabIndex = 3;
            this.txtCautare.UseWaitCursor = true;
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCautare.Location = new System.Drawing.Point(992, 159);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(78, 22);
            this.btnCautare.TabIndex = 4;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.UseWaitCursor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdaugare.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugare.Location = new System.Drawing.Point(115, 251);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(171, 56);
            this.btnAdaugare.TabIndex = 5;
            this.btnAdaugare.Text = "Adaugare produs";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.UseWaitCursor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAdaugareInfo
            // 
            this.btnAdaugareInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdaugareInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareInfo.Location = new System.Drawing.Point(115, 313);
            this.btnAdaugareInfo.Name = "btnAdaugareInfo";
            this.btnAdaugareInfo.Size = new System.Drawing.Size(171, 52);
            this.btnAdaugareInfo.TabIndex = 6;
            this.btnAdaugareInfo.Text = "Adaugare Informatii Produs";
            this.btnAdaugareInfo.UseVisualStyleBackColor = false;
            this.btnAdaugareInfo.UseWaitCursor = true;
            this.btnAdaugareInfo.Click += new System.EventHandler(this.btnAdaugareInfo_Click);
            // 
            // btnAdaugareImg
            // 
            this.btnAdaugareImg.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAdaugareImg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareImg.Location = new System.Drawing.Point(115, 371);
            this.btnAdaugareImg.Name = "btnAdaugareImg";
            this.btnAdaugareImg.Size = new System.Drawing.Size(171, 56);
            this.btnAdaugareImg.TabIndex = 7;
            this.btnAdaugareImg.Text = "Adaugare Imagini Produs";
            this.btnAdaugareImg.UseVisualStyleBackColor = false;
            this.btnAdaugareImg.UseWaitCursor = true;
            this.btnAdaugareImg.Click += new System.EventHandler(this.btnAdaugareImg_Click);
            // 
            // btnVizualizareProdus
            // 
            this.btnVizualizareProdus.BackColor = System.Drawing.Color.Thistle;
            this.btnVizualizareProdus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVizualizareProdus.Location = new System.Drawing.Point(115, 433);
            this.btnVizualizareProdus.Name = "btnVizualizareProdus";
            this.btnVizualizareProdus.Size = new System.Drawing.Size(171, 47);
            this.btnVizualizareProdus.TabIndex = 8;
            this.btnVizualizareProdus.Text = "Vizualizare Produs";
            this.btnVizualizareProdus.UseVisualStyleBackColor = false;
            this.btnVizualizareProdus.UseWaitCursor = true;
            this.btnVizualizareProdus.Click += new System.EventHandler(this.btnVizualizareProdus_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Bisque;
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(964, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStergereProdus
            // 
            this.btnStergereProdus.BackColor = System.Drawing.Color.Cornsilk;
            this.btnStergereProdus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereProdus.Location = new System.Drawing.Point(115, 486);
            this.btnStergereProdus.Name = "btnStergereProdus";
            this.btnStergereProdus.Size = new System.Drawing.Size(171, 38);
            this.btnStergereProdus.TabIndex = 10;
            this.btnStergereProdus.Text = "Stergere Produs";
            this.btnStergereProdus.UseVisualStyleBackColor = false;
            this.btnStergereProdus.UseWaitCursor = true;
            this.btnStergereProdus.Click += new System.EventHandler(this.btnStergereProdus_Click);
            // 
            // FormaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1197, 642);
            this.Controls.Add(this.btnStergereProdus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVizualizareProdus);
            this.Controls.Add(this.btnAdaugareImg);
            this.Controls.Add(this.btnAdaugareInfo);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWProduse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaPrincipala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPrincipala";
            this.UseWaitCursor = true;
            this.Deactivate += new System.EventHandler(this.FormaPrincipala_Deactivate);
            this.Load += new System.EventHandler(this.FormaPrincipala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWProduse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAdaugareInfo;
        private System.Windows.Forms.Button btnAdaugareImg;
        private System.Windows.Forms.Button btnVizualizareProdus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStergereProdus;
    }
}