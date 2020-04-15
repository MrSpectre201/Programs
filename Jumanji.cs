using System;

namespace Text_Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            //Variable Definitions;
            
            int usefulNumber = 20;
            string player1Name = string.Empty;
            string equiptmentSlot1 = string.Empty;
            string equiptmentSlot2 = string.Empty;
            string equiptmentSlot3 = string.Empty;
            string player1Desc = string.Empty;
            string player1Response = string.Empty;
            int player1HealthMax = 2;
            int player1HealthNow = 1;
            string player1Skill1 = string.Empty;
            string player1Skill2 = string.Empty;
            string player1Skill3 = string.Empty;
            string player1Weakness = string.Empty;
            int player1Lives = 3;
            string monster = string.Empty;
            bool characterSelect = false;
            bool fightGoing = true;
            bool playerWin = false;

            //Opening Sequence:

            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("For those of you who wish to find...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("A way to leave your world behind...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            DramaticEmphasis();
            DramaticEmphasis();
            usefulNumber = 5;
            DramaticEmphasis2();
            DramaticJumanji();
            DramaticEmphasis();
            usefulNumber = 20;
            DramaticEmphasis();
            DramaticEmphasis();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Greetigs! I am Nigel Billingsley, Welcome to Jumanji! In this game you will used a text-based interface to return the");
            Console.WriteLine("Jewel of Jumanji to the Juguar shrine, deep in the jungle.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("When you are ready, please select a character by retyping their name as displayed here:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            while (characterSelect == false) {
                Console.WriteLine("<Dr. Smolder Bravestone - Ruby Roundhouse - Franklin Finbar - Shelly Oberon - Seaplane Mcdonough>");
                player1Response = Console.ReadLine();
                if (player1Response.Equals("Dr. Smolder Bravestone", StringComparison.CurrentCultureIgnoreCase))
                {
                    player1Name = "Dr. Smolder Bravestone";
                    player1Desc = "Famed Archeaologist";
                    player1HealthMax = 10;
                    player1HealthNow = player1HealthMax;
                    player1Skill1 = "Boomerang";
                    player1Skill2 = "Strength";
                    player1Skill3 = "Climbing";
                    player1Weakness = "None";
                    characterSelect = true;
                }
                else if (player1Response.Equals("Ruby Roundhouse", StringComparison.CurrentCultureIgnoreCase))
                {
                    player1Name = "Ruby Roundhouse";
                    player1Desc = "Killer of Men";
                    player1HealthMax = 8;
                    player1HealthNow = player1HealthMax;
                    player1Skill1 = "Tai Chi";
                    player1Skill2 = "Dance Fighting";
                    player1Skill3 = "Climbing";
                    player1Weakness = "Venom";
                    characterSelect = true;
                }
                else if (player1Response.Equals("Franklin Finbar", StringComparison.CurrentCultureIgnoreCase))
                {
                    player1Name = "Dr. Franklin Finbar";
                    player1Desc = "The Mousy Zoologist";
                    player1HealthMax = 5;
                    player1HealthNow = player1HealthMax;
                    player1Skill1 = "Backpack";
                    player1Skill2 = "Zoology";
                    player1Skill3 = "Guts";
                    player1Weakness = "Cake";
                    characterSelect = true;
                }
                else if (player1Response.Equals("Shelly Oberon", StringComparison.CurrentCultureIgnoreCase))
                {
                    player1Name = "Proffessor Sheldon Oberon";
                    player1Desc = "The Curvy Genius";
                    player1HealthMax = 5;
                    player1HealthNow = player1HealthMax;
                    player1Skill2 = "Knows Cartography";
                    player1Skill3 = "Knows Geometry";
                    player1Skill1 = "Guts";
                    player1Weakness = "Endurance";
                    characterSelect = true;
                }
                else if (player1Response.Equals("Seaplane Mcdonough", StringComparison.CurrentCultureIgnoreCase))
                {
                    player1Name = "Seaplane Mcdonough";
                    player1Desc = "Daring Pilot and Ladiesman";
                    player1HealthMax = 8;
                    player1HealthNow = player1HealthMax;
                    player1Skill1 = "Pilot";
                    player1Skill2 = "Margaritas";
                    player1Skill3 = "Cool Shades";
                    player1Weakness = "Mosquitos";
                    characterSelect = true;
                }
                else
                {
                    Console.WriteLine("Oops, you appear to be confused! try typing one of the options displayed, and remember to check your spelling!");
                    characterSelect = false;
                }
            }
            
            //Game Start:
            
            Console.WriteLine("As your vision fades to black, you wake to the sound of a loud engine nearby and a rushing river. You are surrounded by a dense jungle landscape.");
            Console.WriteLine("Do you A: Inspect the sound of the engine roaring OR B: Investigate the River *Type A or B*");
            player1Response = Console.ReadLine();
            if (player1Response.Equals("A", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("You move to find a large Jeep idling nearby with a familiar man in the driver's seat.");
                Console.WriteLine("'Welcome to Jumanji! Well, don't just stand there, in you go!'");
                Console.WriteLine("-Press any key to enter the car-");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("'Ah, " + player1Name + ", " + player1Desc + "! I've been so anxious for your arrival!'");
            }
            else if (player1Response.Equals("B", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("A Giant Hippo attacks you from the murky water!");
                monster = "Hippopotomus";
                Combat();
            }
            else
            {
                Console.WriteLine("Oops, you appear to be confused! try typing one of the options displayed, and remember to check your spelling!");
            }
            
            //Methods:
            
             void DramaticEmphasis()
             {
                for(int dramaticEffect = 0; dramaticEffect < usefulNumber; dramaticEffect++)
                {
                    Console.Write("~ ");
                    System.Threading.Thread.Sleep(50);
                    dramaticEffect++;
                }
                Console.WriteLine();
             }
            void DramaticEmphasis2()
            {
                for (int dramaticEffect = 0; dramaticEffect < usefulNumber; dramaticEffect++)
                {
                    Console.Write("~ ");
                    System.Threading.Thread.Sleep(50);
                    dramaticEffect++;
                }
            }
            void DramaticJumanji()
            {
                Console.Write("J");
                System.Threading.Thread.Sleep(60);
                Console.Write("u");
                System.Threading.Thread.Sleep(60);
                Console.Write("m");
                System.Threading.Thread.Sleep(60);
                Console.Write("a");
                System.Threading.Thread.Sleep(60);
                Console.Write("n");
                System.Threading.Thread.Sleep(60);
                Console.Write("j");
                System.Threading.Thread.Sleep(60);
                Console.Write("i");
                System.Threading.Thread.Sleep(50);
                Console.Write(" ");

            }
            void Combat()
            {
                Console.WriteLine("A wild " + monster + "appeared!");
                while(fightGoing == true)
                {
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("Fight ~ Flee");
                    player1Response = Console.ReadLine();
                    if (player1Response.Equals("Fight", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Fight with what?");
                        Console.WriteLine("Skill ~ Item");
                        player1Response = Console.ReadLine();
                        if (player1Response.Equals("Skill", StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine("<" + player1Skill1 + " ~ " + player1Skill2 + " ~ " + player1Skill3 +">");
                            player1Response = Console.ReadLine();
                            if (player1Response.Equals(player1Skill1, StringComparison.CurrentCultureIgnoreCase))
                            {

                            }
                        }
                }
            }
        }
    }
}

