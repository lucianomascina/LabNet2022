
namespace Lab.EF.UI.Views.Linq
{
    partial class FormEJERCICIO6
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
            this.dataGridViewMayuscula = new System.Windows.Forms.DataGridView();
            this.dataGridViewMINUSCULA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayuscula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMINUSCULA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMayuscula
            // 
            this.dataGridViewMayuscula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMayuscula.Location = new System.Drawing.Point(33, 56);
            this.dataGridViewMayuscula.Name = "dataGridViewMayuscula";
            this.dataGridViewMayuscula.Size = new System.Drawing.Size(300, 392);
            this.dataGridViewMayuscula.TabIndex = 0;
            // 
            // dataGridViewMINUSCULA
            // 
            this.dataGridViewMINUSCULA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMINUSCULA.Location = new System.Drawing.Point(367, 56);
            this.dataGridViewMINUSCULA.Name = "dataGridViewMINUSCULA";
            this.dataGridViewMINUSCULA.Size = new System.Drawing.Size(292, 392);
            this.dataGridViewMINUSCULA.TabIndex = 1;
            // 
            // FormEJERCICIO6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 493);
            this.Controls.Add(this.dataGridViewMINUSCULA);
            this.Controls.Add(this.dataGridViewMayuscula);
            this.Name = "FormEJERCICIO6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEJERCICIO6";
            this.Load += new System.EventHandler(this.FormEJERCICIO6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMayuscula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMINUSCULA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMayuscula;
        private System.Windows.Forms.DataGridView dataGridViewMINUSCULA;
    }
}