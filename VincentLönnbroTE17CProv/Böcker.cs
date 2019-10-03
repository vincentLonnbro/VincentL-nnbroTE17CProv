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
        public List<string> bookList;

        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private bool evaluated = false;

        private Random generator = new Random();

        Böcker()
        {
            category = GenerateCategories();
            name = GenerateBooks();
            actualValue = generator.Next(1, 51); // slumpar ett pris mellan 1 och 50
            rarity = generator.Next(1, 6); // Slumpar ett rarity värde mellan 1 och 5
            cursed = GenerateCurse();
        }
        public void Evaluate()
        {
            double s = actualValue * rarity * 1.5;
            int correctPrice = generator.Next(Math. * 0.5, (actualValue * rarity) * 1.5);
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
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                bookList.Add("Book " + i);
            }
            return bookList[generator.Next(0, bookList.Count)];
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
