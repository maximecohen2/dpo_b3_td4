using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class ModeleBase : Modele
    {
        public override double Prix { get { return 10000.0; } }
    }
}
