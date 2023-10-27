using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksLib.TankiOnline;
namespace ConsoleApp.Module7.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank t34Tank = new Tank("Пантера 34");
            Tank panteraTank = new Tank("Тигр танк");
            Tank t34Tank4 = new Tank("Пантера 34");

            {
                if (t34Tank != null && panteraTank != null)// Проверка на null перед использованием оператора "^"
                {
                    if (t34Tank ^ panteraTank)
                    {
                        Console.WriteLine("Пантера 34 победил Тигр танк!");
                    }
                    else
                    {
                        Console.WriteLine("Тигр танк победил Пантера 34!");
                    }
                }
                else
                {
                    Console.WriteLine("Один или оба танка не были убиты.");
                }


                try
                {
                    Console.WriteLine(t34Tank4.GetTankParameters());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

        }
    }
}

