namespace Examen_final_proga2_marjorie
{
    partial class Actualizar_carrera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_carrera));
            this.tx_nombreylistadecarrera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVcarrera = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nombreylistadecarrera
            // 
            this.tx_nombreylistadecarrera.Location = new System.Drawing.Point(168, 61);
            this.tx_nombreylistadecarrera.Name = "tx_nombreylistadecarrera";
            this.tx_nombreylistadecarrera.Size = new System.Drawing.Size(100, 20);
            this.tx_nombreylistadecarrera.TabIndex = 20;
            this.tx_nombreylistadecarrera.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_nombreylistadecarrera_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de la Carrera";
            // 
            // DGVcarrera
            // 
            this.DGVcarrera.AllowUserToAddRows = false;
            this.DGVcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVcarrera.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVcarrera.Location = new System.Drawing.Point(32, 144);
            this.DGVcarrera.Name = "DGVcarrera";
            this.DGVcarrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcarrera.Size = new System.Drawing.Size(310, 177);
            this.DGVcarrera.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 82);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Carreras";
            // 
            // Actualizar_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 393);
            this.Controls.Add(this.tx_nombreylistadecarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVcarrera);
            this.Controls.Add(this.groupBox1);
            this.Name = "Actualizar_carrera";
            this.Text = "Listar Carrera";
            this.Load += new System.EventHandler(this.Actualizar_carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nombreylistadecarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVcarrera;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}