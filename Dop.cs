namespace tortiki
{
    internal class Dop
    {
       public static int pos = 0;
        public static int Strelca(int startPos = 0, int count = 8, string arrow = "->")
        {
            string empty = new string(' ', arrow.Length);
            int i = startPos;
            Console.SetCursorPosition(0, startPos);
            Console.Write(arrow);
            ConsoleKeyInfo key;
            for (; ; )
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (i == count + startPos - 1)
                            continue;
                        Console.SetCursorPosition(0, i);
                        Console.Write(empty);
                        Console.SetCursorPosition(0, ++i);
                        Console.Write(arrow);
                        break;
                    case ConsoleKey.UpArrow:
                        if (i == startPos)
                            continue;
                        Console.SetCursorPosition(0, i);
                        Console.Write(empty);
                        Console.SetCursorPosition(0, --i);
                        Console.Write(arrow);
                        break;
                    case ConsoleKey.Enter:
                        return i + 1 - startPos;
                }
            }
        }
       public static void FirstMenu()
        {
            Console.WriteLine("  1.Форма торта \n  2.Размер торта \n  3.Вкус коржей \n  4.Количество коржей \n  5.Начинка \n  6.Глазурь \n  7.Декор");
            Program.Clava();
        }
    }
}
