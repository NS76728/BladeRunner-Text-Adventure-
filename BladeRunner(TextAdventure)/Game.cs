using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BladeRunner_TextAdventure_
{
    class Game
    {
        public void EndTitle()
        {
            ReadKey();
            Clear();
            WriteLine(@"


All these moments will be lost in time, like tears in rain.");
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(@"

 _______ _     _ _______      _______ __   _ ______ 
    |    |_____| |______      |______ | \  | |     \
    |    |     | |______      |______ |  \_| |_____/
                                                    

");
            Console.ForegroundColor = ConsoleColor.Red;
            ReadKey();
        }
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
            int Index = mainMenu.Run(true);

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

        }
        public void ExitGame()
        {
            WriteLine("Press Enter");
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
            string prompt = "Welcome to the Blade Runner text adventure game! Please select an option below. (use the arrow keys)";
            string[] options = new string[3];
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
detection, any tresspassing Replicant.

    This was not called execution.
    It was called retirement.");
            WriteLine("---------------------------------------------");

            ReadKey(true);
            story1();
           
        }
        public void story1()
        {
            Clear();
            WriteLine(@"The year is 2025. The aftermath of World War Terminus has left the world a bitter place. 
Los Angeles use to be a bright and vibrant city but now as you, Philip Scott, fly into the landing bays
of the LA police precinct you cant help but wonder what it would have been like to live in a time where you could see the
sun and it not be blocked out by the smog and dust in the air. You walk into the office space of the precinct
and meander your way to your desk and start organizing your files.");
            ReadKey();
            story2();
        }
        public void story2()
        {
            Clear();
            WriteLine(@"The sergeant walks up to you and asks ""So why did that old woman ask for a Blade Runner?""
With a slight cuckle you respond with ""That old lady wanted me to test her husband, of 50 years mind you, 
if he was a replicant. It didnt help that he looked like an old catchers mitt, but I obliged her and of
course he wasnt one. She didnt believe me though. I think she had dementia or something, but it 
was an interesting morning.""" );
            ReadKey();
            story3();
        }
        public void story3()
        {
            Clear();
            WriteLine(@"""Well I got a new assignment for you. About 6 months ago, a families Nexus 6 killed its owner and a 
dozen other people while escaping the colony and its been missing ever since. We dont know what it looks like but based on
the families discription and a wearhouse managers account of a floor accident, we might have found it. So go down to this \
wearhouse and ask around."" The sergeant hands you a file with the assignments known details which 
includes the families videophone number.");

            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Call the family";
            options[1] = "Go to the wearhouse";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    CallFamily();
                    break;

                case 1:
                    Gotowearhouse();
                    break;

                case 2:
                    ExitGame();
                    break;
            }

        }
        public void CallFamily()
        {
            Clear();
            WriteLine(@"You go to the corner of your desk and start dialing on the videophone. It rings for a few moments  
then a young boy answers the phone. He says ""Hello?"" You respond with ""Hello, is this the Shwarts house?"" and the
little boy timidly responds with ""Um...yes?"" Understanding that the boy is nervous you ask ""May I speak to your mother?"" The
boy then runs away from the phone and screams ""Mom theres some guy on the phone!"" After a few moments a woman who seems to
be in her late thirties comes into view of the phone. ""Hello this is Mrs. Shwarts what can I do for you?""  ");
            ReadKey(true);
            Clear();
            WriteLine(@"""Hello, this is Philip Scott, I'm a blade runner and I just have a couple questions for you.""

""Oh, okay officer but I already filed a report with the local police.""

""I know but I need information thats not in the report. So your Replicant, Roy, you got him as incentive for immigrating correct?""

""No, we bought him as a special order."" 

""What do you mean?""

""We ordered one of the ones that you have to pay extra, the ones that have memories already installed. 
We thought it would make him more personal and less prone to what happend. Guess it was all for nothing.""

""Okay, can I get your order number for Roy? I'll have to call the Tyrell Corp and get more details on him.""

""Well I cant give you the order number because it was more of an under the table purchase.""

""That must be why we dont have anything on file about him. Well can you tell me who you talked to to order him?""

""Yes his name was Leon.""

""Alright thank you very much Mrs. Shwarts and sorry about your lose."" ");
            ReadKey(true);
            Clear();
            WriteLine(@"You waste no time and immediantly call the Tyrell Corp after hanging up on the Shwarts family.
After an hour of waiting on hold and being transfered across the whole sector you finally get in touch with Leon.
Then after a couple minutes of yelling and threatening an investigation for selling illigal unaproved replicants you
finally get the file on Roy.
    It has a complete discription of the memories that were implanted in Roy. He had a pretty nice so called childhood 
even having a pet cameleon. However, no tramadic experiences or abuse so no aparent reason for him to lose his mind.
This was leading no where so you decide to do some in person investigation.");
            ReadKey(true);
            Clear();
            Gotowearhouse();
        }
        public void Gotowearhouse()
        {
            Clear();
            WriteLine(@"You take a hover car to the wearhouse. When you arrive and enter ther main storage hall you find 
tall steel shelves with wooden crates about 1/2 meter by 1/2 meter. You ask around and find the wearhouse manager who
called in the tip. 
    He explains that the other day he witnessed another worker accidently pushed a crate off the top shelf while using a forklift
it then fell directly onto the worker in question. Each of these crates being about 150 kilograms and at 6 meters thats enough 
to kill any normal human but this worker took the hit and just walked off. 

""Well that explains why you gave us the call, either he's a veteran with some implants or the more likely he's a replicant.
What was his name?""

""Roy, he never gave me a last name though. We paid him in cash to avoid a background check which he was very insistant on.""

""Do you know anything else about him that could be useful, maybe a spot he liked to frequent?""

""I can do you one better, his address 9732 Ersatz Lane.""

Thank you for your help.");
            ReadKey(true);
            Clear();

            WriteLine(@"You go to the apartment, and it looks quite normal, to the untrained eye.
After a while of searching you find two note worthy things, a gun with its serial number scratched out
and on a blazer type jacket a scale. ");

            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Ask your informant about the gun";
            options[1] = "Investigate the scale";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Gun();
                    break;

                case 1:
                    Scale();
                    break;

                case 2:
                    ExitGame();
                    break;
            }
        }
        public void Gun()
        {
            Clear();
            WriteLine(@"The informant is a black market arms dealer, this would be the place to get an off the record firearm.

""Hey there Ricky.""

""What can I do ya for Phil?""

""Well first you can tell me who bought this gun.""
You put the gun on the table and slide it towards Ricky.

""Listen Phil, I cant go ratting out everyone I sell a gun to, I'd lose all my buissness.""

""Well if you dont tell me you'll definatly be out of buissness and in a prison cell.""

""Alright, jeeze, why'd you have to take it there man?""
Ricky examines the gun amd says, ""Yeah I sold two of these on the same day about two months ago.""

""To who Ricky?""

""Not every guy is going to be so forth coming, one guy didnt give a name but got into a Thornton truck that 
was black with a lime green door. And the other guy gave a name of Bryant Holden.""");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Confront Bryant";
            options[1] = "Investigate the truck";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Bryant();
                    break;

                case 1:
                    Truck();
                    break;

                case 2:
                    ExitGame();
                    break;
            }
        }
        public void Bryant()
        {
            Clear();
            WriteLine(@"Having found Holden's address you knock on his door. He answers with a polite ""Hello officer.""

""Alright Im going to get straight to the point, what did you do with that gun you bought from Ricky?""

Confused Holden steps back visibly getting nervous.
""I dont know what your talking about officer.""

""Oh cut the crap Holden, do you still have the gun or not? Im a blade runner so I dont care that its illegal 
I just need to know where it is.""

A bit surprised Holden replies with, ""Yeah I still got it, why?""

""When you were there was there another man who bought the same gun?""

""Yeah, I didnt know what to get so I just copied him.""

""Did you see hime get into a truck?""

""Yeah, it was black with a green door.""");
            ReadKey(true);
            Truck();
        }
        public void Truck()
        {
            Clear();
            WriteLine(@"You call dispatch and give them the dicription of the vehicle. A few minutes later they send you
the last known location of the truck. After a quick ride you find yourself in an ally way ajacent to the vehicle 
depot staring at the truck.");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Scout the Area";
            options[1] = "Search the Truck";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Scout();
                    break;

                case 1:
                    SearchTruck();
                    break;

                case 2:
                    ExitGame();
                    break;
            }
        }
        public void Scout()
        {
            Clear();
            WriteLine(@"The truck is in a narrow ally way, you originally aproached it from a T intersection so you can go left 
or right to start searching the area.");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Left";
            options[1] = "Right";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Left1();
                    break;

                case 1:
                    Right1();
                    break;

                case 2:
                    ExitGame();
                    break;
            }

        }
        public void Left1()
        {
            Clear();
            WriteLine(@"You start to walk away from the front of the truck. Roy has to be nearby something doesnt quite 
feel right in the air.
    Then a sharp noise hits your ear as an explosion erupts from behind the dumpster. The area becomes a tornado of 
brick shards and the air is filled with dust. The explosion sends the dumpster you flying towards you and 
catapulting you towards the opposite wall. For your last remaining moments you see the blood that you
just coughed up and the entery wound from the rebar that was pertruding from the dumpster. Then a blury figure runs past the 
newly fromed entrance. You try to stand but quickly realize that he won and fall back down into a pool of 
your own blood. And you think to yourself..... ");
            EndTitle();
          
        }
        public void Right1()
        {
            Clear();
            WriteLine(@"You walk away from the truck's bed. Looking for him or any possible trace of him. 
You get to the end of the ally way and look back wondering if you could have missed something.
    Then a deafaning explosion erupts at the other end of the ally way and you see a figure run into the building 
that just received a new door.
    Imidiantly you are in persute. You get to the opening and its a hallway. Which way did he go?");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Left";
            options[1] = "Right";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Left2();
                    break;

                case 1:
                    Right2();
                    break;

                case 2:
                    ExitGame();
                    break;
            }

        }
        public void Left2()
        {
            Clear();
            WriteLine(@"You run left down the hall but as you turn the corner you trip on a empty duffle bag.
You look up from your fall and there he is, the one, he truns around and reveals a light machine gun, which he opens fire with.
The bullets are flying past you but sure enough with that much volume of lead one will land. it goes straight through your 
upright head and with a quiet thud your lifeless body remains motionless. The last thought you had was....");
            EndTitle();
        }            
        public void Right2()
        {
            Clear();
            WriteLine(@"You run right down the hall turn the corner and come to a flight of stairs. At the top is 
a locked door. You kick the door in and reveal what appears to be an empty control room. And to your left is a window
to the court yard and you see him. He has climbed into a shuttle and is preparing to leave the planet.
    You think hopfully that there might be enough time to stop him but there isnt. The engines roar and he's gone.
    You sit down in one of the chairs and think to yourself...");
            EndTitle();
        }          
        public void SearchTruck()
        {
            Clear();
            WriteLine(@"You open the truck and sitting in the seat is a couple empty cases of what use to contain high 
intensity explosives and underneath you find a blue print of the vehicle depot. There's a circle over the wall adjacent 
to the ally way. The wall is apart of a hall way that leads left towards to the court yard with all the vehicles and right
to the control room. While examining the prints you hear a loud explosion down the ally way.
    You run towards where you heard the sound and theres a new entrance to the building that wasnt previously there before.
It leads to the hall way.");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Left";
            options[1] = "Right";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Left2();
                    break;

                case 1:
                    Right2();
                    break;

                case 2:
                    ExitGame();
                    break;
            }
        }
        public void Scale()
        {
            Clear();
            WriteLine(@"In order to find out what this scale could lead to, you must first know what type of scale it is
first. So you take it to a local market vendor who sells fish and other reptile like creaters. This little old asian woman takes
it and examines it under a microscope.

""This is not some normal scale like to a fish, its a camelon scale.""

""Do you recognize the work?""

""Yes, there's a man up the street here that sells camelons.""

""Thank you.""");
            ReadKey(true);
            Clear();
            WriteLine(@"You walk up the street and find this reptile shop. Inside is an older gentleman quietly 
working behind his desk. You go in and ask him ""Excuse me sir but is this scale from one of your products?""

After a quick look under the microscope he replies ""Yes its mine.""

""Could you tell me who bought the camelon that this scale came from?""

""Well I cant tell you exactly who, Ive sold a lot over my life time.""

""Well what about within the last six months?""

""Yeah Ive sold two.""

""Who did you sell them to?""

""Two girls about 6 moths ago and 5 months ago.""

""Have you had a male come in here, goes by Roy, looking for one?""

""Actually yes, he wanted to buy one but I had sold my last two to those girls.""

""Did he ask who you sold them to?""

""Yes and I told him, Sora and Rachel.""

Roy must have gone to one of these girls either to buy the camelon from them or steal it.");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Rachel";
            options[1] = "Sora";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Rachel();
                    break;

                case 1:
                    Sora();
                    break;

                case 2:
                    ExitGame();
                    break;
            }


        }
        public void Sora()
        {
            Clear();
            WriteLine(@"Sora's ocupation was that of an ""exotic dancer"" in a club on Jig-Jig street. You go to the club
and ask for Sora. You find her on her way back to the dressing room.

""Excuse me are you Sora?""

""Yeah, whos asking?""

""Philip Scott, I'm a blade runner and I just got a couple questions.""
Do you own a camelon?

""Yeah why?""

""Has there been any guy coming around maybe wanting to buy it or possibly steal it?""

""Well I dont think he'd try to steal it but I do have a regular who always asks me about my camelon.
I use him on stage sometimes.""

""Do you know his name?""

""No""

""Do you know where he could be?""

""Well I know when he usually comes in and he did mention this cafe that he likes.""");
            ReadKey(true);
            Clear();
            string prompt = "Use the arrow keys to select and the enter key to confirm a choice";
            string[] options = new string[3];
            options[0] = "Ambush him at the club";
            options[1] = "Confront him at the cafe";
            options[2] = "Exit";
            var mainMenu = new Menu(prompt, options);
            int Index = mainMenu.Run(false);

            switch (Index)
            {
                case 0:

                    Ambush();
                    break;

                case 1:
                    Cafe();
                    break;

                case 2:
                    ExitGame();
                    break;
            }

        }
        public void Ambush()
        {
            Clear();
            WriteLine(@"You wait around the club for your suspect to show up and later that night he walks in.
Sora gives you a nod to indicate that he's the guy. He sits down to watch Sora do her routine. 
You approach him from behind and gently place a hand on his sholder. ""Excuse me sir but...."" 
You couldnt finish your sentence he raises his elbow into your nose and bolts for the door.
In a quick a desicive moment you draw and fire upon the suspect. It has to be Roy, why else would he run?
The man drops dead just before the door. 
    After a while the police arrive. Standard procedure is to try and identify the body through the police data base.
It comes back with a match. He was just some local sales man born of flesh and blood. You just killed an inocent man. You are 
immediantly broght back to the station but during flight you hear on the radio that someone had blown up part of the vehicel depot
and escaped off world. That was him, Roy. As you ride in the hover car no doubt about to be put behind bars for jumping the gun
you think to yourself...");
            EndTitle();
        }
        public void Cafe()
        {
            Clear();
            WriteLine(@"You give Sora a bit of money so she can come with you to identify the suspect and you both wait in 
the cafe for him to show up. Not long after arriving he enters. Sora says ""Thats the guy.""
With that you get up an approach him ""Excuse me sir but can I ask you a couple questions?""

""Sure, whats this about?""

""Is your name Roy?""

""No its John.""

""Well would you be willing to take a vogit-Kamff test?""

""You think I'm a replicant? Sure I'll take one.""

You take John back to the station and give him the test, he passes no problem. He is not your guy.
    But as you are about to continue on your investigation you hear over one of the radios on someones desk that 
someone had blown up part of the vehicel depot and escaped off world. That was him. That was Roy, it had to be.
You sit back down and hold your head in your hands all the while thinking.....");
            EndTitle();
        }
        public void Rachel()
        {
            Clear();
            WriteLine(@"Thanks to a quick call to the station you know where Rachel lives and decide to pay her a visit.
At her apartment you knock and this peteit lady peers from around the door.

""Yes?""

""Hello, I'm Philp Scott, blade runner. Do you mind if I ask you some questions?""

""Yeah no problem. Come in.""

""So do you own a camelon?""

""Yes.""

""Has there been anbody that has tried to buy it off you or possibly tried to steal it?""

""What? Of course not.""
");
            ReadKey(true);
                Clear();
WriteLine(@"Out of the corner of your eyes you notice a pair of mens work boots.

""Are you married or have a boyfriend?""

""Boyfriend, he likes my camelon, but he cant be who your looking for.""

""Whats his name?""

""Roy.""

With imediant entusiasim. ""How long have you know him?""

""Uh, about 5 months.""

""Do you know where he is right now?""

""He said he had to go to the vehicel depot.""

Without saying anything you run out the door leaving Rachel in complete bewilderment.");
            ReadKey(true);
            Clear();
            WriteLine(@"He's trying to leave the planet. Roy knows he cant stay so he's going to steal a shuttle.
You finally get tot the depot flash your badge and run through the front door and straight into the court yard.
    He's there, your target trying to get onto a shuttle. You shout his name as last comformation 
before retirerment. Roy looks in your direction, that was it all that was needed. You draw and with a single shot ecoing
through the yard Roy falls to the ground.
    Thats it, the chace is over. You walk over to Roy he's still conscious and he says ""I've seen so much I just 
wanted to keep making memories and live a normal life but...."" 
");
            EndTitle();
        }

    }
}
