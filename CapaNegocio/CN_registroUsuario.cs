using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_RegistroUsuario
    {
        CD_RegistroUsuario CD_RegistroUsuario= new CD_RegistroUsuario();
        public int InsertUsuario(Usuario usuarioCrear)
        {
            try
            {
                return CD_RegistroUsuario.InsertUsuario(usuarioCrear);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
