using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    internal class OperationMultiply : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }
}
