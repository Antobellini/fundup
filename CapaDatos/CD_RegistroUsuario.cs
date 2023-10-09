using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Runtime.CompilerServices;

namespace CapaDatos
{
    public class CD_RegistroUsuario
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public int InsertUsuario(Usuario u)   //Registrar nuevo usuario
        {
            int idUsuarioCreado = 0;
            comando.CommandText = "RegistrarUsuario";
            comando.CommandType = CommandType.StoredProcedure;

            /*parametros del sp: 
            @NOMBRE_USUARIO varchar(100),
		    @APELLIDO_USUARIO varchar(100),
		    @FNACIMIENTO_PERSONA datetime,
		    @DNI_USUARIO varchar(10),
		    @EMAIL_USUARIO varchar(100),
		    @CONTRASEÑA_USUARIO varchar(20),

		    @CALLE_DOMICILIO varchar(200),
		    @NUMERO_DOMICILIO int,

		    @ID_LOCALIDAD int
             */
            if(u.nombreUsuario != null)
                comando.Parameters.AddWithValue("@NOMBRE_USUARIO", u.nombreUsuario);

            if (u.apellidoUsuario != null)
                comando.Parameters.AddWithValue("@APELLIDO_USUARIO", u.apellidoUsuario);

            if (u.fechaNacimientoUsuario != null)
                comando.Parameters.AddWithValue("@FNACIMIENTO_PERSONA", u.fechaNacimientoUsuario);

            if (u.dniUsuario != null)
                comando.Parameters.AddWithValue("@DNI_USUARIO", u.dniUsuario);

            if (u.emailUsuario != null)
                comando.Parameters.AddWithValue("@EMAIL_USUARIO",u.emailUsuario);

            if (u.contraseñaUsuario != null)
                comando.Parameters.AddWithValue("@CONTRASEÑA_USUARIO", u.contraseñaUsuario);

            if (u.domicilioUsuario != null) {
                Domicilio domicilioCrear = new Domicilio();
                domicilioCrear = u.domicilioUsuario;
                string? calleCrear = domicilioCrear.calleDomicilio;
                int? numeroCrear = domicilioCrear.numeroDomicilio;

                comando.Parameters.AddWithValue("@CALLE_DOMICILIO", calleCrear);
                comando.Parameters.AddWithValue("@NUMERO_DOMICILIO", numeroCrear);
            }

            if(u.localidadUsuario != null)
            {
                Localidad localidadCrear = new Localidad();
                localidadCrear = u.localidadUsuario;
                int? idLocalidadCrear = localidadCrear.idLocalidad;

                comando.Parameters.AddWithValue("@ID_LOCALIDAD", idLocalidadCrear);
            }

            try
            {
                comando.Connection = conexion.AbrirConexion();
                idUsuarioCreado = Convert.ToInt32(comando.ExecuteScalar());

                conexion.CerrarConexion();
            }
            catch(Exception)
            {
                throw;
            }
            return idUsuarioCreado;  //retorna el id del usuario creado
        }

    }
}
