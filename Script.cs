using System;

namespace GardenersAdventure
{
    class Program
    {
        static bool hasGreenTreasure = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в RPG игру Садоводческие приключение: Поиск зеленого сокровища!");

            Console.WriteLine("You are a skilled gardener on a mission to find the legendary Green Treasure hidden in the enchanted garden.");

            Console.WriteLine("Когда вы начинаете свое путешествие, вам встречаются три пути: путь цветов, Путь деревьев и Путь виноградных лоз.");

            Console.WriteLine("Какой путь вы выберете? (1, 2 или 3)");
            int pathChoice = Convert.ToInt32(Console.ReadLine());

            switch (pathChoice)
            {
                case 1:
                    PathOfFlowers();
                    break;
                case 2:
                    PathOfTrees();
                    break;
                case 3:
                    PathOfVines();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, выберите правильный путь.");
                    break;
            }

            if (hasGreenTreasure)
            {
                Console.WriteLine("Поздравляю! Вы нашли Зеленое сокровище и завершили свои поиски!");
            }
            else
            {
                Console.WriteLine("К сожалению, вам не удалось найти Зеленое сокровище. Удачи в следующий раз!");
            }
        }

        static void PathOfFlowers()
        {
            Console.WriteLine("Вы выбрали Путь Цветов.");

            Console.WriteLine("Вы должны разгадать загадку, чтобы продолжить:");

            Console.WriteLine("Я легкая, как перышко, но даже самый сильный мужчина в мире не смог бы удержать меня дольше минуты. кто я такой?");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "breath")
            {
                Console.WriteLine("Поздравляю! Вы разгадали загадку и нашли ключ к Зеленому сокровищу.");

                hasGreenTreasure = true;
            }
            else
            {
                Console.WriteLine("Ответ неверный. Чтобы продолжить поиск, вы должны попробовать другой способ.");
            }
        }

        static void PathOfTrees()
        {
            Console.WriteLine("Вы выбрали Путь среди Деревьев.");

            Console.WriteLine("Вы встречаете группу озорных фей, играющих на деревьях.");

            Console.WriteLine("Чтобы продолжить свое путешествие, вы должны ответить на их вопрос:");

            Console.WriteLine("Что становится лучше по мере высыхания?");

            string answer = Console.ReadLine();

            if (answer.ToLower() == "towel")
            {
                Console.WriteLine("Отличная работа! Феи дарят вам волшебный ключ, который откроет Зеленый сундук с сокровищами.");

                hasGreenTreasure = true;
            }
            else
            {
                Console.WriteLine("Ответ неверный. Чтобы продолжить поиск, попробуйте другой способ.");
            }
        }

        static void PathOfVines()
        {
            Console.WriteLine("Вы выбрали Путь Виноградных лоз.");

            Console.WriteLine("Вы натыкаетесь на таинственную дверь, увитую виноградными лозами.");

            Console.WriteLine("Вы должны соответствовать символам на двери, чтобы открыть ее и обнаружить Зеленое сокровище.");

            Console.WriteLine("Символы: ☘️ 🌿 🍀");

            string answer = Console.ReadLine();

            if (answer == "🍀")
            {
                Console.WriteLine("Поздравляю! Вы открыли дверь и обнаружили спрятанное внутри Зеленое сокровище.");

                hasGreenTreasure = true;
            }
            else
            {
                Console.WriteLine("Ответ неверный. Чтобы продолжить поиск, попробуйте другой способ");
            }
        }
    }
}
