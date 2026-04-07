using System.Linq;

namespace lab3
{
 class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Furniture example = new Furniture( "Крісло","Тканина", "Вітальня", 5000, 2021);
            
            Furniture sofa = new Furniture( "Диван","Штучна шкіра", "Вітальня", 15000, 2020);
            Furniture chair = new Furniture( "Крісло","Тканина", "Вітальня", 5000, 2021);
            Furniture table = new Furniture( "Стіл","Дерево", "Їдальня", 15000, 2019);
            
            Furniture[] Catalog = {sofa, chair, table};

            foreach (Furniture f in Catalog)
            {
                Console.Write(f + "\n");
            }
            Console.WriteLine("");
            
            Catalog = Catalog.OrderBy(x => x.Price).ThenByDescending(x => x.Year).ToArray();
            Console.WriteLine("Відсортований список:");
            foreach (Furniture f in Catalog)
            {
                Console.Write(f + "\n");
            }
            Console.WriteLine("");

            bool isFound = Catalog.Contains(example);

            if (isFound)
            {
                int index = Catalog.IndexOf(example);
                Console.WriteLine($"Об'єкт, ідентичний заданному: {Catalog[index]}\n");
            }
            else
            {
                Console.WriteLine($"Об'єкт, ідентичний заданному не знайдено\n");
            }
        }
    }
}
