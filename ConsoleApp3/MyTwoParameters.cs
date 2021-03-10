using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class MyTwoParameters <Tkey, Tvalue>
    {
        public Tkey Key
        {
            get; set;
        }

        public Tvalue Value
        {
            get; set;
        }

        public MyTwoParameters()
        {
            Key = default;
            Value = default;
        }

        public MyTwoParameters(Tkey key, Tvalue val)
        {
            Key = key;
            Value = val;
        }
        public override string ToString()
        {
            return $"Key: {Key}; Value: {Value};";
        }
    }
}
