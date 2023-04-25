using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRodriguezMascotas
{
    public class clsMascota
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string TipoMascota { get; set; }

        public Image FotoMascota { get; set; }

        public string AlimentarMascota()
        {
            return Nombre + "" + "La mascota fue alimentada";
        }

        public string JugarConMascota()
        {
            return Nombre + "" + "Esta feliz porque jugaste con el";
        }

        public string CuidarMascota()
        {
            return "Cuidaste muy bien de" + "" + Nombre;
        }

            
    }
}
