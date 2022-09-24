
namespace Lab.EF.UI
{
    partial class FormMenu
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
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonCATEGORIAS = new System.Windows.Forms.Button();
            this.buttonCUSTOMERDEMOGRAPHICS = new System.Windows.Forms.Button();
            this.buttonORDERDETAILS = new System.Windows.Forms.Button();
            this.buttonORDERS = new System.Windows.Forms.Button();
            this.buttonSHIPPERS = new System.Windows.Forms.Button();
            this.buttonSUPPLIERS = new System.Windows.Forms.Button();
            this.buttonTERRITORIES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.Location = new System.Drawing.Point(39, 36);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(139, 39);
            this.buttonEmpleados.TabIndex = 0;
            this.buttonEmpleados.Text = "EMPLEADOS";
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(232, 36);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(139, 39);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "CLIENTES";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonCATEGORIAS
            // 
            this.buttonCATEGORIAS.Location = new System.Drawing.Point(39, 123);
            this.buttonCATEGORIAS.Name = "buttonCATEGORIAS";
            this.buttonCATEGORIAS.Size = new System.Drawing.Size(139, 35);
            this.buttonCATEGORIAS.TabIndex = 2;
            this.buttonCATEGORIAS.Text = "CATEGORIAS";
            this.buttonCATEGORIAS.UseVisualStyleBackColor = true;
            // 
            // buttonCUSTOMERDEMOGRAPHICS
            // 
            this.buttonCUSTOMERDEMOGRAPHICS.Location = new System.Drawing.Point(232, 123);
            this.buttonCUSTOMERDEMOGRAPHICS.Name = "buttonCUSTOMERDEMOGRAPHICS";
            this.buttonCUSTOMERDEMOGRAPHICS.Size = new System.Drawing.Size(139, 38);
            this.buttonCUSTOMERDEMOGRAPHICS.TabIndex = 3;
            this.buttonCUSTOMERDEMOGRAPHICS.Text = "CUSTOMER DEMOGRAPHICS";
            this.buttonCUSTOMERDEMOGRAPHICS.UseVisualStyleBackColor = true;
            // 
            // buttonORDERDETAILS
            // 
            this.buttonORDERDETAILS.Location = new System.Drawing.Point(39, 211);
            this.buttonORDERDETAILS.Name = "buttonORDERDETAILS";
            this.buttonORDERDETAILS.Size = new System.Drawing.Size(139, 38);
            this.buttonORDERDETAILS.TabIndex = 4;
            this.buttonORDERDETAILS.Text = "ORDER DETAILS";
            this.buttonORDERDETAILS.UseVisualStyleBackColor = true;
            // 
            // buttonORDERS
            // 
            this.buttonORDERS.Location = new System.Drawing.Point(232, 211);
            this.buttonORDERS.Name = "buttonORDERS";
            this.buttonORDERS.Size = new System.Drawing.Size(139, 40);
            this.buttonORDERS.TabIndex = 5;
            this.buttonORDERS.Text = "ORDERS";
            this.buttonORDERS.UseVisualStyleBackColor = true;
            // 
            // buttonSHIPPERS
            // 
            this.buttonSHIPPERS.Location = new System.Drawing.Point(39, 293);
            this.buttonSHIPPERS.Name = "buttonSHIPPERS";
            this.buttonSHIPPERS.Size = new System.Drawing.Size(139, 38);
            this.buttonSHIPPERS.TabIndex = 6;
            this.buttonSHIPPERS.Text = "SHIPPERS";
            this.buttonSHIPPERS.UseVisualStyleBackColor = true;
            // 
            // buttonSUPPLIERS
            // 
            this.buttonSUPPLIERS.Location = new System.Drawing.Point(232, 293);
            this.buttonSUPPLIERS.Name = "buttonSUPPLIERS";
            this.buttonSUPPLIERS.Size = new System.Drawing.Size(139, 38);
            this.buttonSUPPLIERS.TabIndex = 7;
            this.buttonSUPPLIERS.Text = "SUPPLIERS";
            this.buttonSUPPLIERS.UseVisualStyleBackColor = true;
            // 
            // buttonTERRITORIES
            // 
            this.buttonTERRITORIES.Location = new System.Drawing.Point(39, 365);
            this.buttonTERRITORIES.Name = "buttonTERRITORIES";
            this.buttonTERRITORIES.Size = new System.Drawing.Size(139, 47);
            this.buttonTERRITORIES.TabIndex = 8;
            this.buttonTERRITORIES.Text = "TERRITORIES";
            this.buttonTERRITORIES.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 561);
            this.Controls.Add(this.buttonTERRITORIES);
            this.Controls.Add(this.buttonSUPPLIERS);
            this.Controls.Add(this.buttonSHIPPERS);
            this.Controls.Add(this.buttonORDERS);
            this.Controls.Add(this.buttonORDERDETAILS);
            this.Controls.Add(this.buttonCUSTOMERDEMOGRAPHICS);
            this.Controls.Add(this.buttonCATEGORIAS);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonEmpleados);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonCATEGORIAS;
        private System.Windows.Forms.Button buttonCUSTOMERDEMOGRAPHICS;
        private System.Windows.Forms.Button buttonORDERDETAILS;
        private System.Windows.Forms.Button buttonORDERS;
        private System.Windows.Forms.Button buttonSHIPPERS;
        private System.Windows.Forms.Button buttonSUPPLIERS;
        private System.Windows.Forms.Button buttonTERRITORIES;
    }
}

