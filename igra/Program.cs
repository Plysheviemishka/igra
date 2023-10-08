namespace proga
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Здравствуй друг!) Ты попал в мир аниме тянок ");
                Console.WriteLine("Нажми 1 для выбора своей будующей девочки");
                string action = Console.ReadLine();
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(i);

                    if (action == "1")
                    {
                        Console.WriteLine("Ты попал в аниме мир поздравляю тебя выбери себе одну из девочек");
                        Console.WriteLine("1)Рита 2)Элла 3)Кейт");
                        action = Console.ReadLine();
                    }
                }
                if (action == "1")
                {
                    Console.WriteLine("Ты выбрал Риту,она была тебе верна всего лишь 5 дней, после ее измены ты ушел на покой)");
                    Console.WriteLine("Перезапусти игру и начни заново");
                    action = Console.ReadLine();
                }

                if (action == "2")
                {
                    Console.WriteLine("Ты выбрал Эллу, но увы она тебя убила в первую брачную ночь");
                    Console.WriteLine("Перезапусти игру и начни заново");
                    action = Console.ReadLine();
                }
                if (action == "3")
                {
                    Console.WriteLine("Ты выбрал Кейт, у тебя с ней появились дети и ты жил счастливо поздравляю))");
                    Console.WriteLine("Перезапусти игру и начни заново");
                    action = Console.ReadLine();
                }

    








            }



        }
    }
