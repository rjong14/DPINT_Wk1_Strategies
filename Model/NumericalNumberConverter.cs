using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.Model {
    class NumericalNumberConverter : INumberConverter {
        public string ToLocalString (int num) => num.ToString();
        public int ToNumerical (string num) => Int32.Parse(num);
    }
}
