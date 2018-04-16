using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class ModeleAvecOptionPeintureMetal : ModeleAvecOption
    {
        public ModeleAvecOptionPeintureMetal(Modele initial) : base(initial, 800.0) { }
    }
}
