using System;

namespace Practical_9_6_Task_2
{
    public delegate void EventDelegateEmployee(int number);

    internal class Program
    {
        static Employee employee;
        static void Main(string[] args)
        {
            bool @bool = true;

            employee = new Employee();
            employee.sortEvent += HandleEventSort;
            employee.GetListEmploee(5);

            while (@bool)
            {
                try
                {
                    employee.CheckСorrectInput();
                    @bool = false;
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                    @bool = true;
                }
            }

            Console.ReadKey();
        }
        //Метод обработчика события.
        static void HandleEventSort(int number)                   
        {
            switch (number)
            {
                case 1:
                    employee.GetSortList();              
                    break;
                case 2:
                    employee.GetSortReversList();
                    break;
            }
        }
    }
}
