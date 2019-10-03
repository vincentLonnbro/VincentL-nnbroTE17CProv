using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VincentLönnbroTE17CProv
{
    class Böcker
    {
        public int price;
        private List<string> bookList;

        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private bool evaluated = false;

        private Random generator = new Random();

        public Böcker()
        {
            category = GenerateCategories();
            name = GenerateBooks();
            actualValue = generator.Next(1, 51); // slumpar ett pris mellan 1 och 50
            rarity = generator.Next(1, 6); // Slumpar ett rarity värde mellan 1 och 5
            cursed = GenerateCurse();
        }
        public bool IsCursed()
        {
            if (generator.Next(1 , 11) > 8)
            {
                return cursed;
            }
            else
            {
                return !cursed;
            }
        } 
        public string GetName()
        {
            return name;
        }
        public string GetCategory()
        {
            return category;
        }
        public int Evaluate()
        {
            evaluated = true;
            int s = actualValue * rarity;
            float lowerS = s * 0.5f;
            float higherS = s * 1.5f;
            return generator.Next((int)lowerS, (int)higherS);
        }

        public void PrintInfo()
        {
            if (evaluated)
            {
                Console.WriteLine("Information:\nName: " + name + "\nRarity: " + rarity + "\nCategory: " + category + "\nPrice: " + price);
            }
            else
            {
                Console.WriteLine("Information:\nName: " + name + "\nRarity: " + rarity + "\nCategory: " + category + "\nPrice: Not yet evaluated...");
            }
        }

        private string GenerateBooks()
        {
            Console.WriteLine("Skriv in ett namn på boken!");
            return Console.ReadLine();
        }

        private string GenerateCategories()
        {
            string[] categoriesA = { "Religion", "Art", "Stories", "Factual" };

            return categoriesA[generator.Next(0, categoriesA.Length)];
        }
        private bool GenerateCurse()
        {
            int r = generator.Next(0, 100);
            if (r > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
