using System;

namespace Practical_9_6_Task_1
{
    internal partial class Program
    {
        class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }
    }
}
