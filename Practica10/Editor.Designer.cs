/*
 * Autor: Sara Blanco Muñoz
 * Fecha: 31/01/2018
 * Práctica: Aplicación Windows. Editor de texto
*/

namespace Practica10
{
    partial class editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.archivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarArchivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuOpciones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOpciones
            // 
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenuItem,
            this.edicionMenuItem,
            this.formatoMenuItem,
            this.ayudaMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(853, 28);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // archivoMenuItem
            // 
            this.archivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoMenuItem,
            this.abrirArchivoMenuItem,
            this.guardarMenuItem,
            this.guardarArchivoMenuItem});
            this.archivoMenuItem.Name = "archivoMenuItem";
            this.archivoMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoMenuItem.Text = "Archivo";
            // 
            // nuevoMenuItem
            // 
            this.nuevoMenuItem.Name = "nuevoMenuItem";
            this.nuevoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoMenuItem.Size = new System.Drawing.Size(305, 26);
            this.nuevoMenuItem.Text = "Nuevo";
            this.nuevoMenuItem.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // abrirArchivoMenuItem
            // 
            this.abrirArchivoMenuItem.Name = "abrirArchivoMenuItem";
            this.abrirArchivoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirArchivoMenuItem.Size = new System.Drawing.Size(305, 26);
            this.abrirArchivoMenuItem.Text = "Abrir archivo...";
            this.abrirArchivoMenuItem.Click += new System.EventHandler(this.abrirArchivo_Click);
            // 
            // guardarMenuItem
            // 
            this.guardarMenuItem.Name = "guardarMenuItem";
            this.guardarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarMenuItem.Size = new System.Drawing.Size(305, 26);
            this.guardarMenuItem.Text = "Guardar";
            this.guardarMenuItem.Click += new System.EventHandler(this.guardar_Click);
            // 
            // guardarArchivoMenuItem
            // 
            this.guardarArchivoMenuItem.Name = "guardarArchivoMenuItem";
            this.guardarArchivoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.guardarArchivoMenuItem.Size = new System.Drawing.Size(305, 26);
            this.guardarArchivoMenuItem.Text = "Guardar archivo...";
            this.guardarArchivoMenuItem.Click += new System.EventHandler(this.guardar_Click);
            // 
            // edicionMenuItem
            // 
            this.edicionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerMenuItem,
            this.rehacerMenuItem,
            this.cortarMenuItem,
            this.copiarMenuItem,
            this.pegarMenuItem,
            this.eliminarMenuItem});
            this.edicionMenuItem.Name = "edicionMenuItem";
            this.edicionMenuItem.Size = new System.Drawing.Size(70, 24);
            this.edicionMenuItem.Text = "Edición";
            // 
            // deshacerMenuItem
            // 
            this.deshacerMenuItem.Enabled = false;
            this.deshacerMenuItem.Name = "deshacerMenuItem";
            this.deshacerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deshacerMenuItem.Text = "Deshacer";
            this.deshacerMenuItem.Click += new System.EventHandler(this.deshacer_Click);
            // 
            // rehacerMenuItem
            // 
            this.rehacerMenuItem.Enabled = false;
            this.rehacerMenuItem.Name = "rehacerMenuItem";
            this.rehacerMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerMenuItem.Size = new System.Drawing.Size(196, 26);
            this.rehacerMenuItem.Text = "Rehacer";
            this.rehacerMenuItem.Click += new System.EventHandler(this.rehacer_Click);
            // 
            // cortarMenuItem
            // 
            this.cortarMenuItem.Name = "cortarMenuItem";
            this.cortarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarMenuItem.Size = new System.Drawing.Size(196, 26);
            this.cortarMenuItem.Text = "Cortar";
            this.cortarMenuItem.Click += new System.EventHandler(this.cortar_Click);
            // 
            // copiarMenuItem
            // 
            this.copiarMenuItem.Name = "copiarMenuItem";
            this.copiarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarMenuItem.Size = new System.Drawing.Size(196, 26);
            this.copiarMenuItem.Text = "Copiar";
            this.copiarMenuItem.Click += new System.EventHandler(this.copiar_Click);
            // 
            // pegarMenuItem
            // 
            this.pegarMenuItem.Name = "pegarMenuItem";
            this.pegarMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarMenuItem.Size = new System.Drawing.Size(196, 26);
            this.pegarMenuItem.Text = "Pegar";
            this.pegarMenuItem.Click += new System.EventHandler(this.pegar_Click);
            // 
            // eliminarMenuItem
            // 
            this.eliminarMenuItem.Name = "eliminarMenuItem";
            this.eliminarMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminarMenuItem.Size = new System.Drawing.Size(196, 26);
            this.eliminarMenuItem.Text = "Eliminar";
            this.eliminarMenuItem.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // formatoMenuItem
            // 
            this.formatoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteMenuItem,
            this.colorMenuItem});
            this.formatoMenuItem.Name = "formatoMenuItem";
            this.formatoMenuItem.Size = new System.Drawing.Size(77, 24);
            this.formatoMenuItem.Text = "Formato";
            // 
            // fuenteMenuItem
            // 
            this.fuenteMenuItem.Name = "fuenteMenuItem";
            this.fuenteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fuenteMenuItem.Size = new System.Drawing.Size(226, 26);
            this.fuenteMenuItem.Text = "Fuente";
            this.fuenteMenuItem.Click += new System.EventHandler(this.fuente_Click);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.colorMenuItem.Size = new System.Drawing.Size(226, 26);
            this.colorMenuItem.Text = "Color";
            this.colorMenuItem.Click += new System.EventHandler(this.color_Click);
            // 
            // ayudaMenuItem
            // 
            this.ayudaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeMenuItem});
            this.ayudaMenuItem.Name = "ayudaMenuItem";
            this.ayudaMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaMenuItem.Text = "Ayuda";
            // 
            // acercaDeMenuItem
            // 
            this.acercaDeMenuItem.Name = "acercaDeMenuItem";
            this.acercaDeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.acercaDeMenuItem.Size = new System.Drawing.Size(212, 26);
            this.acercaDeMenuItem.Text = "Acerca de...";
            this.acercaDeMenuItem.Click += new System.EventHandler(this.acercaDe_Click);
            // 
            // texto
            // 
            this.texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texto.Location = new System.Drawing.Point(0, 0);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(853, 529);
            this.texto.TabIndex = 1;
            this.texto.Text = "";
            this.texto.TextChanged += new System.EventHandler(this.texto_Cambia);
            // 
            // notificacion
            // 
            this.notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificacion.BalloonTipText = "Editor de texto activo.";
            this.notificacion.BalloonTipTitle = "Editor";
            this.notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacion.Icon")));
            this.notificacion.Text = "Editor de texto activo.";
            this.notificacion.Visible = true;
            this.notificacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notificacion_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.cutButton,
            this.pasteButton,
            this.undoButton,
            this.redoButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Margin = new System.Windows.Forms.Padding(5);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(24, 24);
            this.newButton.Text = "toolStripButton1";
            this.newButton.ToolTipText = "Nuevo archivo";
            this.newButton.Click += new System.EventHandler(this.nuevoBut_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Margin = new System.Windows.Forms.Padding(5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(24, 24);
            this.openButton.Text = "toolStripButton2";
            this.openButton.ToolTipText = "Abrir archivo";
            this.openButton.Click += new System.EventHandler(this.abrirArchivoBut_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(24, 24);
            this.saveButton.Text = "toolStripButton3";
            this.saveButton.ToolTipText = "Guardar";
            this.saveButton.Click += new System.EventHandler(this.guardarBut_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(24, 24);
            this.cutButton.Text = "toolStripButton4";
            this.cutButton.ToolTipText = "Cortar";
            this.cutButton.Click += new System.EventHandler(this.cortarBut_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Margin = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(24, 24);
            this.pasteButton.Text = "toolStripButton1";
            this.pasteButton.ToolTipText = "Pegar";
            this.pasteButton.Click += new System.EventHandler(this.pegarBut_Click);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(24, 24);
            this.undoButton.Text = "toolStripButton1";
            this.undoButton.ToolTipText = "Deshacer";
            this.undoButton.Click += new System.EventHandler(this.deshacerBut_Click);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Margin = new System.Windows.Forms.Padding(1, 5, 5, 5);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(24, 24);
            this.redoButton.Text = "toolStripButton1";
            this.redoButton.ToolTipText = "Rehacer";
            this.redoButton.Click += new System.EventHandler(this.rehacerBut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.texto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 529);
            this.panel1.TabIndex = 3;
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ventana_Cerrar);
            this.Resize += new System.EventHandler(this.editor_Min);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarArchivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeMenuItem;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.NotifyIcon notificacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
    }
}

