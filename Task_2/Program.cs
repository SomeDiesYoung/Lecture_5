
public class Car
{
    public string Brand { get; set; }

    private int year;
    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1886)
            {
                year = 1886;
            }
            else if (value > DateTime.Now.Year)
            {
                year = DateTime.Now.Year;
            }
            else
            {
                year = value;
            }

        }
    }

    public void GetInfo(string brand, int year)
        {
            this.Brand = brand;
            this.Year = year;

        }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car Brand is : {Brand} , Year : {Year}");
    }
}

    
public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.GetInfo("Aston-Martin",1234);
        car.DisplayInfo();

        car.GetInfo("Alfa-Romeo", 5000);
        car.DisplayInfo();
    }
}

