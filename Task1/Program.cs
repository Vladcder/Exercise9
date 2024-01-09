using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");   
            int[] operands=new int[2];
            string[] operandsNames = new string[2] { "X", "Y" };
            string[] operationsName = new string[4] { "сложение", "вычитание", "произведение", "частное" };
            for (int i=0; i<2; i++)
            {
                Console.Write($"Введите целое число. {operandsNames[i]}=");
                try
                {
                    operands[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка! " +e.Message);
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Введите код операции:");
            for (int i=0;i<operationsName.Length; i++)
            {
                Console.WriteLine($"     {i+1} - {operationsName[i]}");
            }
            Console.Write("Ваш выбор: ");
            try
            {
                int operation = Convert.ToInt32(Console.ReadLine());
                if (operation<=0||operation>operationsName.Length)
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
                else
                {
                    Console.WriteLine("Результат = "+ CalculateResult(operation, operands[0], operands[1]));
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


        }

        static long CalculateResult(int operation, int operand1, int operand2)
        {
             long result = 0;

            switch (operation)
            {
                case 1:
                    result = operand1 + operand2; break;
                case 2:
                    result = operand1 - operand2; break;
                case 3:
                    result = operand1 * operand2; break;
                case 4:
                    result = operand1 / operand2; break;               
            }
            return result;
        }
    }
}
