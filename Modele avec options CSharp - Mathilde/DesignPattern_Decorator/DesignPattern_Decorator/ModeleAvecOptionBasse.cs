using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class ModeleAvecOptionBasse : ModeleAvecOption
    {
        public ModeleAvecOptionBasse(Modele initial) : base(initial, 140.0) { }
    }
}
