using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class ModeleAvecOptionJanteAlu : ModeleAvecOption
    {
        public ModeleAvecOptionJanteAlu(Modele initial) : base(initial, 600.0) { }
    }
}
