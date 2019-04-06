/*
 * Autor: Sara Blanco Muñoz
 * Fecha: 31/01/2018
 * Práctica: Aplicación Windows. Editor de texto
*/

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Practica10
{
    public partial class editor : Form
    {

        #region Atributos    

        public SaveFileDialog sfd;  
        public OpenFileDialog ofd;
        private bool editado;

        #endregion
  
        public editor()
        {
            Thread t = new Thread(new ThreadStart(comenzar));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();

            InitializeComponent();
            TopMost = true;

            sfd = new SaveFileDialog();
            ofd = new OpenFileDialog();
            editado = false;
                        
            this.Text = "Sin título - " + this.Text; 
            notificacion.ShowBalloonTip(500);
            notificacion.Visible = false;
            texto.Focus();
        }

        #region Eventos  

        #region Eventos del menú

        private void nuevo_Click(object sender, EventArgs e)
        {
            if (editado)
            {
                guardarAntes();
            }
            texto.Clear();
            editado = false;
        }

        private void abrirArchivo_Click(object sender, EventArgs e)
        {
            guardarAntes();
            abrirFichero();
            editado = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string s;

            try
            {
                ToolStripMenuItem m = (ToolStripMenuItem)sender;
                s = m.Text;
            }
            catch(InvalidCastException)
            {
                s = "Guardar";
            }

            if (s.Equals("Guardar"))
            {
                guardarFichero(true);
            }
            else
            {
                guardarFichero(false);
            }
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            texto.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            texto.Paste();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            texto.Copy();
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            if (texto.CanUndo)
            {
                texto.Undo();
            }
        }

        private void rehacer_Click(object sender, EventArgs e)
        {
            if (texto.CanRedo)
            {
                texto.Redo();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            texto.SelectedText = "";
        }

        private void fuente_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = texto.SelectionFont;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                texto.SelectionFont = fd.Font;
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();

            fd.Color = texto.SelectionColor;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                texto.SelectionColor = fd.Color;
            }
        }

        private void acercaDe_Click(object sender, EventArgs e)
        {
            TopMost = false;
            new AcercaDe().ShowDialog();
        }

        private void texto_Cambia(object sender, EventArgs e)
        {
            deshacerMenuItem.Enabled = true;
            rehacerMenuItem.Enabled = true;
            editado = true;
        }

        private void editor_Min(object sender, EventArgs e)  
        {  
            if (this.WindowState == FormWindowState.Minimized)  
            {
                Hide();
                notificacion.Visible = true;
            }
        }

        private void notificacion_Click(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notificacion.Visible = false;
        }


        #endregion

        #region Eventos de los Botones

        private void nuevoBut_Click(object sender, EventArgs e)
        {
            nuevo_Click(sender, e);
        }

        private void abrirArchivoBut_Click(object sender, EventArgs e)
        {
            abrirArchivo_Click(sender, e);
        }

        private void guardarBut_Click(object sender, EventArgs e)
        {
            guardar_Click(sender, e);
        }

        private void cortarBut_Click(object sender, EventArgs e)
        {
            cortar_Click(sender, e);
        }

        private void pegarBut_Click(object sender, EventArgs e)
        {
            pegar_Click(sender, e);
        }

        private void deshacerBut_Click(object sender, EventArgs e)
        {
            deshacer_Click(sender, e);
        }

        private void rehacerBut_Click(object sender, EventArgs e)
        {
            rehacer_Click(sender, e);
        }

        private void ventana_Cerrar(object sender, FormClosingEventArgs e)
        {
            guardarAntes();
            notificacion.Dispose();
        }

        #endregion

        #endregion

        #region Funciones auxiliares

        private void guardarFichero(bool opcion)
        {
            DialogResult res;
            sfd.InitialDirectory = Path.GetFullPath(@"..\..\Archivos\");
            sfd.Title = "Guardar como";
            sfd.Filter = "Rich Text Files|*.rtf";
            sfd.FileName = this.Text.Substring(0, this.Text.IndexOf("-") - 1);

            res = (opcion) ? DialogResult.OK : sfd.ShowDialog();

            string s = @"..\..\Archivos\" + sfd.FileName + ".rtf";
            
            if (opcion && File.Exists(s))
            {
                File.Delete(s);
                texto.SaveFile(s, RichTextBoxStreamType.RichText);
                editado = false;
            }

            if (!opcion && res == DialogResult.OK)
            {
                texto.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                editado = false;
            }

        }
        
        private void abrirFichero()
        {
            string file = "";

            ofd.Title = "Abrir Fichero";
            ofd.Filter = "Rich Text Files|*.rtf";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != String.Empty)                
            {
                file = ofd.FileName;
                try
                {
                    texto.LoadFile(file, RichTextBoxStreamType.RichText);
                }
                catch(Exception)
                {
                    MessageBox.Show("Error al cargar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            editado = false;
        }

        private void comenzar()
        {
            Application.Run(new Splash());
        }

        private void guardarAntes()
        {
            if (editado)
            {
                DialogResult dr = MessageBox.Show("¿Desea guardar el fichero actual?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    guardarFichero(false);
                }

                editado = false;
            }
        }

        #endregion

    }
}