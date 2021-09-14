using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BladeRunner_TextAdventure_
{
    class Game
    {

        public void Start()
        {
            RunMainMenu();
        }

        public void RunMainMenu()
        {
            string prompt = "Welcome to the Blade Runner text adventure game! Please select an option below. (use the arrow keys)";
            string[] options = new string[3];
            options[0] = "Play";
            options[1] = "About";
            options[2] = "Exit";

            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run();

            switch (Index)
            {
                case 0:
                    
                    PlayGame1();
                    break;

                case 1:
                    AboutInfo();
                    break;

                case 2:
                    ExitGame();
                    break;

            }

            WriteLine("");
            WriteLine("End of Line");
        }

        
        public void ExitGame()
        {
            WriteLine("---------------------------------------------");
            ReadKey(true);
            Environment.Exit(0);
        }
        public void AboutInfo()
        {
            Clear();
            string a =@"This game is based on the movie Blade Runner, its sequal, Blade Runner: 2049, and the original insperation 
for the movie the book ""Do Androids Dream of Electric Sheep"" by Philip K. Dick. There are many paths to this game but only one path 
results in the completion of the game. Keep your eye out for clues and have fun.";
            WriteLine(a);
            WriteLine("");
            WriteLine("Created by: Nick Stockton");
            ReadKey(true);
            RunMainMenu();
            
        }
        public void PlayGame1()
        {
            Clear();
            WriteLine("---------------------------------------------");
            WriteLine(@"    Early in the 21st Century, the TYRELL
CORPORATION advanced Robot evolution
into the NEXUS phase-a being virtually
identical to a human-known as a Replicant.
    The NEXUS 6 Replicants were supirior 
in strength and agility, and atleast equal
in intelligence, to the engineers 
who created them.
Replicants were used off world as
slave labor, in hazardous exploration and 
colinization of other planets.
    After a bloody mutiny by a NEXUS 6
combat team in an Off-World colony, 
Replicants were declared illegal
on earth-under penalty of death.
    Special police squads-BLADE RUNNER
UNITS-had orders to shoot to kill, upon
detection, ant tresspassing Replicant.

    This was not called execution.
    It was called retirement.");
            
            ExitGame();
        }







    }
}
