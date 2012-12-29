using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio
{
    public class PerfilUsuarioMenu : EntidadePadrao
    {
        public int MenuPermitido_Id { get; set; }
        public int Perfil_Id { get; set; }

        public Menu MenuPermitido { get; set; }
        public PerfilUsuario Perfil { get; set; }
    }
}
