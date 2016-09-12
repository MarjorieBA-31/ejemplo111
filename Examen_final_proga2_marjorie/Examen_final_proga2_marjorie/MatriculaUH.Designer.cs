namespace Examen_final_proga2_marjorie
{
    partial class MatriculaUH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaUH));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elíminaCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elíminarCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.alumnoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(738, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMatriculaToolStripMenuItem,
            this.consultaMatriculaToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            // 
            // nuevaMatriculaToolStripMenuItem
            // 
            this.nuevaMatriculaToolStripMenuItem.Name = "nuevaMatriculaToolStripMenuItem";
            this.nuevaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nuevaMatriculaToolStripMenuItem.Text = "Nueva Matricula";
            this.nuevaMatriculaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMatriculaToolStripMenuItem_Click);
            // 
            // consultaMatriculaToolStripMenuItem
            // 
            this.consultaMatriculaToolStripMenuItem.Name = "consultaMatriculaToolStripMenuItem";
            this.consultaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.consultaMatriculaToolStripMenuItem.Text = "Consulta Matricula";
            this.consultaMatriculaToolStripMenuItem.Click += new System.EventHandler(this.consultaMatriculaToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCarreraToolStripMenuItem,
            this.elíminaCarreraToolStripMenuItem,
            this.elíminarCarreraToolStripMenuItem});
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.carreraToolStripMenuItem.Text = "Carrera";
            // 
            // listaCarreraToolStripMenuItem
            // 
            this.listaCarreraToolStripMenuItem.Name = "listaCarreraToolStripMenuItem";
            this.listaCarreraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listaCarreraToolStripMenuItem.Text = "Lista Carrera";
            this.listaCarreraToolStripMenuItem.Click += new System.EventHandler(this.listaCarreraToolStripMenuItem_Click);
            // 
            // elíminaCarreraToolStripMenuItem
            // 
            this.elíminaCarreraToolStripMenuItem.Name = "elíminaCarreraToolStripMenuItem";
            this.elíminaCarreraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.elíminaCarreraToolStripMenuItem.Text = "Agregar  Carrera";
            this.elíminaCarreraToolStripMenuItem.Click += new System.EventHandler(this.elíminaCarreraToolStripMenuItem_Click);
            // 
            // elíminarCarreraToolStripMenuItem
            // 
            this.elíminarCarreraToolStripMenuItem.Name = "elíminarCarreraToolStripMenuItem";
            this.elíminarCarreraToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.elíminarCarreraToolStripMenuItem.Text = "Elíminar Carrera";
            this.elíminarCarreraToolStripMenuItem.Click += new System.EventHandler(this.elíminarCarreraToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 529);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(738, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MatriculaUH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(738, 551);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MatriculaUH";
            this.Text = "MatriculaUH";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elíminaCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elíminarCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}



