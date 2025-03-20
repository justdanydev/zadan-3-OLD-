using Math_Practice3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания: ");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Number1 number1 = new Number1(2, 23, 12);
                        number1.L();
                        break;
                    case 2:
                        Number2 number2 = new Number2(345, 34, 987);
                        number2.L();
                        break;
                    case 3:
                        Number3 number3 = new Number3(543, 4);
                        number3.A();
                        break;
                    case 4:
                        Number4 number4 = new Number4(2, 6);
                        number4.F();
                        break;
                    case 5:
                        Number5 number5 = new Number5(21, 2, 32, 9);
                        number5.G();
                        break;
                    case 6:
                        Number6 number6 = new Number6(4, 53, 2, 5);
                        number6.K();
                        break;
                    case 7:
                        Number7 number7 = new Number7(3, 54, 32);
                        number7.D();
                        break;
                    case 8:
                        Number8 number8 = new Number8(2, 3, 4, 5);
                        number8.P();
                        break;
                    case 9:
                        Number9 number9 = new Number9(3, 2, 6);
                        number9.R();
                        break;
                    case 10:
                        Number10 number10 = new Number10(4, 3);
                        number10.U();
                        break;
                    case 11:
                        Number11 number11 = new Number11(3, 2);
                        number11.I();
                        break;
                    case 12:
                        Number12 number12 = new Number12(4, 5, 5);
                        number12.G();
                        break;
                    case 13:
                        Number13 number13 = new Number13(3, 6, 6);
                        number13.R();
                        break;
                    case 14:
                        Number14 number14 = new Number14(2);
                        number14.R();
                        break;
                    case 15:
                        Number15 number15 = new Number15(3, 5);
                        number15.N();
                        break;
                    case 16:
                        Number16 number16 = new Number16(2, 7, 9);
                        number16.P();
                        break;
                    case 17:
                        Number17 number17 = new Number17(12, 2, 3, 65);
                        number17.T();
                        break;
                    case 18:
                        Number18 number18 = new Number18(2, 5);
                        number18.S();
                        break;
                    case 19:
                        Number19 number19 = new Number19(3, 2, 4, 5, 6);
                        number19.D();
                        break;
                    case 20:
                        Number20 number20 = new Number20(2, 3, 1, 6, 5);
                        number20.U();
                        break;
                    case 21:
                        Number21 number21 = new Number21(2, 3, 2);
                        number21.N();
                        break;
                    case 22:
                        Number22 number22 = new Number22(2, 2);
                        number22.F();
                        break;
                    case 23:
                        Number23 number23 = new Number23(3, 1, 6, 7);
                        number23.F();
                        break;
                    case 24:
                        Number24 number24 = new Number24(2, 4, 67, 7);
                        number24.F();
                        break;
                    case 25:
                        Number25 number25 = new Number25(2, 3, 4);
                        number25.J();
                        break;
                    case 26:
                        Number26 number26 = new Number26(2, 3, 5);
                        number26.U();
                        break;
                    case 27:
                        Number27 number27 = new Number27(6, 3, 8, 5);
                        number27.P();
                        break;
                    case 28:
                        Number28 number28 = new Number28(2, 4, 6, 3);
                        number28.G();
                        break;
                    case 29:
                        Number29 number29 = new Number29(2, 3, 33);
                        number29.R();
                        break;
                    case 30:
                        Number30 number30 = new Number30(10);
                        number30.K();
                        break;
                    default:
                        Console.WriteLine("Напиши номер правильно обмудень.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
