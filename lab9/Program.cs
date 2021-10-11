using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число. ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. ");
                b = Convert.ToInt32(Console.ReadLine());
                double result = 0;

                Console.WriteLine("Введите операции:");
                Console.WriteLine("\t1 - сложение");
                Console.WriteLine("\t2 - вычитание");
                Console.WriteLine("\t3 - умножение");
                Console.WriteLine("\t4 - деление");

                Console.Write("Ваш выбор: ");
                int oper = Convert.ToInt32(Console.ReadLine());
                switch (oper)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }
                

                //операции
                if (oper == 1)
                {
                    result = a + b;
                    Console.WriteLine("Результат ={0}", result);
                }
                else
                {
                    if (oper == 2)
                    {
                        result = a - b;
                        Console.WriteLine("Результат ={0}", result);
                    }
                    else
                    {
                        if (oper == 3)
                        {
                            result = a * b;
                            Console.WriteLine("Результат ={0}", result);
                        }
                        else
                        {
                            if (oper == 4)
                            {
                                result = a / b;
                                Console.WriteLine("Результат ={0}", result);
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.Write("Ошибка! Неверный формат данных.");
            }
            catch(DivideByZeroException) when (a ==0 && b ==0)
            {
                Console.Write("Ошибка! Деление 0 на 0.");
            }
            catch (DivideByZeroException)
            {
                Console.Write("Ошибка! Деление на 0.");
            }



            Console.ReadKey();
        }
    }
}
