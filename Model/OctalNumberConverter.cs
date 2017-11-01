using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.Model {
    class OctalNumberConverter : INumberConverter {
        public string ToLocalString (int num) => Convert.ToString (num, 8);
        public int ToNumerical (string num) => Convert.ToInt32 (num, 8);
    }
}
