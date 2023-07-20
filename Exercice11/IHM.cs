using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    internal static class IHM
    {
        private static Pile<string> _pile = new Pile<string>();
        public static void Start()
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("=== Main Menu ===\n");
            Console.WriteLine("1. Add element\n2. Take element\n3. Take element at X\n4. Show all elements\n0. Quit");
            Console.Write("Your choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    AddElement();
                    break;
                case "2":
                    TakeElement();
                    break;
                case "3":
                    TakeElementX();
                    break;
                case "4":
                    DisplayAll();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Wrong value!\n");
                    break;
            }
            MainMenu();
        }

        private static void AddElement()
        {
            Console.Write("\nValue to add : ");
            string value = Console.ReadLine();
            _pile.Add(value);
            Console.WriteLine($"{value} was added to the pile. Returning to main menu...\n");
        }

        private static void TakeElement()
        {
            Console.WriteLine($"\nThe element {_pile.Remove()} was removed from the pile. Returning to main menu...\n");
        }

        private static void TakeElementX()
        {
            Console.Write("\nIndex of element to take : ");
            int index = InputControl();
            Console.WriteLine($"The element {_pile.RemoveAt(index-1)} at index {index} was removed from the pile. Returning to main menu...\n");
        }

        private static int InputControl()
        {
            int res;
            while(!int.TryParse(Console.ReadLine(), out res) || res <= 0 || res > _pile.Count)
            {
                Console.Write($"Invalid input! Please enter a number between 1 and {_pile.Count}: ");
            }
            return res;
        }

        private static void DisplayAll()
        {
            if(_pile.Count > 0)
            {
                Console.WriteLine("\nList of all elements in the pile: ");
                Console.WriteLine(_pile);
            } else Console.WriteLine("\nPile is empty.");

            Console.WriteLine("Returning to main menu...\n");

        }
    }
}
