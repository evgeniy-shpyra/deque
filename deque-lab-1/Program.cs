﻿using System.Xml;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var CustomDeque = new CustomDeque<string>();

            while (true) {

                Console.Clear();

                Console.WriteLine("Кількість елементів у деці: " + CustomDeque.Count);
                Console.WriteLine("Оберiть операцiю:");
                Console.WriteLine("1. Показати елементи дека");
                Console.WriteLine("2. Додати елемент до дека з переднього боку");
                
                
                Console.WriteLine("2. Додати елемент до дека з заднього боку");
                Console.WriteLine("3. Видалити елемент з переднього боку дека");
                Console.WriteLine("4. Видалити елемент з заднього боку дека");
                Console.WriteLine("6. Пошук елемента в децi");
                Console.WriteLine("7. Очистити дек");
                Console.WriteLine("8. Вийти");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Елементи дека:");

                        //CustomDeque.

                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введіть, що саме хочете добавити в початок деку:");
                        string newElement = Console.ReadLine();
                        if (newElement == null)
                        {
                            Console.WriteLine("Incorect input");
                            continue;
                        }
                        CustomDeque.AddFirst(newElement);

                        break;

                    case "8":
                        return;
                    default:
                        Console.WriteLine("Incorect input");
                        
                        break;
                }

                Console.ReadKey();

            }
        }
    }
}