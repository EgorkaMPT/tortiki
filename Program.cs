namespace tortiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если вы хотите закать тортик, нажмите ENTER");
            Console.WriteLine("Если вы ошиблись, то нажмите ESC");
            ConsoleKey Key = Console.ReadKey().Key;
            switch (Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();
                    Dop.FirstMenu();

                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.SetCursorPosition(1, 0);
                    Console.WriteLine("дДо скорых встреч!");
                    break;
            }
        }
        public static void Clava()
        {
            Dop.FirstMenu();
            Dop.Strelca();
            ConsoleKey Key = Console.ReadKey().Key;
            if (Key == ConsoleKey.Enter)
            {
                switch (Dop.pos)
                {
                    case 0:
                        {
                            Console.Clear();
                            PodMenuForma();
                        }
                        break;
                    case 1:
                        {
                            Console.Clear();
                            PodMenuRazmer();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            PodMenuVkys();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            PodMenuColvo();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            PodMenuNachunka();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            PodMenuGlazyr();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            PodMenuDekor();
                        }
                        break;
                }
            }
            else if (Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Dop.FirstMenu();
            }
        }
        static void PodMenuForma()
        {
            Console.WriteLine("Выбкрите форму торта");
            int prise = 100;
            int prise1 = 150;
            int prise2 = 200;
            string forma = "  Квадрат";
            string forma1 = "  Круг";
            string forma2 = "  Сердечко";
            Console.WriteLine(forma + " - " + prise);
            Console.WriteLine(forma1 + " - " + prise1);
            Console.WriteLine(forma2 + " - " + prise2);
            Dop.Strelca();
        }
        static void PodMenuRazmer()
        {
            Console.WriteLine("Выберите размер торта");
            int prise = 150;
            int prise1 = 200;
            int prise2 = 250;
            string razmer = "Маленький";
            string razmer1 = "Средний";
            string razmer2 = "Большой";
            Console.WriteLine(razmer + " - " + prise);
            Console.WriteLine(razmer1 + " - " + prise1);
            Console.WriteLine(razmer2 + " - " + prise2);

        }
        static void PodMenuVkys()
        {
            Console.WriteLine("Выберите вкус коржей");
            int prise = 100;
            int prise1 = 200;
            int prise2 = 300;
            string vkys = "Шоколадный";
            string vkys1 = "Клубничный";
            string vkys2 = "Банановый";
            Console.WriteLine(vkys + " - " + prise);
            Console.WriteLine(vkys1 + " - " + prise1);
            Console.WriteLine(vkys2 + " - " + prise2);
        }
        static void PodMenuColvo()
        {
            Console.WriteLine("Выберите количество коржей");
            int prise = 50;
            int prise1 = 75;
            int prise2 = 100;
            string colvo = "Один корж";
            string colvo1 = "Два коржа";
            string colvo2 = "Три коржа";
            Console.WriteLine(colvo + " - " + prise);
            Console.WriteLine(colvo1 + " - " + prise1);
            Console.WriteLine(colvo2 + " - " + prise2);
        }
        static void PodMenuNachunka()
        {
            Console.WriteLine("Выберите начинку торта");
            int prise = 150;
            int prise1 = 200;
            int prise2 = 250;
            string nachunka = "Медовая";
            string nachunka1 = "Шоколадная";
            string nachunka2 = "Кокос-малина";
            Console.WriteLine(nachunka + " - " + prise);
            Console.WriteLine(nachunka1 + " - " + prise1);
            Console.WriteLine(nachunka2 + " - " + prise2);
        }
        static void PodMenuGlazyr()
        {
            Console.WriteLine("Выберите глазурь для торта");
            int prise = 100;
            int prise1 = 100;
            int prise2 = 100;
            string glazyr = "Глазурь из молочного шоколада";
            string glazyr1 = "Глазурь из тёмного шоколада";
            string glazyr2 = "Глазурь из белого шоколада";
            Console.WriteLine(glazyr + " - " + prise);
            Console.WriteLine(glazyr1 + " - " + prise1);
            Console.WriteLine(glazyr2 + " - " + prise2);
        }
        static void PodMenuDekor()
        {
            Console.WriteLine("Выберите декор для торта");
            int prise = 150;
            int prise1 = 200;
            int prise2 = 350;
            string dekor = "Радужная посыпка";
            string dekor1 = "Свежие ягоды";
            string dekor2 = "Рожки + посыпка";
            Console.WriteLine(dekor + " - " + prise);
            Console.WriteLine(dekor1 + " - " + prise1);
            Console.WriteLine(dekor2 + " - " + prise2);
        }
    }
}