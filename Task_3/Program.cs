
public class Product
{

    public Product() { }

    public  Product(string name , decimal price, CurrencyEnum currency) {
         Name = name;
        Price = price;
        CurrencyType = currency;
    }
    public string Name { get; set; }
    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                price = 0;
            }
            else
            {
                price = value;
            }

        }
    }
    public CurrencyEnum CurrencyType { get; set; }
    public enum CurrencyEnum
    {
        GEL = 0,
        USD = 1,
        EUR = 2
    }
    



    public void GetInfo(string name,decimal price, int currency)
    {
        this.Name = name;
        this.Price = price;
        this.CurrencyType = (CurrencyEnum)currency;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name : {Name} , Price : {Price} , Currency {CurrencyType}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Product product = new Product();
        product.GetInfo("Something", 351.32m, 2);
        product.DisplayInfo();



        product.GetInfo("Spilo",214.21m, 0);
        product.DisplayInfo();


        product.GetInfo("Arajani", 1.21m, 1);
        product.DisplayInfo();
    }
}