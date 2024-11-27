using System;

namespace project9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choise the day:");
            var day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("choise the month:");
            var month = Int32.Parse(Console.ReadLine());
            if (day > 1)
            {
                day -= 1;
            }
            else
            {
             switch (month)
                         {
                             case 1:
                                 day = 31;
                                 month = 12;
                                 break;
                             case 2:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 3:
                                 day = 28;
                                 month = month - 1;
                                 break;
                             case 4:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 5:
                                 day = 30;
                                 month = month - 1;
                                 break;
                             case 6:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 7:
                                 day = 30;
                                 month = month - 1;
                                 break;
                             case 8:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 9:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 10:
                                 day = 30;
                                 month = month - 1;
                                 break;
                             case 11:
                                 day = 31;
                                 month = month - 1;
                                 break;
                             case 12:
                                 day = 30;
                                 month = month - 1;
                                 break;
                             default:
                                 Console.WriteLine("Invalid month");
                                 break;   
            }
            
            }
            Console.WriteLine($"предедуший день {(day) + "." + (month)}");
        }
    }
}