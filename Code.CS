using System;

namespace Int64_Input_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input");
                string UserInpt = Console.ReadLine();
                Int64 UserInptToInt64 = Int64.Parse(UserInpt);
                Int64 LEnOfList = UserInptToInt64.ToString().Length;
                Int64 LoopTime = 0;
                string[] OutPut = new string[LEnOfList];

                while (UserInptToInt64 > 1)
                {
                    Int64 TemVal = 0;
                    TemVal = UserInptToInt64 % 16;
                    Console.WriteLine(TemVal); //Debug 
                    UserInptToInt64 = UserInptToInt64 / 16;
                    if (TemVal >= 0 && TemVal <= 9)
                    {
                        string TemValToString = TemVal.ToString();
                        OutPut[LoopTime] = TemValToString;
                    }
                    else if (TemVal == 10) { 
                        OutPut[LoopTime] = "A";
                    }
                    else if (TemVal == 11) { 
                        OutPut[LoopTime] = "B";
                    }
                    else if (TemVal == 12) { 
                        OutPut[LoopTime] = "C";
                    }
                    else if (TemVal == 13) { 
                        OutPut[LoopTime] = "D";
                    }
                    else if (TemVal == 14) { 
                        OutPut[LoopTime] = "E";
                    }
                    else if (TemVal == 15) { 
                        OutPut[LoopTime] = "F";
                    }
                    else
                    {
                        Console.WriteLine("Failed.");
                        break;
                    }
                    LoopTime = LoopTime + 1;
                }
                Array.Reverse(OutPut);
                Console.WriteLine("================");
                string OutPutToString = string.Join("", OutPut);
                Console.WriteLine("Hex val: " + OutPutToString);
                //foreach (var item in OutPut)
                //{
                //    Console.WriteLine(item);
                //}
            }
            catch
            {
                Console.WriteLine("Failed. Check Input");
            }
        }
    }
}
