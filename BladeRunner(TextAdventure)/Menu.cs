using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BladeRunner_TextAdventure_
{
    class Menu
    {
        public int Index;
        public string Prompt;
        public string[] Options;

        public Menu(string prompt, string[] options)
        {
            
            Prompt = prompt;
            Options = options;
            Index = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            WriteLine(" ");
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string marker; 
                if (i==Index)
                {
                    marker = "-> ";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    marker = "   ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{marker} <<{currentOption}>>");

            }
            Console.CursorVisible = false;
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                /*
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                   ||||||||    ||          ||||||||||  ||||||||    ||||||||||            |||||||||   ||      ||  ||      ||  ||      ||  ||||||||||  |||||||||   ");
                Console.WriteLine("                   ||||  ||||  ||          ||      ||  |||    |||  |||                   |||    |||  ||      ||  ||||    ||  ||||    ||  |||         |||    |||  ");
                Console.WriteLine("                   ||||||||||  ||          ||||||||||  ||      ||  ||||||||||            ||||||||||  ||      ||  ||  ||  ||  ||  ||  ||  ||||||||||  ||||||||||  ");
                Console.WriteLine("                   ||||  ||||  ||          ||      ||  |||    |||  |||                   ||      ||  ||      ||  ||    ||||  ||    ||||  |||         ||      ||  ");
                Console.WriteLine("                   ||||||||    ||||||||||  ||      ||  ||||||||    ||||||||||            ||      ||  ||||||||||  ||      ||  ||      ||  ||||||||||  ||      ||  ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                */
                string s = @"

 ______         _______ ______  _______       ______ _     _ __   _ __   _ _______  ______
 |_____] |      |_____| |     \ |______      |_____/ |     | | \  | | \  | |______ |_____/
 |_____] |_____ |     | |_____/ |______      |    \_ |_____| |  \_| |  \_| |______ |    \_
";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(s);
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;

                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    Index--;
                    if (Index ==-1)
                    {
                        Index = Options.Length - 1;
                    }
                }
                else if(keyPressed==ConsoleKey.DownArrow)
                {
                    Index++;
                    if (Index == Options.Length)
                    {
                        Index = 0;
                    }
                }


            } while (keyPressed != ConsoleKey.Enter);

            return Index;
        }


    }
}
