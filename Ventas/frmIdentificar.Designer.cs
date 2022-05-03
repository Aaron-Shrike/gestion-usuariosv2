namespace Ventas
{
  partial class frmIdentificar
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
      this.lblUsuario = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.lblClave = new System.Windows.Forms.Label();
      this.txtClave = new System.Windows.Forms.TextBox();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblUsuario
      // 
      this.lblUsuario.AutoSize = true;
      this.lblUsuario.Location = new System.Drawing.Point(33, 65);
      this.lblUsuario.Name = "lblUsuario";
      this.lblUsuario.Size = new System.Drawing.Size(43, 13);
      this.lblUsuario.TabIndex = 0;
      this.lblUsuario.Text = "&Usuario";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(90, 58);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(237, 20);
      this.txtUsuario.TabIndex = 1;
      // 
      // lblClave
      // 
      this.lblClave.AutoSize = true;
      this.lblClave.Location = new System.Drawing.Point(33, 114);
      this.lblClave.Name = "lblClave";
      this.lblClave.Size = new System.Drawing.Size(34, 13);
      this.lblClave.TabIndex = 2;
      this.lblClave.Text = "&Clave";
      // 
      // txtClave
      // 
      this.txtClave.Location = new System.Drawing.Point(90, 107);
      this.txtClave.Name = "txtClave";
      this.txtClave.PasswordChar = '*';
      this.txtClave.Size = new System.Drawing.Size(237, 20);
      this.txtClave.TabIndex = 3;
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(171, 216);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 4;
      this.btnAceptar.Text = "&Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // btnCancelar
      // 
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(252, 216);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 5;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // frmIdentificar
      // 
      this.AcceptButton = this.btnAceptar;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(341, 260);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnAceptar);
      this.Controls.Add(this.txtClave);
      this.Controls.Add(this.lblClave);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.lblUsuario);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmIdentificar";
      this.Text = "Identificar usuario";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.Label lblClave;
    private System.Windows.Forms.TextBox txtClave;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.Button btnCancelar;
  }
}