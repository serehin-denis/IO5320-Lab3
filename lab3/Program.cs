using System.Linq;

namespace lab3
{
 class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Furniture sofa = new Furniture("Тканина", "Диван", "Вітальня", 15000, 2020);
            Furniture chair = new Furniture("Тканина", "Крісло", "Вітальня", 5000, 2021);
            Furniture table = new Furniture("Дерево", "Стіл", "Їдальня", 5000, 2019);
            
            Furniture[] Catalog = {sofa, chair, table};

            foreach (Furniture f in Catalog)
            {
                Console.Write(f + "\n");
            }
            
            Catalog = Catalog.OrderBy(x => x.Price).ThenBy(x => x.Year).ToArray();
            
            foreach (Furniture f in Catalog)
            {
                Console.Write(f + "\n");
            }
        }
    }
}
