using System;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace ConsoleApp10
{
    class P_O_S
    {
        static void Main(string[] args)
        {
            string POS_VERSION = ("v0.1.9");
            string good_day = (DateTime.Now.ToShortTimeString());
            char please = (good_day[0]);
            char k = (good_day[1]);
            char[] chars = { please, k };
            string needed_good_day = new string(chars);
            if (Convert.ToInt32(needed_good_day) <= (12))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine($"welcome to P.O.S {POS_VERSION} (Pointless Operating System), which is well a pointless operating system i'm making BECAUSE IM BORED yes im making this BECAUSE I AM BORED (i'm dumb) type help to bring up all available commands!.");
                Console.WriteLine(Convert.ToString("the time is " + (good_day)));
                Console.WriteLine("Good Morning!");
                Console.WriteLine(needed_good_day);
            }
            else if (Convert.ToInt32(needed_good_day) >= (12))
            {
                Console.WriteLine($"welcome to P.O.S {POS_VERSION} (Pointless Operating System), which is well a pointless operating system i'm making BECAUSE IM BORED yes im making this BECAUSE I AM BORED (i'm dumb) type help to bring up all available commands!.");
                Console.WriteLine("Good Afternoon / Night");
                Console.WriteLine(Convert.ToString("the time is " + (good_day)));
            }
            var debug_mode = false;
            var RUNNING = true;
            while (RUNNING == true)
            {
                var user_input1 = Console.ReadLine();
                if (user_input1 == ("help"))
                {
                    Console.WriteLine("your commands are:");
                    Console.WriteLine("help - shows all commands");
                    Console.WriteLine("datetime - displays date and time");
                    Console.WriteLine("launch (file path) - launches a program");
                    Console.WriteLine("write - writes a file");
                    Console.WriteLine("read - reads the contents of a file");
                    Console.WriteLine("display - writes something on the screen");
                    Console.WriteLine("clear - clears screen");
                    Console.WriteLine("calculator - a simple calculator");
                    Console.WriteLine("debug - developer debugger so you can feel all cool and developery (gives you extra information about wtf is going on because i need to know what is going on and you can too i guess if you want i dont know this is getting way too looooooooong)");
                    Console.WriteLine("alarm - sets an alarm (warning, you can't do anything while an alarm is set!)");
                    Console.WriteLine("playwav - plays wav files, pretty much explains itself in the title :P");
                    Console.WriteLine("POSBASIC - the basic programming language for P.O.S");
                    Console.WriteLine("webpage - allows you to visit a webpage on the newfangled internets");
                    Console.WriteLine("sourcecodePOS - displays source code of P.O.S via github");
                    Console.WriteLine("background_colour - changes the background")
                    Console.WriteLine("---------------------------------------------------------");
                }
                else if (user_input1 == ("webpage"))
                {
                    Console.WriteLine("type the address of the website you would like to visit (most websites might not work and will just display the source code, you have been waaaaaarned!!!!!)");
                    var address = Convert.ToString(Console.ReadLine());
                    System.Net.WebClient wca = new System.Net.WebClient();
                    string webDataa = wca.DownloadString(address);
                    Console.WriteLine(webDataa);
                }
                else if (user_input1 == ("sourcecodePOS"))
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    string webData = wc.DownloadString("http://gothe.re/xBG");
                    Console.WriteLine(webData);
                }
                else if (user_input1 == ("display"))
                {
                    Console.WriteLine("type what you would like to display on the screen:");
                    var user_input2 = Console.ReadLine();
                    if (debug_mode == true)
                    {
                        Console.WriteLine("displaying the user's input...");
                    }
                    Console.WriteLine(user_input2);
                }
                else if (user_input1 == ("write"))
                {
                    Console.WriteLine("write the file path");
                    var abcd = Console.ReadLine();
                    Console.WriteLine("write the contents of the file");
                    var abc = Console.ReadLine();
                    if (debug_mode == true)
                    {
                        Console.WriteLine("creating file...");
                    }
                    File.WriteAllText(abcd, abc);
                    Console.WriteLine("--------------------------");
                }
                else if (user_input1 == ("read"))
                {
                    Console.WriteLine("write the file path");
                    var ffilepath = Console.ReadLine();
                    if (debug_mode == true)
                    {
                        Console.WriteLine("reading text...");
                    }
                    string readText = File.ReadAllText(ffilepath);
                    if (debug_mode == true)
                    {
                        Console.WriteLine("displaying text...");
                    }
                    var rhyn = true;
                    while (rhyn == (true))
                    {
                        Console.WriteLine(readText);
                        Console.WriteLine("would you like to search for a word?");
                        var aabhc = Console.ReadLine();
                        if (aabhc == ("yes"))
                        {
                            Console.WriteLine("what would you like to find?");
                            var finder = Console.ReadLine();
                            if (readText.Contains(finder))
                            {
                                Console.WriteLine(finder + " is in the file");
                            }
                            else
                            {
                                Console.WriteLine(finder + " is not in the file");
                            }
                        }
                        else if (aabhc == ("no"))
                        {
                            rhyn = false;
                            if (debug_mode == (false))
                            {
                                Console.WriteLine("Rhyn: i am false");
                                Console.WriteLine(":(");
                            }
                            //:(
                        }
                        Console.WriteLine("--------------------------");
                    }
                }

                else if (user_input1 == ("clear"))
                {
                    Console.Clear();
                    Console.WriteLine($"welcome to P.O.S {POS_VERSION} (Pointless Operating System), which is well a pointless operating system i'm making BECAUSE IM BORED yes im making this BECAUSE I AM BORED (i'm dumb) type help to bring up all available commands!.");
                }
                //else if (user_input1 == ("backcol"))
                //{
                //Console.WriteLine("pick a RGB colour for the background");
                //var backgroundcoloura = Console.ReadLine();
                //Console.BackgroundColor = ConsoleColor.FromArgb(255, 232, 232);
                //}
                else if (user_input1 == ("launch"))
                {
                    Console.WriteLine("type the filepath");
                    var filllepath = Console.ReadLine();
                    if (debug_mode == true)
                    {
                        Console.WriteLine($"trying to launch {filllepath}...");
                    }
                    Process.Start(filllepath);
                }
                else if (user_input1 == ("datetime"))
                {
                    var date = DateTime.Now;
                    Console.WriteLine(date);
                }
                else if (user_input1 == ("debug"))
                {
                    if (debug_mode == false)
                    {
                        Console.WriteLine("DEBUG MODE ACTIVATED");
                        debug_mode = true;
                    }
                    else
                    {
                        Console.WriteLine("DEBUG MODE DEACTIVATED");
                        debug_mode = false;
                    }
                }
                else if (user_input1 == ("alarm"))
                {
                    Console.WriteLine("when would you like to set an alarm for? (24 hour clock!)");
                    var inputa = (Console.ReadLine());
                    Console.WriteLine("what message would you like to have on the alarm?");
                    var inputb = Console.ReadLine();
                    var RUNNINGaa = true;
                    while (RUNNINGaa == (true))
                    {
                        var alarmthing = (DateTime.Now.ToShortTimeString());
                        if (alarmthing == (inputa))
                        {
                            Console.WriteLine(inputb);
                            Console.WriteLine("-------------------------------");
                            RUNNINGaa = false;
                        }
                    }
                }
                else if (user_input1 == ("POSBASIC"))
                {
                    Console.WriteLine("what would you like your program to be called?");
                    var name_of_file = Console.ReadLine();
                    Console.WriteLine("welcome to the basic programming language for P.O.S , POSBASIC (type help for commands in POSBASIC), keep in mind this is a very simple programming language and should be easy to learn but is a big work in progress, remember POSBASIC is in a very alpha state and should only be used for fun.");
                    var userinput12 = Console.ReadLine();
                    if (userinput12 == ("help"))
                    {
                        Console.WriteLine("here is a list of the commands you can do");
                        Console.WriteLine("print - displays a string");
                        Console.WriteLine("input - gets the user's input");
                        Console.WriteLine("var - creates a variable");
                        Console.WriteLine("int - creates an integer");
                        Console.WriteLine("str - creates a string");
                        Console.WriteLine("time.sleep - makes the program stop for ___ amount of time");
                        Console.WriteLine("if - an if statement");
                        Console.WriteLine("else - an else statement");
                        Console.WriteLine("-------------------------------");
                        //string line = File.ReadLines(FileName).Skip(14).Take(1).First(); - skip to a certain line in a file
                    }

                }
                else if (user_input1 == ("playwav"))
                {
                    var RHYNISTHEBEST = ("yes");
                    while (RHYNISTHEBEST == ("yes"))
                    {
                        var sound_player = new SoundPlayer();
                        Console.WriteLine("would you like to play the wav once (type single for this option) or loop it (type loop for this option)? (looping will make you unable to stop the wav file unless you exit the OS itself)");
                        var yay_or_nay = Convert.ToString(Console.ReadLine());
                        if (yay_or_nay == ("loop"))
                        {
                            Console.WriteLine("type the file path of the wav file");
                            var wav_file_pathh = Convert.ToString(Console.ReadLine());
                            sound_player.SoundLocation = (wav_file_pathh);
                            if (debug_mode == (true))
                            {
                                Console.WriteLine($"playing  {wav_file_pathh} at {good_day}...");
                            }
                            sound_player.PlayLooping();
                            if (debug_mode == (true))
                            {
                                Console.WriteLine($"{wav_file_pathh} has stopped playing at {good_day}.");
                            }
                            RHYNISTHEBEST = ("always <3");
                            if (debug_mode == true)
                            {
                                Console.WriteLine("RHYNISTHEBEST = " + RHYNISTHEBEST);
                            }
                        }
                        else if (yay_or_nay == ("single"))
                        {
                            Console.WriteLine("type the file path of the wav file");
                            var wav_file_path = Convert.ToString(Console.ReadLine());
                            sound_player.SoundLocation = (wav_file_path);
                            if (debug_mode == (true))
                            {
                                Console.WriteLine($"playing  {wav_file_path} at {good_day}...");
                            }
                            sound_player.PlaySync();
                            if (debug_mode == (true))
                            {
                                Console.WriteLine($"{wav_file_path} has stopped playing at {good_day}.");
                            }
                            RHYNISTHEBEST = ("definately");
                            if (debug_mode == true)
                            {
                                Console.WriteLine("RHYNISTHEBEST = " + RHYNISTHEBEST);
                            }
                        }
                        else
                        {
                            Console.WriteLine("that is not a valid response");
                        }
                    }
                }
                else if (user_input1 == ("calculator"))
                {
                    Console.WriteLine("would you like to add, subtract or times?");
                    var what_maths_a = Console.ReadLine();
                    if (what_maths_a == ("add"))
                    {
                        Console.WriteLine("type the first number you would like to add:");
                        var numberadd1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("type the second number you would like to add:");
                        var numberadd2 = Convert.ToInt64(Console.ReadLine());
                        Int64 sumansweradd = ((numberadd1) + (numberadd2));
                        if (debug_mode == true)
                        {
                            Console.WriteLine("CALCULATING...");
                            Console.WriteLine("calculation answer = {sumansweradd}");
                        }
                        Console.WriteLine(numberadd1 + " + " + numberadd2 + " = " + sumansweradd);
                    }
                    else if (what_maths_a == ("subtract"))
                    {
                        Console.WriteLine("type the first number you would like to subtract");
                        var numbersubtract1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("type the second number you would like to subtract");
                        var numbersubtract2 = Convert.ToInt64(Console.ReadLine());
                        Int64 sumanswersub = ((numbersubtract1) - (numbersubtract2));
                        if (debug_mode == true)
                        {
                            Console.WriteLine("CALCULATING...");
                            Console.WriteLine("calculation answer = {sumanswersub}");
                        }
                        Console.WriteLine(numbersubtract1 + " + " + numbersubtract2 + " = " + sumanswersub);
                    }
                    else if (what_maths_a == ("times"))
                    {
                        Console.WriteLine("type the first number you would like to times");
                        var numbertimes1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("type the second number you would like to times");
                        var numbertimes2 = Convert.ToInt64(Console.ReadLine());
                        Int64 sumanswertimes = ((numbertimes1) * (numbertimes2));
                        if (debug_mode == true)
                        {
                            Console.WriteLine("CALCULATING...");
                            Console.WriteLine("calculation answer = {sumanswertimes}");
                        }
                        Console.WriteLine(numbertimes1 + " x " + numbertimes2 + " = " + sumanswertimes);
                    }
                }
                else
                {
                    Console.WriteLine("that is not a valid command");
                }

                }
            }
        }
    }
