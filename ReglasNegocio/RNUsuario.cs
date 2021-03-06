using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;

namespace ReglasNegocio
{
  public class RNUsuario
  {
      string uno = Properties.Settings.Default.Fabrica;
    public void Registrar(Usuario usuario)
    {
//      string sql = $@"INSERT INTO Usuario( CodigoPersonal, Nombre, Clave, Tipo, Vigente)
//            VALUES({usuario.Personal.Codigo}, '{usuario.Nombre}', '{usuario.Clave}', 
//            '{usuario.Tipo}', 1)";
        string sql = @"INSERT INTO Usuario( CodigoPersonal, Nombre, Clave, Tipo, Vigente)
            VALUES(" + usuario.Personal.Codigo + ",'" + usuario.Nombre + "','" + 
            usuario.Clave + "','" + usuario.Tipo + "', 1)";
      try
      {
          using (DAL dal = new DAL("System.Data.SqlClient",
          ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
        {
          dal.EjecutarOrden(sql);
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public void Actualizar(Usuario usuario)
    {
      
      //try
      //{
      //  using (DAL dal = new DAL("System.Data.SQLClient",
      //    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
      //  {
      //    dal.EjecutarOrden(sql);
      //  }
      //}
      //catch (Exception ex)
      //{
      //  throw ex;
      //}
    }

    public List<Usuario> Listar()
    {
      List<Usuario> usuarios = null;
//      string sql = $@"SELECT U.Codigo, P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno, U.Nombre
//            	FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
//            	ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";
        string sql = @"SELECT U.Codigo, P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno, U.Nombre
            	FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
            	ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

        try
      {
          using (DAL dal = new DAL("System.Data.SqlClient",
          ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
        {
          using (IDataReader dr = dal.EjecutarOrden(sql, true))
          {
            usuarios = new List<Usuario>();
              while (dr.Read() == true)
              {
                usuarios.Add(
                  new Usuario
                  {
                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                    Personal = new Personal
                    {
                      Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                      ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                      ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))
                    }
                  }
                  );
              }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      return usuarios;
    }

    public Usuario Verificar(Usuario usuario)
    {
      Usuario usu = null;
//      string sql = $@"SELECT U.Codigo, U.CodigoPersonal, P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno
//	                      FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
//	                      WHERE U.Nombre = '{usuario.Nombre}' AND U.Clave = '{usuario.Clave}' AND 
//                              U.Vigente = 1";
        string sql = @"SELECT U.Codigo, U.CodigoPersonal, P.Nombres, P.ApellidoPaterno, P.ApellidoMaterno
	                      FROM Personal P JOIN Usuario U ON U.CodigoPersonal = P.Codigo
	                      WHERE U.Nombre = '"+usuario.Nombre+"' AND U.Clave = '"+usuario.Clave+"' AND U.Vigente = 1";

        try
      {
          using (DAL dal = new DAL("System.Data.SqlClient",
          ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
        {
          using (IDataReader dr = dal.EjecutarOrden(sql, true))
          {
            if (dr.Read() == true)
              {
                usu = new Usuario
                {
                  Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                  Nombre = usuario.Nombre,
                  Vigente = true,
                  Personal = new Personal
                  {
                    Codigo = dr.GetInt16( dr.GetOrdinal("CodigoPersonal")),
                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))
                  }
                };
              }
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }

      return usu;
    }

  }
}
