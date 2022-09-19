
namespace EjercicioPoo
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.numericPassengers = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.radioButtonTaxi = new System.Windows.Forms.RadioButton();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassengers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(101, 221);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(94, 40);
            this.buttonGuardar.TabIndex = 0;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // numericPassengers
            // 
            this.numericPassengers.Location = new System.Drawing.Point(115, 148);
            this.numericPassengers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPassengers.Name = "numericPassengers";
            this.numericPassengers.Size = new System.Drawing.Size(80, 20);
            this.numericPassengers.TabIndex = 2;
            this.numericPassengers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericPassengers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ingresar cantidad de pasajeros";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(101, 312);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(94, 44);
            this.buttonMostrar.TabIndex = 22;
            this.buttonMostrar.Text = "Mostrar ";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // radioButtonTaxi
            // 
            this.radioButtonTaxi.AutoSize = true;
            this.radioButtonTaxi.Location = new System.Drawing.Point(28, 19);
            this.radioButtonTaxi.Name = "radioButtonTaxi";
            this.radioButtonTaxi.Size = new System.Drawing.Size(45, 17);
            this.radioButtonTaxi.TabIndex = 23;
            this.radioButtonTaxi.TabStop = true;
            this.radioButtonTaxi.Text = "Taxi";
            this.radioButtonTaxi.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Location = new System.Drawing.Point(112, 19);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(43, 17);
            this.radioButtonBus.TabIndex = 24;
            this.radioButtonBus.TabStop = true;
            this.radioButtonBus.Text = "Bus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTaxi);
            this.groupBox1.Controls.Add(this.radioButtonBus);
            this.groupBox1.Location = new System.Drawing.Point(57, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 54);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transporte:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericPassengers);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPassengers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.NumericUpDown numericPassengers;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.RadioButton radioButtonTaxi;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

