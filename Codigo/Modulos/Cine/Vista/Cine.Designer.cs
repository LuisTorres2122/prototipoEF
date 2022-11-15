
namespace ComprasVista
{
    partial class Cine
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
            this.txt_Dirección = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_cines = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cines)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Dirección
            // 
            this.txt_Dirección.Location = new System.Drawing.Point(191, 280);
            this.txt_Dirección.Name = "txt_Dirección";
            this.txt_Dirección.Size = new System.Drawing.Size(270, 20);
            this.txt_Dirección.TabIndex = 27;
            this.txt_Dirección.Tag = "Dirección";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(191, 242);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(270, 20);
            this.txt_nombre.TabIndex = 26;
            this.txt_nombre.Tag = "Nombre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(191, 207);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 25;
            this.txt_id.Tag = "idCines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id";
            // 
            // Dgv_cines
            // 
            this.Dgv_cines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cines.Location = new System.Drawing.Point(23, 390);
            this.Dgv_cines.Name = "Dgv_cines";
            this.Dgv_cines.Size = new System.Drawing.Size(789, 229);
            this.Dgv_cines.TabIndex = 17;
            this.Dgv_cines.Tag = "cines";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(82, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 16;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Cine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(822, 633);
            this.Controls.Add(this.txt_Dirección);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_cines);
            this.Controls.Add(this.navegador1);
            this.Name = "Cine";
            this.Text = "Cine";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Dirección;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_cines;
        private NavegadorVista.Navegador navegador1;
    }
}