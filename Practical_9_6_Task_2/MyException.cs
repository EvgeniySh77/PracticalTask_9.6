using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_9_6_Task_2
{
    internal class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
