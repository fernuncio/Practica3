namespace Practica3
{
    partial class Menú
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
            menuStrip1 = new MenuStrip();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            dataGridToolStripMenuItem = new ToolStripMenuItem();
            fechasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.Items.AddRange(new ToolStripItem[] { aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(541, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataGridToolStripMenuItem, fechasToolStripMenuItem });
            aplicacionesToolStripMenuItem.ForeColor = Color.White;
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // dataGridToolStripMenuItem
            // 
            dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            dataGridToolStripMenuItem.Size = new Size(180, 22);
            dataGridToolStripMenuItem.Text = "DataGrid";
            dataGridToolStripMenuItem.Click += dataGridToolStripMenuItem_Click;
            // 
            // fechasToolStripMenuItem
            // 
            fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            fechasToolStripMenuItem.Size = new Size(180, 22);
            fechasToolStripMenuItem.Text = "Fechas";
            fechasToolStripMenuItem.Click += fechasToolStripMenuItem_Click;
            // 
            // Menú
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(541, 336);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menú";
            Text = "Menú";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem dataGridToolStripMenuItem;
        private ToolStripMenuItem fechasToolStripMenuItem;
    }
}