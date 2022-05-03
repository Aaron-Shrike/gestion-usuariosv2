namespace Ventas
{
  partial class frmPrincipal
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
      this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
      this.mnuDatos = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuPersonal = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuPrincipal.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuPrincipal
      // 
      this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatos});
      this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
      this.mnuPrincipal.Name = "mnuPrincipal";
      this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
      this.mnuPrincipal.TabIndex = 0;
      this.mnuPrincipal.Text = "menuStrip1";
      // 
      // mnuDatos
      // 
      this.mnuDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPersonal,
            this.mnuUsuario,
            this.toolStripMenuItem1,
            this.mnuSalir});
      this.mnuDatos.Name = "mnuDatos";
      this.mnuDatos.Size = new System.Drawing.Size(49, 20);
      this.mnuDatos.Text = "Datos";
      // 
      // mnuPersonal
      // 
      this.mnuPersonal.Name = "mnuPersonal";
      this.mnuPersonal.Size = new System.Drawing.Size(180, 22);
      this.mnuPersonal.Text = "Personal";
      this.mnuPersonal.Click += new System.EventHandler(this.mnuPersonal_Click);
      // 
      // mnuUsuario
      // 
      this.mnuUsuario.Name = "mnuUsuario";
      this.mnuUsuario.Size = new System.Drawing.Size(180, 22);
      this.mnuUsuario.Text = "Usuario";
      this.mnuUsuario.Click += new System.EventHandler(this.mnuUsuario_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuSalir
      // 
      this.mnuSalir.Name = "mnuSalir";
      this.mnuSalir.Size = new System.Drawing.Size(180, 22);
      this.mnuSalir.Text = "&Salir";
      this.mnuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
      // 
      // frmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.mnuPrincipal);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.mnuPrincipal;
      this.Name = "frmPrincipal";
      this.Text = "Sistema de ventas";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.mnuPrincipal.ResumeLayout(false);
      this.mnuPrincipal.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem mnuDatos;
    private System.Windows.Forms.ToolStripMenuItem mnuPersonal;
    private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuSalir;
  }
}