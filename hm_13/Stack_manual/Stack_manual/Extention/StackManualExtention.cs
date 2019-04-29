using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_manual.Extention
{
    public static class StackManualExtention
    {
        public static int CapacityInt(this StackManual stackManual)
        {
            int result;
            result = stackManual.Lenght-1 - stackManual.GetIndex;
            return result; 
        }

        public static void CapacityString(this StackManual stackManual)
        {
            int result;
            result = stackManual.Lenght-1 - stackManual.GetIndex;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Stack  has  {result} free item(s).");
            Console.ResetColor();
        }
    }
}
