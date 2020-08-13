using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgramming
{
    public class ProgramUI_refactor
    {
        private bool _isRunning = true;


        public void Start()
        {
            Console.WriteLine("************************************************\n" +
"                .(~\n" +
"         (=#####{>==================-\n" +
"                `(~\n" +
"\n");
            Console.WriteLine("             Let's play Brantinia!\n" +
                "---------------------------------------------------------");
            Console.WriteLine("Serving your King, Mowing peoples lawns, getting heartbroken and showing off your sniper rifle! What fun.\n" +
                "\n" +
                "\n" +
                "--How to play--\n" +
                "\n" +
                "1. get gud\n" +
                "2. Input your name, and follow the prompt\n" +
                "3. Pick a path to advance in the game\n");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("4. But mistake! You die. You very mad. You run away, find new game, new story, new Adventure!\n" +
                "   - but secret, we kill you on purpose. Our game the best.\n");
            Console.BackgroundColor = ConsoleColor.Black;
            NameCharacter();
            //RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                // First interaction
                string userInput = Interactions1();
                FirstInt(userInput);
                Console.ReadLine();
            }
        }

        //private void SetStartingGold()
        //{
        //    int startingGold;
        //    do
        //    {
        //        Console.Clear();
        //        Console.Write("Please enter your starting gold amount: ");
        //    }
        //    while (int.TryParse(Console.ReadLine(), out startingGold));

        //    Console.Clear();
        //    _set.gold = startingGold;
        //}

        //private void Play()

        private void GameOver()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("--GAME OVER--\n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Would you like to try again?");
            string retryInput = Console.ReadLine();

            if (retryInput == "yes")
            {
                Console.Clear();
                Start();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void Completion()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("C    \n" +
                "   O   \n" +
                "       N   \n" +
                "           G   \n" +
                "               R   \n" +
                "                   A   \n" +
                "                       T   \n" +
                "                           S   \n" +
                "\n" +
                "You've finished the game!\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Would you like to play this ultra sick game again? ");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                Console.Clear();
                Start();
            }
            else
            {
                Console.WriteLine("Oh ok ok we take back your gold.");
            }

            //if (completedBonus == true)
            //{
            //    Console.WriteLine("You earned the bonus for collecting all the gold coins!");
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}
        }

        public void NameCharacter()
        {
            Console.Write("Enter your character name: ");
            string characterName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write($"Welcome, {characterName}. Are you ready to start? ");
            string readyToStart = Console.ReadLine();
            Console.WriteLine("");
            if (readyToStart == "yes")
            {
                Console.Clear();
                RunMenu();
            }
            else
            {
                Console.WriteLine("Guess you don't want to play.");
            }

        }


        public string Interactions1()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You wake up in bed and think about having an adventure. Your thoughts?\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) Nah.\n" +
                              "2.) I guess so.");

            string userInput = Console.ReadLine();
            return userInput;

        }

        private void FirstInt(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You stay in bed and go back to sleep.\n" +
                        "\n" +
                        "\n");
                    GameOver();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decide to have an adventure.\n");
                    Interactions2();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

        public string Interactions2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You hop out of bed with your backpack and decide to leave for an adventure. Which route will you take?\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) Left\n" +
                              "2.) Straight ahead\n" +
                              "3.) Right seems right\n");

            string userInput2 = Console.ReadLine();
            Console.Clear();
            switch (userInput2)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You immediately roll down a large rocky hill and hit your head on a rock, killing you instantly. You've always known about the large rocky hill outside your house so I'm not sure why you did that\n");
                    GameOver();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You head into town. Probably a good idea to grab some supplies.\n");
                    Interactions3();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The right is not right. Well, it is right, but it isnt the right path. I mean, it is the right path, but it's not the right right path in this case. Long story short, you should choose another route.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "yes")
                    {
                        Console.Clear();
                        Interactions2();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Selction");
                    break;

            }

            return userInput2;
        }



        public string Interactions3()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("As you enter town, you see mutliple shops to buy gear from. But which to choose?\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) There's a person leaning against a wall. They don't appear to be a shop, but they have a sweet leather jacket so they seem cool.\n" +
                              "2.) A small wooden hut that appears to have a variety of knick knacks and trinkets. You don't see any adventuring gear, but you could get a nice dolphin keychain or something.\n" +
                              "3.) A larger stone store. They appear to have a variety of weapons and potions to aid your quest.\n" +
                              "4.) Something that appears to be Brantinias version of an IKEA.\n" +
                              "5.) Gear??? I only need my mighty fists and courageous spirit!");

            string userInput3 = Console.ReadLine();
            Console.Clear();
            switch (userInput3)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Seems like this person was just enjoying their day. You're kind of a jerk to bother them. Try again jerk\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "yes")
                    {
                        Console.Clear();
                        Interactions3();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("They do not have a dolphin keychain. Your day is pretty much ruined. Might as well sadly look at the other stores.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain2 = Console.ReadLine();
                    if (tryAgain2 == "yes")
                    {
                        Console.Clear();
                        Interactions3();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("This store provides you with a good amount of gear. You have picked up the following items:\n" +
                                      " - A broadsword. Good for cuttin\n" +
                                      " - Various health potions. Good for healin\n" +
                                      " - Various packs of food and water. Good for eatin and drinkin\n" +
                                      " - A British L96A1 Sniper Rifle. Good for shooting things at an average distance of 1.5km\n" +
                                      " - A walking stick. Good for walkin\n");
                    Interactions4();
                    break;

                case "4":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You found a chair set that will go great with your patio. Once you finish building the patio like you keep saying you will every summer. No gear though, should probably try another shop.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain3 = Console.ReadLine();
                    if (tryAgain3 == "yes")
                    {
                        Console.Clear();
                        Interactions3();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "5":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Don't be stupid. Try a different shop.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain4 = Console.ReadLine();
                    if (tryAgain4 == "yes")
                    {
                        Console.Clear();
                        Interactions3();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;


            }

            return userInput3;
        }


        public string Interactions4()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("After obtaining your gear, you decide to head to the local pub and see what needs adventuring today.\n" +
                              "Upon entering the pub, you see a few p[eople that look like they could use an adventurer, who do you speak with?\n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("1.) The kings royal knights. They appear to be hanging up a wanted poster of some kind.\n" +
                              "2.) The barkeep, Azard. A well traveled adventurer who decided to retire in your town.\n" +
                              "3.) Your ex, who decided to dump you just before the towns big pumpkin harvest festival, ensuring you wouldn't have time to find another dance partner.\n" +
                              "4.) Old lady Magnes. The towns nicest citizen, and maker of the best pie in Brantinia, 3 years running.\n" +
                              "5.) Gamel, the town drunk.\n" +
                              "6.) Linota, the barkeeps cat.");

            string userInput4 = Console.ReadLine();
            Console.Clear();
            switch (userInput4)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The knights explain a terrible beast has been plaguing a nearby forest, and citizens are unable to take necessary travels. The beast must be slain as soon as possible.\n" +
                                      "The knights would do this themselves, but they have to get ready for their weekly bowling tournament. You decide to challenge the beast yourself, and begin your journey to the forest.\n");
                    // correctAnswer = true;
                    Interactions5();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Azard is a master salesman, and talks you into buying a quality ale. You lose 10 gold coins, but you do not find a quest.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain == "yes")
                    {
                        Console.Clear();
                        Interactions4();
                    }
                    else
                    {
                        GameOver();
                    }

                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("After speaking with your ex, you begin crying uncontrollably. No quest is found here. Only pain\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain2 = Console.ReadLine();
                    if (tryAgain2 == "yes")
                    {
                        Console.Clear();
                        Interactions4();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "4":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Magnes informs you that her lawn needs mowing. Not being a total monster you happily offer your adventuring skills for the task.\n" +
                                       "After finishing the lawn, Magnes pays you 30 gold coins and a slice of her signature Rasberry pie. We are now ready to find a real quest.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain3 = Console.ReadLine();
                    if (tryAgain3 == "yes")
                    {
                        Console.Clear();
                        Interactions4();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "5":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" Gamel does not say a word, but lets out a disgusting audible sound before collapsing to the floor. You are not qualified to handle this kind of quest, so you look else where.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain4 = Console.ReadLine();
                    if (tryAgain4 == "yes")
                    {
                        Console.Clear();
                        Interactions4();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

                case "6":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You pet the cat. She purrs excitedly. Today is a good day. You are ready to find a quest.\n");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("Would you like to try again? ");
                    string tryAgain5 = Console.ReadLine();
                    if (tryAgain5 == "yes")
                    {
                        Console.Clear();
                        Interactions4();
                    }
                    else
                    {
                        GameOver();
                    }
                    break;

            }
            return userInput4;
        }

        public string Interactions5()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You set your sights for the forest. While a lengthy journey, you should be able to make it in under a days travel.\n" +
                              "During your travel, you come across a family who's wagon has broken down on the side of the path. What do you do?\n");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("1.) Of course you help repair the wagon, you are the nobel hero after all!\n" +
                              "2.) Ehhh it's not really worth your time. But you don't want to be horrible, you decide to pay the family 20 gold to help repair the wagon\n" +
                              "3.) Not your wagon? Not your problem. Sorry chumps.\n" +
                              "4.) Not only do you not repair the wagon, but you threaten the family with your broadsword and to try and steal their gold. Wow you suck.\n");

            string userInput5 = Console.ReadLine();
            Console.Clear();
            switch (userInput5)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You somehow repair the wagon using only your walking stick and sniper rifle as tools. The family is grateful and offers you passage to the forest as they live nearby.\n" +
                                      "Your travel just became much easier and you will be able to rest until you arrive.\n");
                    Interaction7();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You pay the family 20 gold and move on. Feeling as if you at least did a small good deed\n");
                    Interactions6();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You scoff at the family as you pass by. What kind of idiots set out for travel with a busted wagon? They deserve this. You pass by and continue to the forest.\n");
                    Interactions6();
                    break;

                case "4":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You are a hunter, and you've spotted your prey. You pull out your sword and demand they hand over their remaining gold, or feel the sting of your blade.\n" +
                                      "The family, unable to defend themselves, hand over what little gold they have left, adding up to 50 gold. You snatch the gold and run off for the forest.\n");
                    Interactions6();
                    break;
            }

            return userInput5;
        }


        public string Interactions6()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You have been traveling for some time now and are feeling tired from your travels. You decide to take a quick rest before setting off for the forest again. But where to rest?\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) Right beside the path. You don't want to lose sight of the main trail. Plus, maybe someone traveling by could aid you on your journey!\n" +
                              // ^^^ This code will take you to the BanditInteraction
                              "2.) There's a large hill beside the main trail. Camping on the other side should make sure that no travelers spot you. Wouldn't want to attract some trouble now would we?\n" +
                              // ^^^ This code will take you to the HillInteraction
                              "3.) There's some tall grass beside the main trail. You could hide out while not having to hike up a big hill. Best of both right?\n");



            string userInput6 = Console.ReadLine();
            Console.Clear();
            switch (userInput6)
            {
                case "1":
                    BanditInteraction();
                    break;
                case "2":
                    HillInteraction();
                    break;
                case "3":
                    TallGrassInteraction();
                    break;
            }

            return userInput6;
        }

        public string BanditInteraction()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("While sleeping, you are awoken to the sounds of charging horses and battle cries.\n" +
                              "It looks like a group of bandits are appraoching your way! They may have no spotted you yet though, what do you do?\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) They are just bandits, they only want coin. If you drop a large amount of coin to distract them, you may be able to escape before they spot you.\n" +
                              "2.) You decide to be honorable and fight the bandits blade to blade! You'll be just like Mel Gibson in the 1995 classic BraveHeart!\n" +
                              "3.) Honor is for losers who don't have a British L96A1 long range rifle. Take aim and fire!\n");

            string banditInput = Console.ReadLine();
            Console.Clear();
            switch (banditInput)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decide to drop 70 coins. That should be enough to keep them busy while you escape.\n");
                    Interaction7();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You try to fight 17 bandits by yourself for some dumb reason. You clash swords with the first bandit.\n" +
                                      "Only to feel the piercing bite of a steel arrow in your chest, launched by the second bandit. You drop to your knees in a stunned daze.\n" +
                                      "You look up to see another bandit charging you with their sword. The frenzied swing of their blade is the last thing you ever see.\n");
                    GameOver();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You pull out your rifle kit and begin assembly.\n" +
                                      "You grab the main body and attatch the shoulder rest.\n" +
                                      "You grab the barrel and begin gently screwing it on. Don't want to scratch this beauty now do we?\n" +
                                      "You grab the scope assmebly and begin attaching. Damn thing was always a pain. Just gotta find the 'click' they said.\n" +
                                      "You pull out your Caldwell Crosswind Professional Wind Meter to factor in the wind speed of your shots\n" +
                                      "You begin zeroing in the scope on a nearby tree. Things seem to be in order after a few test shots.\n" +
                                      "You realize you need to reload. A nearby bandit kindly hands you a fresh magazine before stabbing you in the gut.\n" +
                                      "You happily thank you bandit before collapsing from blodd loss.\n");
                    GameOver();
                    break;
                    // ^^ Game Over

            }
            return banditInput;
        }


        public void HillInteraction()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("You sleep peacefully on the other side of the hill. After waking up, you set off again for the forest.\n" +
                "\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Do you wish to continue?");

            string hillInput = Console.ReadLine();

            if (hillInput == "yes")
            {
                Console.Clear();
                Interaction7();
            }
            else
            {
                GameOver();
            }


        }

        public void TallGrassInteraction()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("For some reason you sleep in tall grass. No humans bother you. But you are covered in bugs now. Enjoy making your way to the forest with the bugs.\n" +
                "\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Do you wish to continue?");

            string tallGrassInput = Console.ReadLine();

            if (tallGrassInput == "yes")
            {
                Console.Clear();
                Interaction7();
            }
            else
            {
                GameOver();
            }
        }


        public string Interaction7()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You arrive at the entrance to the forest. With courage and haste, you make your way down the man made trail.\n" +
                              "After walking for a bit, you hear a distant roar. It doesn't sound like any beast you've known. What do you do?\n" +
                              "\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) You charge towards the sound. Readying your nerves for the fight of your life. This is the moment you got out of bed for today!!!\n" +
                              "2.) You change your mind. Decide you don't really feel like an adventure and would rather go back to bed.\n");

            string userInput7 = Console.ReadLine();
            Console.Clear();
            switch (userInput7)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You sprint through the forest. Blade drawn, ready to fell the beast that awaits you! Like a hero!\n");
                    Interaction8();
                    break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You decide to go home and go back to bed after traveling all this way.\n");
                    GameOver();
                    break;
            }
            return userInput7;
        }


        public string Interaction8()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You come across the Bake-Kujira! The fearsome ghost whale! Because it's the first creature listed on the 'List of Legendary Creatures by Type' page on Wikipedia. What do you do now?\n" +
                "\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("1.) Slice the beast! You killed a fish in a creek with a sword once when you were 13. This is pretty much the same thing!\n" +
                              "2.) You figure the best way to kill a large beast is from the inside. Dive straight into it's mouth and find the heart!\n" +
                              "3.) You've always been a reactive warrior. Let the monster make the first move, and then unleash a mighty counter attack!\n" +
                              "4.) Pick up a rock and hurl it at the beast with all your strength\n" +
                              "5.) Pick up a rock, toss it slightly into the air, and then hit it with your sword, launching it towards the beast!\n" +
                              "6.) Throw your sword. This is a large beast and getting close is too risky!\n" +
                              "7.) Scream\n");

            string userInput8 = Console.ReadLine();
            Console.Clear();
            switch (userInput8)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You swing your broadsword at the beast. Call it skill, call it blind luck, or call is destiny, but you manage to hit the crystal heart of the beast.\n" +
                                      "With that, the heart shatters and the beast vanishes with a terrifying roar. The beast also drops 300 gold for some reason. You have slain the beast!\n" +
                                      "\n" +
                                      "\n" +
                                      "\n");
                    Completion();
                    break;
                // ^^^ This is a win condition with gold involved

                case "2":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You dive sword first into the gaping mouth of the ghost whale! Being a ghost, you fall through it and hit your head on a stump. Killing you instantly.\n");
                    GameOver();
                    break;
                // ^^^ Game Over

                case "3":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You encourage the beast to make the first attack by letting out a mighty roar of your own! This startles the beast, causing it to knock over nearby trees.\n" +
                                      "One of these trees falls on to you. Crushing you instantly.\n");
                    GameOver();
                    break;
                // ^^^ Game Over

                case "4":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You throw a rock at the beast. The rock phases through the ghostly form and hits a bee hive on the other side.\n" +
                                      "Now angered, the bees begin attacking you. Looks like you are deathly allergic to thousands of forest bee stings.\n");
                    GameOver();
                    break;
                // ^^^ Game Over

                case "5":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You try to hit the rock with your sword, but miss completely. You take such a large swing that you lose balance and fall on your butt.\n" +
                                      "The ghost whale laughs under its breath. You kindly ask the beast not to tell its friends what it just saw.\n" +
                                      "The ghost whale declines this request and you die from the social anxiety this situation produces\n");
                    GameOver();
                    break;
                // ^^^ Game Over

                case "6":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You chuck your sword at the beast as hard as you can. Being a ghost, the sword flies straight through it. Landing in a bush on the other side.\n" +
                                      "You spend the next several minutes digging your sword out of a bush. Ready to fight again!\n");
                    Interaction8();
                    break;
                // ^^^ This should loop back into the start of Interaction8

                case "7":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("You scream. The beast seems uncomfortable and decides to leave the forest. You did not slay a beast, but the beast has departed.\n");
                    Completion();
                    break;
                    // ^^^ This is a win condition with no gold involded

            }
            return userInput8;
        }


    }
}
