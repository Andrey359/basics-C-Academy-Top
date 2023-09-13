using System.Collections.Specialized;
using System.Diagnostics;
using System.Xml.Linq;

class Product
{
    private int Id { get; set; }
    private string Name { get; set; }
    private int Price { get; set; }
    private string Category { get; set; }
    private string? Description { get; set; }

    public Product(int id, string name, int price, string category, string description)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
        Description = description ;
    }

    static int NextID = 1;
    static public Product create()
    {
        Console.Write("Имя продукта ");
        string name = Console.ReadLine();
        Console.Write("Цена продукта ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Категория продукта ");
        string category = Console.ReadLine();
        Console.Write("Описание продукта ");
        string description = Console.ReadLine();
        if (description.Length == 0)
        {
            description = null;
        }
        return new Product(NextID++, name, price, category, description);
    }

    public override string ToString()
    {
        return "Product(" + Id + ", " + Name + ", " + Price + ", " + Category + ", " + (Description ?? "no_description") + ")";
    }


    public static Product CreateRandom()
    {
        return new Product(
            NextID++, 
            Util.RandomString(10),
            new Random().Next() % 1000,
            Util.RandomString(10),
            null);
    }
}

class Util
{

    public static string RandomString(int length)
    {
        Random random = new Random();
        string text = "";
        for (int i = 0; i < length; i++)
        {
            text += (char)('a' + (random.Next() % 26));
        }
        return text;
    }
}

class MainClass
{

    public static void Main() 
    {
        Product product = Product.CreateRandom();
        Console.WriteLine(product);
        Console.WriteLine (Util.RandomString(45));
    }
    
}
