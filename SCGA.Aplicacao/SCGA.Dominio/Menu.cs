using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Dominio
{
    public class Menu :EntidadePadrao
    {
        public Menu()
        {
            this.MenusFilhos = new List<Menu>();
            this.PerfisUsuario = new List<PerfilUsuarioMenu>();
        }

        public int Sequencia { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string Formulario { get; set; }
        public int? MenuPai_Id { get; set; }

        public virtual Menu MenuPai { get; set; }
        public virtual ICollection<Menu> MenusFilhos { get; set; }
        public virtual ICollection<PerfilUsuarioMenu> PerfisUsuario { get; set; }
    }
}
