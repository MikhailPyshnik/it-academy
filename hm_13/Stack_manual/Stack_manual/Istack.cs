using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual
{
    interface IStack
    {
        void Push(object value);

        object Pop();

        object Peek();
                
        void ShowArray();
    }
}
