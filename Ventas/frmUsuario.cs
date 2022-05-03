using Entidades;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
  public partial class frmUsuario : Form
  {

    private Usuario Actual;

    #region "Singleton"

    private static frmUsuario frm;

    private frmUsuario()
    {
      InitializeComponent();
    }

    public static frmUsuario Crear(Form frmPadre)
    {
      if (frmUsuario.frm == null)
      {
        frmUsuario.frm = new frmUsuario()
        {
          MdiParent = frmPadre,
          WindowState = FormWindowState.Maximized
        };
      }
      frmUsuario.frm.BringToFront();

      return frmUsuario.frm;
    }

    private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
    {
      frmUsuario.frm = null;
    }


    #endregion

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      this.ActivarControles(true);
      this.LimpiarControles();
      this.Actual = null;
    }

    private void LimpiarControles()
    {
      this.cboPersonal.SelectedIndex = -1;
      this.txtNombre.Text = "";
      this.txtClave.Text = "";
      this.txtRepetir.Text = "";
      this.cboTipo.SelectedIndex = -1;
      this.chkVigente.Checked = true;
      this.chkVigente.Enabled = false;
    }

    private void ActivarControles(bool estado)
    {
      this.gbEntidad.Enabled = estado;
      this.gbListado.Enabled = !estado;
      if( estado == true)
      {
        this.cboPersonal.Focus();
      }
      else
      {
        this.btnListar.Focus();
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.ActivarControles(false);
    }

    private void frmUsuario_Load(object sender, EventArgs e)
    {
      this.CargarDatos();
    }

    private void CargarDatos()
    {
      this.CargarPersonal();
    }

    private void CargarPersonal()
    {
      RNPersonal rn = new RNPersonal();
      List<Personal> trabajadores;
      try
      {
        trabajadores = rn.ListarVigentes();
        MisFunciones.EnlazarCombo(this.cboPersonal, trabajadores,
          "NombreCompleto", "Codigo");
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      RNUsuario rn;
      Usuario usuario;

      if( this.ValidateChildren() == true)
      {
        usuario = this.CrearEntidad();
        rn = new RNUsuario();
        try
        {
          if( this.Actual == null)
          {
            rn.Registrar(usuario);
          }
          else
          {
            rn.Actualizar(usuario);
          }
          this.ActivarControles(false);
        }catch(Exception ex)
        {
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private Usuario CrearEntidad()
    {
      return new Usuario
        {
          Personal = (Personal)this.cboPersonal.SelectedItem,
          Nombre = this.txtNombre.Text,
          Clave = this.txtClave.Text,
          Tipo = this.cboTipo.Text.Substring(0,1),
          Vigente = this.chkVigente.Checked 
        };
    }

    private void btnListar_Click(object sender, EventArgs e)
    {
      RNUsuario rn = new RNUsuario();
      List<Usuario> usuarios;

      try
      {
        usuarios = rn.Listar();

        MisFunciones.EnlazarDataGrid(this.dgvListado, usuarios, "No se encontraron usuarios", this.Text);
      }catch(Exception ex) {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }
  }
}
