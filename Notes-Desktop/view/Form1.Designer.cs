namespace Notes_Desktop
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
            this.cmbNota = new System.Windows.Forms.ComboBox();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNoteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNota
            // 
            this.cmbNota.Enabled = false;
            this.cmbNota.FormattingEnabled = true;
            this.cmbNota.Location = new System.Drawing.Point(12, 27);
            this.cmbNota.Name = "cmbNota";
            this.cmbNota.Size = new System.Drawing.Size(245, 23);
            this.cmbNota.TabIndex = 0;
            this.cmbNota.SelectedIndexChanged += new System.EventHandler(this.cmbNota_SelectedIndexChanged);
            // 
            // txtContenido
            // 
            this.txtContenido.Enabled = false;
            this.txtContenido.Location = new System.Drawing.Point(12, 56);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(245, 318);
            this.txtContenido.TabIndex = 1;
            this.txtContenido.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteItem,
            this.deleteNoteItem,
            this.saveNoteItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // newNoteItem
            // 
            this.newNoteItem.Name = "newNoteItem";
            this.newNoteItem.Size = new System.Drawing.Size(180, 22);
            this.newNoteItem.Text = "Nueva Nota";
            this.newNoteItem.Click += new System.EventHandler(this.newNoteItem_Click);
            // 
            // deleteNoteItem
            // 
            this.deleteNoteItem.Name = "deleteNoteItem";
            this.deleteNoteItem.Size = new System.Drawing.Size(180, 22);
            this.deleteNoteItem.Text = "Eliminar Actual";
            this.deleteNoteItem.Click += new System.EventHandler(this.deleteNoteItem_Click);
            // 
            // saveNoteItem
            // 
            this.saveNoteItem.Name = "saveNoteItem";
            this.saveNoteItem.Size = new System.Drawing.Size(180, 22);
            this.saveNoteItem.Text = "Guardar Actual";
            this.saveNoteItem.Click += new System.EventHandler(this.saveNoteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 385);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.cmbNota);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbNota;
        private RichTextBox txtContenido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem newNoteItem;
        private ToolStripMenuItem deleteNoteItem;
        private ToolStripMenuItem saveNoteItem;
    }
}