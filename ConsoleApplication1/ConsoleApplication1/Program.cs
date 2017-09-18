using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    class Program
    {

       
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Выберите действие: + - * /");
            Console.ReadLine();
            string plus = "+";
           
            
            if (plus == "+")
            {
                bool Wbr =  true;

                while (Wbr)
                {
                    Console.WriteLine("Введите первое число: ");
                    double FirstSlojenie = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите первое число: ");
                    double SecondSlojenie = Convert.ToDouble(Console.ReadLine());
                    double slojit = calc.slojenie(FirstSlojenie, SecondSlojenie);
                    Console.Write("Ответ: ");
                    Console.WriteLine(slojit);

                    Console.WriteLine("Вы можете выйти в меню или продолжить использовать операцию сложения: menu | stay");
                    Console.ReadLine();

                    if ("menu"=="menu")
                    {
                         //Возвращаемся в меню
                    }
                }
                    

                
            }
            string Minus = "-";
            if (Minus == "-")
            {
                Console.WriteLine("Введите первое число: ");
                double FirstMinus = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите первое число: ");
                double SecondMinus = Convert.ToDouble(Console.ReadLine());
                double minus = calc.minus(FirstMinus, SecondMinus);
                Console.Write("Ответ: ");
                Console.WriteLine(minus);
            }
            string Umnoj = "*";
            if (Umnoj == "*")
            {
                Console.WriteLine("Введите первое число: ");
                double FirstUmnojit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите первое число: ");
                double SecondUmnojit = Convert.ToDouble(Console.ReadLine());
                double umnojit = calc.umnojit(FirstUmnojit, SecondUmnojit);
                Console.Write("Ответ: ");
                Console.WriteLine(umnojit);
            }
            string del = "/";
            if( del == "/")
            {
                Console.WriteLine("Введите первое число: ");
                double FirstDelit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите первое число: ");
                double SecondDelit = Convert.ToDouble(Console.ReadLine());
                double delit = calc.delit(FirstDelit, SecondDelit);
                Console.Write("Ответ: ");
                Console.WriteLine(delit);
            }







            Console.ReadKey();

        }
    }
}
