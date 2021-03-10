using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface ICalc<T>
    {
        T Sum(T a, T b);
        T Div(T a, T b);
        T Multy(T a, T b);
        T Substr(T a, T b);
    }
}
