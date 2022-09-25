
namespace Lab.EF.UI
{
    partial class FormDeleteEmployee
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
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelLASTNAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFIRSTNAME = new System.Windows.Forms.Label();
            this.labelBIRTHDATE = new System.Windows.Forms.Label();
            this.labelHIREDATE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(106, 320);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(104, 37);
            this.buttonBorrar.TabIndex = 1;
            this.buttonBorrar.Text = "DELETE";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(146, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 2;
            // 
            // labelLASTNAME
            // 
            this.labelLASTNAME.AutoSize = true;
            this.labelLASTNAME.Location = new System.Drawing.Point(146, 92);
            this.labelLASTNAME.Name = "labelLASTNAME";
            this.labelLASTNAME.Size = new System.Drawing.Size(0, 13);
            this.labelLASTNAME.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "LAST NAME: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "FIRST NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BIRTH DATE: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "HIRE DATE: ";
            // 
            // labelFIRSTNAME
            // 
            this.labelFIRSTNAME.AutoSize = true;
            this.labelFIRSTNAME.Location = new System.Drawing.Point(149, 127);
            this.labelFIRSTNAME.Name = "labelFIRSTNAME";
            this.labelFIRSTNAME.Size = new System.Drawing.Size(0, 13);
            this.labelFIRSTNAME.TabIndex = 17;
            // 
            // labelBIRTHDATE
            // 
            this.labelBIRTHDATE.AutoSize = true;
            this.labelBIRTHDATE.Location = new System.Drawing.Point(149, 170);
            this.labelBIRTHDATE.Name = "labelBIRTHDATE";
            this.labelBIRTHDATE.Size = new System.Drawing.Size(0, 13);
            this.labelBIRTHDATE.TabIndex = 18;
            // 
            // labelHIREDATE
            // 
            this.labelHIREDATE.AutoSize = true;
            this.labelHIREDATE.Location = new System.Drawing.Point(149, 212);
            this.labelHIREDATE.Name = "labelHIREDATE";
            this.labelHIREDATE.Size = new System.Drawing.Size(0, 13);
            this.labelHIREDATE.TabIndex = 19;
            // 
            // FormDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 430);
            this.Controls.Add(this.labelHIREDATE);
            this.Controls.Add(this.labelBIRTHDATE);
            this.Controls.Add(this.labelFIRSTNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLASTNAME);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonBorrar);
            this.Name = "FormDeleteEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBorrarEmpleado";
            this.Load += new System.EventHandler(this.FormDeleteEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelLASTNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFIRSTNAME;
        private System.Windows.Forms.Label labelBIRTHDATE;
        private System.Windows.Forms.Label labelHIREDATE;
    }
}