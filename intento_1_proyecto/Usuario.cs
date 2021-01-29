using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intento_1_proyecto
{
    class Usuario
    {
        public string usuario;
        public string contraseña;
        public string nombre, apellido;
        public bool admin;
        public bool doctor;
        public bool paciente;
        public bool bloqueado = false;
        public bool Seguro;
    }
}
