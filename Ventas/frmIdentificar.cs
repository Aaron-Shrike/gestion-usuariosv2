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

  public partial class frmIdentificar : Form
  {

    private Usuario Usuario;

    public frmIdentificar()
    {
      InitializeComponent();
    }

    public  Usuario Identificar()
    {
      this.ShowDialog();

      return this.Usuario;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Usuario = null;
      this.Close();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      RNUsuario rn;

      if( this.ValidateChildren () == true) {
        this.Usuario = this.CrearEntidad();

        rn = new RNUsuario();
        try
        {
          this.Usuario = rn.Verificar(this.Usuario);
          if( this.Usuario != null)
          {
            this.Close();
          }
          else
          {
            MessageBox.Show("Las credenciales no son válidas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtUsuario.Text = "";
            this.txtClave.Text = "";
            this.txtUsuario.Focus();
          }
        }catch(Exception ex){
          MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private Usuario CrearEntidad()
    {
      return new Usuario
      {
        Nombre = this.txtUsuario.Text,
        Clave = this.txtClave.Text
      };
    }
  }
}
