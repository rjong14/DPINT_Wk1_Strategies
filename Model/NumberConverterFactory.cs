using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk1_Strategies.Model {
    class NumberConverterFactory {
        public IEnumerable<string> ConverterNames => converters.Keys;
        private Dictionary<string, INumberConverter> converters;
        public NumberConverterFactory () => converters=new Dictionary<string, INumberConverter> {
            ["Numerical"]=new NumericalNumberConverter (),
            ["Roman"]=new RomanNumberConverter (),
            ["Hexadecimal"]=new HexadecimalNumberConverter (),
            ["Binary"]=new BinaryNumberConverter ()
        };
        public INumberConverter GetConverter(string name) => converters[name];
    }
}
