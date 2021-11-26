
namespace AppExpendedoraDeAgua
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pct50c = new System.Windows.Forms.PictureBox();
            this.pct1p = new System.Windows.Forms.PictureBox();
            this.pct5p = new System.Windows.Forms.PictureBox();
            this.btnBotella = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct50c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1p)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5p)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pct50c
            // 
            this.pct50c.Image = global::AppExpendedoraDeAgua.Properties.Resources.C_mon_050;
            this.pct50c.Location = new System.Drawing.Point(201, 85);
            this.pct50c.Name = "pct50c";
            this.pct50c.Size = new System.Drawing.Size(130, 130);
            this.pct50c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct50c.TabIndex = 0;
            this.pct50c.TabStop = false;
            // 
            // pct1p
            // 
            this.pct1p.Image = global::AppExpendedoraDeAgua.Properties.Resources.C_mon_1;
            this.pct1p.Location = new System.Drawing.Point(337, 85);
            this.pct1p.Name = "pct1p";
            this.pct1p.Size = new System.Drawing.Size(130, 130);
            this.pct1p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct1p.TabIndex = 1;
            this.pct1p.TabStop = false;
            // 
            // pct5p
            // 
            this.pct5p.Image = global::AppExpendedoraDeAgua.Properties.Resources.C_mon_5_resumen;
            this.pct5p.Location = new System.Drawing.Point(473, 85);
            this.pct5p.Name = "pct5p";
            this.pct5p.Size = new System.Drawing.Size(130, 130);
            this.pct5p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct5p.TabIndex = 2;
            this.pct5p.TabStop = false;
            // 
            // btnBotella
            // 
            this.btnBotella.Location = new System.Drawing.Point(14, 82);
            this.btnBotella.Name = "btnBotella";
            this.btnBotella.Size = new System.Drawing.Size(135, 132);
            this.btnBotella.TabIndex = 3;
            this.btnBotella.Text = "Agua";
            this.btnBotella.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Location = new System.Drawing.Point(202, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(3, 19);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(391, 23);
            this.txtCambio.TabIndex = 0;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPantalla.Location = new System.Drawing.Point(14, 12);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(589, 64);
            this.txtPantalla.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 302);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBotella);
            this.Controls.Add(this.pct5p);
            this.Controls.Add(this.pct1p);
            this.Controls.Add(this.pct50c);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct50c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1p)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct5p)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct50c;
        private System.Windows.Forms.PictureBox pct1p;
        private System.Windows.Forms.PictureBox pct5p;
        private System.Windows.Forms.Button btnBotella;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}

