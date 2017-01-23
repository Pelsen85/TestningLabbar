#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NumberSystemConverter.ExceptionManager;
#endregion
// DO NOT CHANGE
namespace NumberSystemConverter
{
    class Program
    {
        static RomanNumeralConverter converter;

        static void Main(string[] args)
        {
            converter = new RomanNumeralConverter();
            string errorMessage;
            try
            {
                Run();
            }

            catch (OverflowException ofEx)
            {
                errorMessage = ofEx.Message;
                Console.WriteLine(errorMessage);
            }

            catch (Exception e)
            {
                errorMessage = e.Message;
                Console.WriteLine(errorMessage);
            }
        }

        static void Run()
        {
            #region Runs the program expecting only integral inputs and calls ConvertToRomanNumeral() upon receiving
            while (true)
            {
                int result;
                Console.WriteLine("Numeral Registry");
                Console.WriteLine("Acceptable Values     |     Non-Acceptable Values");
                Console.WriteLine("M - 1000              |     (D, L, I, X, V) + M");
                Console.WriteLine("D - 500               |     (L, X, V, I) + D");
                Console.WriteLine("C - 100               |     (L, V, I) + C");
                Console.WriteLine("L - 50                |     (V, I) + L");
                Console.WriteLine("X - 10                |     ");
                Console.WriteLine("V - 5                 |     ");
                Console.WriteLine("I - 1                 |     (I) + I + I + I + I\n");

                Console.WriteLine("Please enter an integer value OR roman numeral to be converted...");
                string userInput = Console.ReadLine();
                string[] eiwa = { "DM", "LM", "IM", "XM", "VM", "LD", "XD", "VD", "ID", "LC", "VC", "IC", "VL", "IL", "IIII" };

                try
                {

                    if (userInput.All(c => c >= '0' && c <= '9') && userInput != "")
                    {
                        Console.WriteLine(userInput + " = " + converter.ConvertToRomanNumeral(int.Parse(userInput)));
                    }
                    else if (userInput.All(c => c == 'M' || c == 'D' || c == 'C' || c == 'L' || c == 'X' || c == 'V' || c == 'I') &&
                            !eiwa.Any(c => userInput.Contains(c)))
                    {
                        Console.WriteLine(userInput + " = " + converter.ConvertFromRomanNumeral(userInput.ToCharArray().Select(c => c.ToString()).ToArray()));
                    }
                    
                    else if (userInput.All(c => c == 'D' || c == 'M'))
                    {
                        throw (new DmInputException());
                    }

                    else if (userInput.All(c => c == 'L' || c == 'M'))
                    {
                        throw (new LmInputException());
                    }

                    else if (userInput.All(c => c == 'I' || c == 'M'))
                    {
                        throw (new ImInputException());
                    }

                    else if (userInput.All(c => c == 'X' || c == 'M'))
                    {
                        throw (new XmInputException());
                    }

                    else if (userInput.All(c => c == 'V' || c == 'M'))
                    {
                        throw (new VmInputException());
                    }

                    else if (userInput.All(c => c == 'L' || c == 'D'))
                    {
                        throw (new LdInputException());
                    }

                    else if (userInput.All(c => c == 'X' || c == 'D'))
                    {
                        throw (new XdInputException());
                    }

                    else if (userInput.All(c => c == 'V' || c == 'D'))
                    {
                        throw (new VdInputException());
                    }

                    else if (userInput.All(c => c == 'I' || c == 'D'))
                    {
                        throw (new IdInputException());
                    }

                    else if (userInput.All(c => c == 'L' || c == 'C'))
                    {
                        throw (new LcInputException());
                    }

                    else if (userInput.All(c => c == 'V' || c == 'C'))
                    {
                        throw (new VcInputException());
                    }

                    else if (userInput.All(c => c == 'I' || c == 'C'))
                    {
                        throw (new IcInputException());
                    }

                    else if (userInput.All(c => c == 'V' || c == 'L'))
                    {
                        throw (new VlInputException());
                    }

                    else if (userInput.All(c => c == 'I' || c == 'L'))
                    {
                        throw (new IlInputException());
                    }

                    else if (userInput.All(c => (c == 'I' || c == 'I' || c == 'I' || c == 'I')))
                    {
                        throw (new IiiiInputException());
                    }

                    Console.Write("\nPress any key...");
                    Console.ReadKey();
                    Console.Clear();
                  
                }

                catch (OverflowException ofEx)
                {
                    throw new Exception("Don't type so many integers you moron!", ofEx.InnerException);
                }

                               
            }
            #endregion
        }
    }
}

