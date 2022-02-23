using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Murderer
{
    class WeaponException:Exception
    {
        public WeaponException(string name)
        : base("Geçersiz silah girildi.")
        {
            
        }
    }
}
