namespace Piano
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Для выбора актавы нажмите клавиши 'f4', 'f5' или 'f6'.");
            ConsoleKeyInfo octaveReader = Console.ReadKey();
            if (octaveReader.Key == ConsoleKey.F4)
            {
                TheForthOctave();
            }
            if (octaveReader.Key == ConsoleKey.F5)
            {
                TheFifthOctave();
            }
            if (octaveReader.Key == ConsoleKey.F6)
            {
                TheSixthOctave();
            }
            if (octaveReader.Key == ConsoleKey.Escape)
            {
                
            }
        }

        static void TheForthOctave()
        {
            int[] theFourthOctave = new[] { 261, 277, 293, 311, 329, 349,
                                           370, 392, 415, 440, 466, 493 };
            Sound1(theFourthOctave);
        }

        static void TheFifthOctave()
        {
            int[] theFifthOctave = new[] { 523, 554, 587, 622, 659, 698,
                                           740, 784, 830, 880, 932, 987 };
            Sound2(theFifthOctave);
        }

        static void TheSixthOctave()
        {
            int[] theSixthOctave = new[] { 1047, 1109, 1175, 1245, 1319, 1397,
                                           1480, 1568, 1661, 1760, 1865, 1976 };
            Sound3(theSixthOctave);
        }

        static void Sound1(int[] theFourthOctave)
        {
            ConsoleKeyInfo fourReader = Console.ReadKey();
            while (fourReader.Key != ConsoleKey.Escape)
            {
                switch (fourReader.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(theFourthOctave[0], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(theFourthOctave[1], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(theFourthOctave[2], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(theFourthOctave[3], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(theFourthOctave[4], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(theFourthOctave[5], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(theFourthOctave[6], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(theFourthOctave[7], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(theFourthOctave[8], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(theFourthOctave[9], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        Console.Beep(theFourthOctave[10], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(theFourthOctave[11], 200);
                        Console.Clear();
                        break;
                }
                fourReader = Console.ReadKey();
            }
            Main();
        }
        static void Sound2(int[] theFifthOvtave)
        {
            ConsoleKeyInfo fifthReader = Console.ReadKey();
            while (fifthReader.Key != ConsoleKey.Escape)
            {
                switch (fifthReader.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(theFifthOvtave[0], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(theFifthOvtave[1], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(theFifthOvtave[2], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(theFifthOvtave[3], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(theFifthOvtave[4], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(theFifthOvtave[5], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(theFifthOvtave[6], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(theFifthOvtave[7], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(theFifthOvtave[8], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(theFifthOvtave[9], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        Console.Beep(theFifthOvtave[10], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(theFifthOvtave[11], 200);
                        Console.Clear();
                        break;
                }
                fifthReader = Console.ReadKey();
            }
            Main();
        }

        static void Sound3(int[] theSixthOctave)
        {
            ConsoleKeyInfo sixthReader = Console.ReadKey();
            while (sixthReader.Key != ConsoleKey.Escape)
            {
                switch (sixthReader.Key)
                {
                    case ConsoleKey.A:
                        Console.Beep(theSixthOctave[0], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        Console.Beep(theSixthOctave[1], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(theSixthOctave[2], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(theSixthOctave[3], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        Console.Beep(theSixthOctave[4], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        Console.Beep(theSixthOctave[5], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        Console.Beep(theSixthOctave[6], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        Console.Beep(theSixthOctave[7], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(theSixthOctave[8], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        Console.Beep(theSixthOctave[9], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        Console.Beep(theSixthOctave[10], 200);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(theSixthOctave[11], 200);
                        Console.Clear();
                        break;
                }
                sixthReader = Console.ReadKey();
            }
            Main();
        }
    }
}