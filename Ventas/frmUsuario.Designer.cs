namespace Ventas
{
  partial class frmUsuario
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
      this.btnCerrar = new System.Windows.Forms.Button();
      this.gbListado = new System.Windows.Forms.GroupBox();
      this.btnListar = new System.Windows.Forms.Button();
      this.btnModificar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.dgvListado = new System.Windows.Forms.DataGridView();
      this.gbEntidad = new System.Windows.Forms.GroupBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.chkVigente = new System.Windows.Forms.CheckBox();
      this.btnAceptar = new System.Windows.Forms.Button();
      this.txtRepetir = new System.Windows.Forms.TextBox();
      this.lblFechaNacimiento = new System.Windows.Forms.Label();
      this.lblCelular = new System.Windows.Forms.Label();
      this.txtClave = new System.Windows.Forms.TextBox();
      this.lblApellidos = new System.Windows.Forms.Label();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lblPersonal = new System.Windows.Forms.Label();
      this.cboPersonal = new System.Windows.Forms.ComboBox();
      this.cboTipo = new System.Windows.Forms.ComboBox();
      this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gbListado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
      this.gbEntidad.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCerrar
      // 
      this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCerrar.Location = new System.Drawing.Point(782, 415);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(75, 23);
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.Text = "C&errar";
      this.btnCerrar.UseVisualStyleBackColor = true;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // gbListado
      // 
      this.gbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gbListado.Controls.Add(this.btnListar);
      this.gbListado.Controls.Add(this.btnModificar);
      this.gbListado.Controls.Add(this.btnNuevo);
      this.gbListado.Controls.Add(this.dgvListado);
      this.gbListado.Location = new System.Drawing.Point(421, 24);
      this.gbListado.Name = "gbListado";
      this.gbListado.Size = new System.Drawing.Size(436, 385);
      this.gbListado.TabIndex = 1;
      this.gbListado.TabStop = false;
      this.gbListado.Text = "Listado";
      // 
      // btnListar
      // 
      this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnListar.Location = new System.Drawing.Point(352, 19);
      this.btnListar.Name = "btnListar";
      this.btnListar.Size = new System.Drawing.Size(75, 23);
      this.btnListar.TabIndex = 0;
      this.btnListar.Text = "&Listar";
      this.btnListar.UseVisualStyleBackColor = true;
      this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
      // 
      // btnModificar
      // 
      this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnModificar.Location = new System.Drawing.Point(92, 352);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new System.Drawing.Size(75, 23);
      this.btnModificar.TabIndex = 3;
      this.btnModificar.Text = "&Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      // 
      // btnNuevo
      // 
      this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnNuevo.Location = new System.Drawing.Point(11, 352);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(75, 23);
      this.btnNuevo.TabIndex = 2;
      this.btnNuevo.Text = "&Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = true;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // dgvListado
      // 
      this.dgvListado.AllowUserToAddRows = false;
      this.dgvListado.AllowUserToDeleteRows = false;
      this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombre,
            this.cdUsuario});
      this.dgvListado.Location = new System.Drawing.Point(11, 56);
      this.dgvListado.MultiSelect = false;
      this.dgvListado.Name = "dgvListado";
      this.dgvListado.ReadOnly = true;
      this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvListado.Size = new System.Drawing.Size(416, 290);
      this.dgvListado.TabIndex = 1;
      // 
      // gbEntidad
      // 
      this.gbEntidad.Controls.Add(this.cboTipo);
      this.gbEntidad.Controls.Add(this.cboPersonal);
      this.gbEntidad.Controls.Add(this.btnCancelar);
      this.gbEntidad.Controls.Add(this.chkVigente);
      this.gbEntidad.Controls.Add(this.btnAceptar);
      this.gbEntidad.Controls.Add(this.txtRepetir);
      this.gbEntidad.Controls.Add(this.lblFechaNacimiento);
      this.gbEntidad.Controls.Add(this.lblCelular);
      this.gbEntidad.Controls.Add(this.txtClave);
      this.gbEntidad.Controls.Add(this.lblApellidos);
      this.gbEntidad.Controls.Add(this.txtNombre);
      this.gbEntidad.Controls.Add(this.label2);
      this.gbEntidad.Controls.Add(this.lblPersonal);
      this.gbEntidad.Enabled = false;
      this.gbEntidad.Location = new System.Drawing.Point(12, 24);
      this.gbEntidad.Name = "gbEntidad";
      this.gbEntidad.Size = new System.Drawing.Size(403, 269);
      this.gbEntidad.TabIndex = 0;
      this.gbEntidad.TabStop = false;
      this.gbEntidad.Text = "Entidad";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Location = new System.Drawing.Point(306, 230);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 12;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // chkVigente
      // 
      this.chkVigente.AutoSize = true;
      this.chkVigente.Location = new System.Drawing.Point(73, 176);
      this.chkVigente.Name = "chkVigente";
      this.chkVigente.Size = new System.Drawing.Size(62, 17);
      this.chkVigente.TabIndex = 10;
      this.chkVigente.Text = "&Vigente";
      this.chkVigente.UseVisualStyleBackColor = true;
      // 
      // btnAceptar
      // 
      this.btnAceptar.Location = new System.Drawing.Point(225, 230);
      this.btnAceptar.Name = "btnAceptar";
      this.btnAceptar.Size = new System.Drawing.Size(75, 23);
      this.btnAceptar.TabIndex = 11;
      this.btnAceptar.Text = "&Aceptar";
      this.btnAceptar.UseVisualStyleBackColor = true;
      this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
      // 
      // txtRepetir
      // 
      this.txtRepetir.Location = new System.Drawing.Point(73, 110);
      this.txtRepetir.Name = "txtRepetir";
      this.txtRepetir.PasswordChar = '*';
      this.txtRepetir.Size = new System.Drawing.Size(164, 20);
      this.txtRepetir.TabIndex = 7;
      // 
      // lblFechaNacimiento
      // 
      this.lblFechaNacimiento.AutoSize = true;
      this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 145);
      this.lblFechaNacimiento.Name = "lblFechaNacimiento";
      this.lblFechaNacimiento.Size = new System.Drawing.Size(28, 13);
      this.lblFechaNacimiento.TabIndex = 8;
      this.lblFechaNacimiento.Text = "&Tipo";
      // 
      // lblCelular
      // 
      this.lblCelular.AutoSize = true;
      this.lblCelular.Location = new System.Drawing.Point(12, 117);
      this.lblCelular.Name = "lblCelular";
      this.lblCelular.Size = new System.Drawing.Size(41, 13);
      this.lblCelular.TabIndex = 6;
      this.lblCelular.Text = "&Repetir";
      // 
      // txtClave
      // 
      this.txtClave.Location = new System.Drawing.Point(73, 84);
      this.txtClave.Name = "txtClave";
      this.txtClave.PasswordChar = '*';
      this.txtClave.Size = new System.Drawing.Size(164, 20);
      this.txtClave.TabIndex = 5;
      // 
      // lblApellidos
      // 
      this.lblApellidos.AutoSize = true;
      this.lblApellidos.Location = new System.Drawing.Point(12, 91);
      this.lblApellidos.Name = "lblApellidos";
      this.lblApellidos.Size = new System.Drawing.Size(34, 13);
      this.lblApellidos.TabIndex = 4;
      this.lblApellidos.Text = "Cla&ve";
      // 
      // txtNombre
      // 
      this.txtNombre.Location = new System.Drawing.Point(73, 58);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.Size = new System.Drawing.Size(164, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "&Nombre";
      // 
      // lblPersonal
      // 
      this.lblPersonal.AutoSize = true;
      this.lblPersonal.Location = new System.Drawing.Point(12, 39);
      this.lblPersonal.Name = "lblPersonal";
      this.lblPersonal.Size = new System.Drawing.Size(48, 13);
      this.lblPersonal.TabIndex = 0;
      this.lblPersonal.Text = "&Personal";
      // 
      // cboPersonal
      // 
      this.cboPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboPersonal.FormattingEnabled = true;
      this.cboPersonal.Location = new System.Drawing.Point(73, 31);
      this.cboPersonal.Name = "cboPersonal";
      this.cboPersonal.Size = new System.Drawing.Size(308, 21);
      this.cboPersonal.TabIndex = 1;
      // 
      // cboTipo
      // 
      this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTipo.FormattingEnabled = true;
      this.cboTipo.Items.AddRange(new object[] {
            "Administrador",
            "Limitado"});
      this.cboTipo.Location = new System.Drawing.Point(73, 137);
      this.cboTipo.Name = "cboTipo";
      this.cboTipo.Size = new System.Drawing.Size(164, 21);
      this.cboTipo.TabIndex = 9;
      // 
      // cdNombre
      // 
      this.cdNombre.DataPropertyName = "NombrePersonal";
      this.cdNombre.HeaderText = "Personal";
      this.cdNombre.Name = "cdNombre";
      this.cdNombre.ReadOnly = true;
      this.cdNombre.Width = 300;
      // 
      // cdUsuario
      // 
      this.cdUsuario.DataPropertyName = "Nombre";
      this.cdUsuario.HeaderText = "Usuario";
      this.cdUsuario.Name = "cdUsuario";
      this.cdUsuario.ReadOnly = true;
      // 
      // frmUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(869, 450);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.gbListado);
      this.Controls.Add(this.gbEntidad);
      this.Name = "frmUsuario";
      this.Text = "Usuario";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsuario_FormClosed);
      this.Load += new System.EventHandler(this.frmUsuario_Load);
      this.gbListado.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
      this.gbEntidad.ResumeLayout(false);
      this.gbEntidad.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCerrar;
    private System.Windows.Forms.GroupBox gbListado;
    private System.Windows.Forms.Button btnListar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnNuevo;
    private System.Windows.Forms.DataGridView dgvListado;
    private System.Windows.Forms.GroupBox gbEntidad;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.CheckBox chkVigente;
    private System.Windows.Forms.Button btnAceptar;
    private System.Windows.Forms.TextBox txtRepetir;
    private System.Windows.Forms.Label lblFechaNacimiento;
    private System.Windows.Forms.Label lblCelular;
    private System.Windows.Forms.TextBox txtClave;
    private System.Windows.Forms.Label lblApellidos;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblPersonal;
    private System.Windows.Forms.ComboBox cboTipo;
    private System.Windows.Forms.ComboBox cboPersonal;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn cdUsuario;
  }
}