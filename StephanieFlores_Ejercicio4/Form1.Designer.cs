
namespace StephanieFlores_Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomEdadcomboBox = new System.Windows.Forms.ComboBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomEdadcomboBox
            // 
            this.NomEdadcomboBox.FormattingEnabled = true;
            this.NomEdadcomboBox.Location = new System.Drawing.Point(84, 163);
            this.NomEdadcomboBox.Name = "NomEdadcomboBox";
            this.NomEdadcomboBox.Size = new System.Drawing.Size(285, 21);
            this.NomEdadcomboBox.TabIndex = 0;
            this.NomEdadcomboBox.SelectedIndexChanged += new System.EventHandler(this.NomEdadcomboBox_SelectedIndexChanged);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(72, 73);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(138, 20);
            this.NombretextBox.TabIndex = 2;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(295, 73);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(132, 20);
            this.EdadtextBox.TabIndex = 3;
            this.EdadtextBox.TextChanged += new System.EventHandler(this.EdadtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.NomEdadcomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NomEdadcomboBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

