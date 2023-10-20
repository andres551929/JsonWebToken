namespace NetCoreJWT.Models
{
    public class Usuario
    {
        public string? idUsuario { get; set; }
        public string? usuario { get; set; }
        public string? password { get; set; }
        public string? rol { get; set; }

        public static List<Usuario> DB()
        {
            var list = new List<Usuario>() {
                        new Usuario
            {
                idUsuario = "1",
                usuario = "mateo",
                password = "password",
                rol = "empleado"
            },
             new Usuario
             {
                 idUsuario = "2",
                 usuario = "lucas",
                 password = "password",
                 rol = "administrador"
             },
                  new Usuario
                  {
                      idUsuario = "3",
                      usuario = "juan",
                      password = "password",
                      rol = "asesor"
                  },
                     new Usuario
                  {
                      idUsuario = "4",
                      usuario = "marcos",
                      password = "password",
                      rol = "empleado"
                  }
        };

            return list;


        }
    }
}
