using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srevels2e1
{
    class LogicalOperations
    {

        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }

        public static bool q02(int timeinservice)
        {
            return timeinservice <= 4 || timeinservice >= 12;
        }
            


    }
}
