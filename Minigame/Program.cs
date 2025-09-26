using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вы просыпаетесь в темнице...");
        Console.Write("Введите имя персонажа: ");
        string name = Console.ReadLine();

        bool artifact1 = false;
        bool artifact2 = false;
        bool artifact3 = false;
        bool chestOpened = false;
        bool doorOpened = false;

        while (!doorOpened)
        {
            Console.WriteLine($"\n{name}, осмотритесь вокруг. Доступные действия:");
            Console.WriteLine("a) Подойти к двери");
            Console.WriteLine("b) Заглянуть под скелет");
            Console.WriteLine("c) Подойти к плакату");
            Console.WriteLine("d) Посмотреть что есть в карманах");
            Console.WriteLine("e) Заглянуть в канализацию");
            Console.WriteLine("f) Поговорить с заключённым");

            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    if (chestOpened)
                    {
                        Console.WriteLine("Вы используете напильник и спиливаете одну балку и сбегаете. Поздравляем, вы выбрались!");
                        doorOpened = true;
                    }
                    else
                    {
                        Console.WriteLine("Нужно что-то чтоб сбежать");
                    }
                    break;

                case "b":
                    if (!artifact1)
                    {
                        Console.WriteLine("Под скелетом вы нашли первую монету");
                        artifact1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Под скелетом больше ничего нет.");
                    }
                    break;

                case "c":
                    if (!chestOpened)
                    {
                        if (artifact1 && artifact2 && artifact3)
                        {
                            Console.WriteLine("Теперь вы знаете чтоб под плакатом есть напильник,вы взяли его!");
                            chestOpened = true;
                        }
                        else
                        {
                            Console.WriteLine("Вы подошли посмотрели и ушли.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы уже взяли напильник.");
                    }
                    break;

                case "d":
                    if (!artifact2)
                    {
                        Console.WriteLine("Вы порыскали по карманам и нашли вторую монету");
                        artifact2 = true;
                    }
                    else
                    {
                        Console.WriteLine("В кармане больше нечего нет.");
                    }
                    break;

                case "e":
                    if (!artifact3)
                    {
                        Console.WriteLine("Вы нашли третью монету в канализации(только теперь от вас воняет)!");
                        artifact3 = true;
                    }
                    else
                    {
                        Console.WriteLine("В канализации больше нечего нет.");
                    }
                    break;

                case "f":
                    if (artifact1 && artifact2 && artifact3)
                    {
                        Console.WriteLine("Вы дали заключённому три монеты и он сказал где напильник(он под плакатам)!");
                    }
                    else
                    {
                        Console.WriteLine("Заключённый скажет вам где взять напильник за три монеты.");
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестная команда. Попробуйте снова.");
                    break;
            }
        }
    }
}