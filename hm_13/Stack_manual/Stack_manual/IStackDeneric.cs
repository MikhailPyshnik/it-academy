using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual
{
    interface IStackDeneric<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        void ShowArray();
    }
}
