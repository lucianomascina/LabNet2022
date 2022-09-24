
namespace Lab.EF.UI
{
    partial class FormMenuCustomers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(270, 12);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(82, 36);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "CREAR";
            this.buttonCrear.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(417, 12);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(98, 36);
            this.buttonActualizar.TabIndex = 2;
            this.buttonActualizar.Text = "ACTUALIZAR";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(576, 12);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(86, 36);
            this.buttonBorrar.TabIndex = 3;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(33, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(89, 36);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormMenuCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 537);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMenuCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuCustomers";
            this.Load += new System.EventHandler(this.FormMenuCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonSalir;
    }
}