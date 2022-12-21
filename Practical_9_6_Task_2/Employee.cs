using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_9_6_Task_2
{
    internal class Employee
    {        
        public event EventDelegateEmployee sortEvent = null;

        private List<string> surnamesList = new List<string>();
        
        /// <summary>
        /// Вызывает событие
        /// </summary>        
        public void InvokeEvent(int number)
        {
            sortEvent.Invoke(number);
        }

        /// <summary>
        /// Добовляет в список фамилии сотрудников
        /// </summary>        
        public void GetListEmploee(int x)                       
        {
            surnamesList = new List<string>(x);
            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                num++;
                Console.Write($"Введите фамилию {num} - го  сотрудника: ");
                surnamesList.Add(Console.ReadLine());
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Проверяет корректный ввод...
        /// </summary>        
        public void CheckСorrectInput()                                  
        {
            int number;

            Console.Write("Как вы хотите отсортировать список: 1 - (А-Я) или 2 - (Я-А) ");

            //Проверяем корректный ввод или нет...            
            if (!int.TryParse(Console.ReadLine(), out number) || (number != 1 && number != 2))
                throw new MyException("Не верный ввод! Введите число 1 или 2.");
            
            InvokeEvent(number);
        }
        
        //Возрастающая сортировка (А - Я)
        public void GetSortList()                                            
        {
            surnamesList.Sort();

            Console.WriteLine();
            Console.WriteLine("/Возрастающая сортировка (А - Я)/");
            foreach (string surname in surnamesList)
            {
                Console.WriteLine(surname);
            }
        }
        //Убывающая сортировка (Я - А)
        public void GetSortReversList()                          
        {
            surnamesList.Sort();
            surnamesList.Reverse();

            Console.WriteLine();
            Console.WriteLine("/Убывающая сортировка (Я - А)/");
            foreach (string surname in surnamesList)
            {
                Console.WriteLine(surname);
            }
        }
    }
}
