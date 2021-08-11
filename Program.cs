using System;

namespace Minecraft_Shader_Block_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string blockChoice;
            string modname;
            string endd = "y";

            while (endd == "y" || endd == "Y")
            {
                Console.Write("WHAT BLOCK DO YOU WANT HELP FOR?");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("    PRESS 1 FOR "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("STAIRS"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("\n                                    PRESS 2 FOR "); Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("DOORS"); Console.ResetColor();
                Console.WriteLine("");


                char ch = Console.ReadKey(true).KeyChar;
                blockChoice = ch.ToString();
                Console.Clear();



                if (blockChoice == "1")
                {
                    Console.Write("ENTER BLOCK ID");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("    Example: minecraft:spruce_stairs");
                    Console.WriteLine("");
                    modname = Console.ReadLine();

                    Console.WriteLine("\n" +
                    "\n" +
                    "\n" +
                    "\n");

                    Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("################## BOTTOM DIRECTIONS ###################"); Console.ResetColor();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=bottom:facing=north" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=bottom:facing=south" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=bottom:facing=east" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=bottom:facing=west" +

                    "\n" +
                    "\n" +
                    "\n" +
                    "\n");

                    Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("################## BOTTOM RIGHT/LEFT ###################"); Console.ResetColor();
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=outer_left:half=bottom:facing=south" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=outer_left:half=bottom:facing=east" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=outer_left:half=bottom:facing=north" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=outer_left:half=bottom:facing=west" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=inner_left:half=bottom:facing=south" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=inner_left:half=bottom:facing=west" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=inner_left:half=bottom:facing=north" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=inner_left:half=bottom:facing=east" +

                    "\n" +
                    "\n" +
                    "\n" +
                    "\n");

                    Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("################## TOP DIRECTIONS ###################"); Console.ResetColor();
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=top:facing=north" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=top:facing=south" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=top:facing=east" +
                    "\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.WriteLine(":shape=straight:half=top:facing=west" +

                    "\n" +
                    "\n" +
                    "\n" +
                    "\n");

                    Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("################## TOP RIGHT/LEFT ###################"); Console.ResetColor();
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_right:half=top:facing=west" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_left:half=top:facing=north");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_right:half=top:facing=north" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_left:half=top:facing=east");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_right:half=top:facing=east" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_left:half=top:facing=south");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_right:half=top:facing=south" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=outer_left:half=top:facing=west");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_right:half=top:facing=east" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_left:half=top:facing=south");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_right:half=top:facing=south" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_left:half=top:facing=west");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_right:half=top:facing=west" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_left:half=top:facing=north");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_right:half=top:facing=north" + "     "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(modname); Console.ResetColor(); Console.Write(":shape=inner_left:half=top:facing=east");



                    Console.WriteLine("\n\n*******************************************************************");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("The lines above refer to the lines "); Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.Write("278-331 "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("of block.properties"); Console.ResetColor();
                    Console.WriteLine("\n*******************************************************************");



                    Console.WriteLine("\n \n Do you want to make another block compatible? Y/N");
                    char chh = Console.ReadKey(true).KeyChar;
                    endd = chh.ToString();
                    Console.Clear();
                }


                if (blockChoice == "2")
                {
                    Console.Write("ENTER BLOCK ID");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("    Example: minecraft:spruce_door"); Console.ResetColor();
                    modname = Console.ReadLine();


                        Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\n\n\n################## DOOR NORTH SIDE ##################"); Console.ResetColor();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=left:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=left:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=right:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=right:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=left:open=true:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=left:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=right:open=false:half=upper"); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=right:open=true:half=upper");


                        Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\n\n################## DOOR SOUTH SIDE ##################"); Console.ResetColor();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=right:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=right:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=left:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=left:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=right:open=true:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=right:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=left:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=left:open=true:half=upper");


                        Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\n\n################## DOOR EAST SIDE ##################"); Console.ResetColor();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=left:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=right:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=left:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=right:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=left:open=true:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=right:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=west:hinge=left:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=right:open=true:half=upper");


                        Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n\n\n################## DOOR WEST SIDE ##################"); Console.ResetColor();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=right:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=left:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=right:open=false:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=left:open=true:half=lower "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=south:hinge=right:open=true:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=left:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=east:hinge=right:open=false:half=upper "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(modname); Console.ResetColor(); Console.Write(":facing=north:hinge=left:open=true:half=upper");


                    Console.WriteLine("\n\n*******************************************************************");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("The lines above refer to the lines "); Console.ResetColor(); Console.ForegroundColor = ConsoleColor.Red; Console.Write("355-362 "); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("of block.properties"); Console.ResetColor();
                    Console.WriteLine("\n*******************************************************************");


                    Console.WriteLine("\n \n Do you want to make another block compatible? Y/N");
                    char chh = Console.ReadKey(true).KeyChar;
                    endd = chh.ToString();
                    Console.Clear();
                }
            }
        }
    }
}
