using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakTOk
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = "THe winner is";
            string num1 = "1";
            string num2 = "2";
            string num3 = "3";
            string num4 = "4";
            string  num5 = "5";
            string num6 = "6";
            string num7 = "7";
            string num8 = "8";
            string num9=  "9";
            int Deminder = 1;
            
          

       
            while (true)
            {
                for (int i = 0; i < 100; i++)
                {

                    if (((num1 == num2 && num2 == num3) && num1 == "X") ||( (num4 == num5 && num5 == num6) && num5 == "X" )||( (num7 == num8 && num8 == num9)&&  num7=="X" )||( (num1 == num5 && num5 == num9) &&  num1=="X")||( (num3 == num5 && num5 == num7)&&  num3=="X" )||( (num1 == num4 && num4 == num7) &&  num1=="X")||( (num2 == num5 && num5 == num8) &&  num2=="X")||( (num3 == num6 && num6 == num9)&&  num3=="X"))
                    {
                        Console.WriteLine("The winner is player one ");
                        i = 400;
                    }
                    string[,] NUMBERS = new string[,]{
            {num1,num2,num3},

            {num4,num5,num6},

            {num7,num8,num9}
            
            
            };
                  for (int c = 0; c < 3; c++)
                  {
                     
                      for (int k = 0; k < 3; k++)
                      {
                          
                          Console.Write("          " + NUMBERS[c, k] + "      ");


                      }
                      Console.WriteLine();
                      Console.WriteLine("----------------------------------------------------------");
                      Console.WriteLine();
                  }
                  if (Deminder % 2 != 0) { Console.WriteLine("Player one :please insert a number "); }
                  if (Deminder % 2 == 0) { Console.WriteLine("player two :please insert a number  "); }
                  string x = Console.ReadLine();
                  int y;
                  Console.Clear();
                  if (Int32.TryParse(x, out y))
                  {
                      if (y > 9) { Console.WriteLine("please just between 1 to 9"); }


                      if ((y == 1) &&(num1=="X"||num1=="O") ) {

                          Console.WriteLine("Please enter another number ");
                          break;
                      
                      }
                      if ((y == 2) && (num2 == "X" || num2 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 3) && (num3 == "X" || num3 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 4) && (num4 == "X" || num4 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 5) && (num5 == "X" || num5 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 6) && (num6 == "X" || num6 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 7) && (num7 == "X" || num7 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 8) && (num8 == "X" || num8 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if ((y == 9) && (num9 == "X" || num9 == "O"))
                      {

                          Console.WriteLine("Please enter another number ");
                          break;

                      }
                      if (y == 1 && Deminder % 2 != 0)
                      {
                          num1 = "X";
                          
                      }

                      if (y == 2 && Deminder % 2 != 0)
                      {
                          num2 = "X";
                      }



                      if (y == 3 && Deminder % 2 != 0)
                      {
                          num3 = "X";
                      }

                      if (y == 4 && Deminder % 2 != 0)
                      {
                          num4 = "X";
                      }

                      if (y == 5 && Deminder % 2 != 0)
                      {
                          num5 = "X";
                           }

                      if (y == 6 && Deminder % 2 != 0)
                      {
                          num6 = "X";
                      }

                      if (y == 7 && Deminder % 2 != 0)
                      {
                          num7 = "X";
                      }

                      if (y == 8 && Deminder % 2 != 0)
                      {
                          num8 = "X";
                      }

                      if (y == 9 && Deminder % 2 != 0)
                      {
                          num9 = "X";
                      }



                          if (y == 1 && Deminder % 2 == 0)
                      {
                          
                          num1 = "O";
                      }

                      else          if (y == 2 && Deminder % 2 == 0)
                      {
                          num2 = "O";
                      }



                      else  if (y == 3 && Deminder % 2 == 0)
                      {
                          num3 = "O";
                      }

                      else   if (y == 4 && Deminder % 2 == 0)
                      {
                          num4 = "O";
                      }

                      else   if (y == 5 && Deminder % 2 == 0)
                      {
                          num5 = "O";
                      }

                      else if (y == 6 && Deminder % 2 == 0)
                      {
                          num6 = "O";
                      }

                      else if (y == 7 && Deminder % 2 == 0)
                      {
                          num7 = "O";
                      }

                      else if (y == 8 && Deminder % 2 == 0)
                      {
                          num8 = "O";
                      }

                      else if (y == 9 && Deminder % 2 == 0)
                      {
                          num9 = "O";
                      }
                      Deminder++;
                  }
                  else
                  {
                      Console.WriteLine("That is not even a number");
                  }
                }
            }

        }
    }
}
