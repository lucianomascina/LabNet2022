
namespace Lab.EF.UI.Views.Linq
{
    partial class FormEJERCICIO1
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCOMPANYNAME = new System.Windows.Forms.Label();
            this.buttonSEARCH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCONTACTNAME = new System.Windows.Forms.Label();
            this.labelADDRESS = new System.Windows.Forms.Label();
            this.labelCITY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(158, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COMPANY NAME:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCOMPANYNAME
            // 
            this.labelCOMPANYNAME.AutoSize = true;
            this.labelCOMPANYNAME.Location = new System.Drawing.Point(155, 102);
            this.labelCOMPANYNAME.Name = "labelCOMPANYNAME";
            this.labelCOMPANYNAME.Size = new System.Drawing.Size(0, 13);
            this.labelCOMPANYNAME.TabIndex = 3;
            // 
            // buttonSEARCH
            // 
            this.buttonSEARCH.Location = new System.Drawing.Point(132, 329);
            this.buttonSEARCH.Name = "buttonSEARCH";
            this.buttonSEARCH.Size = new System.Drawing.Size(83, 38);
            this.buttonSEARCH.TabIndex = 4;
            this.buttonSEARCH.Text = "SEARCH";
            this.buttonSEARCH.UseVisualStyleBackColor = true;
            this.buttonSEARCH.Click += new System.EventHandler(this.buttonSEARCH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONTACT NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ADDRESS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CITY:";
            // 
            // labelCONTACTNAME
            // 
            this.labelCONTACTNAME.AutoSize = true;
            this.labelCONTACTNAME.Location = new System.Drawing.Point(158, 145);
            this.labelCONTACTNAME.Name = "labelCONTACTNAME";
            this.labelCONTACTNAME.Size = new System.Drawing.Size(0, 13);
            this.labelCONTACTNAME.TabIndex = 8;
            // 
            // labelADDRESS
            // 
            this.labelADDRESS.AutoSize = true;
            this.labelADDRESS.Location = new System.Drawing.Point(158, 192);
            this.labelADDRESS.Name = "labelADDRESS";
            this.labelADDRESS.Size = new System.Drawing.Size(0, 13);
            this.labelADDRESS.TabIndex = 9;
            // 
            // labelCITY
            // 
            this.labelCITY.AutoSize = true;
            this.labelCITY.Location = new System.Drawing.Point(158, 233);
            this.labelCITY.Name = "labelCITY";
            this.labelCITY.Size = new System.Drawing.Size(0, 13);
            this.labelCITY.TabIndex = 10;
            // 
            // FormEJERCICIO1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.labelCITY);
            this.Controls.Add(this.labelADDRESS);
            this.Controls.Add(this.labelCONTACTNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSEARCH);
            this.Controls.Add(this.labelCOMPANYNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "FormEJERCICIO1";
            this.Text = "FormEJERCICIO1";
            this.Load += new System.EventHandler(this.FormEJERCICIO1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCOMPANYNAME;
        private System.Windows.Forms.Button buttonSEARCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCONTACTNAME;
        private System.Windows.Forms.Label labelADDRESS;
        private System.Windows.Forms.Label labelCITY;
    }
}