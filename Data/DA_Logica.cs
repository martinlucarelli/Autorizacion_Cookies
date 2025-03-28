using Proyecto_Autorizacion.Models;

namespace Proyecto_Autorizacion.Data
{
    public class DA_Logica
    {

        public List<Usuario> ListaUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario {Nombre="jose",Correo="admin@gmail.com",Clave="123",Roles=new[] {"Administrador"}},
                new Usuario {Nombre="jose",Correo="supervisor@gmail.com",Clave="123",Roles=new[] {"Supervisor"}},
                new Usuario {Nombre="jose",Correo="empleado@gmail.com",Clave="123",Roles=new[] {"Empleado"}}


            };
        }

        public Usuario ValidarUsuario(string _correo, string _clave)
        {

            return ListaUsuarios().Where(item=> item.Correo== _correo && item.Clave == _clave).FirstOrDefault();


        }


    }
}
