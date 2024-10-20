//Naidi oshibku
//1. Ne hvotaet set; v Username
/*class User
{
    public string Username { get; }
    public User(string username)
    {

        Username = username;
    }

    public void SetUsername(string newUsername)
    {
        Username = newUsername; // Ошибка: свойство только для чтения
    }
}*/

//2. Oshibok net? No nado ubratj private s set;
/*class Settings
{
    public static string Version { get; private set; }
    static Settings()
    {
        Version = "1.0.0";
    }
    public void UpdateVersion(string newVersion)
    {
        Version = newVersion; // Ошибка: сеттер имеет модификатор private
    }
}*/

//3. Oshibok net? No nado ubratj private s set;
/*class Product
{
    private decimal price;
    public decimal Price
    {
        get { return price; }
        private set { price = value; }
    }
    public void SetPrice(decimal newPrice)
    {
        Price = newPrice; // Ошибка: сеттер имеет модификатор private
    }
}*/

//4. Nado vmesto public dobavitj static v contructore

/*static class Utility
{
    public static string Description { get; set; }
    public Utility()
    {
        Description = "Utility Class"; // Ошибка: статичный класс не может иметь конструктор
    }
}*/

//5. Izmenitj construct na static? Net oshibki
/*class SingletonExample
{
    private static SingletonExample instance;
    public SingletonExample Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonExample();
            }
            return instance; // Ошибка: свойство должно быть статичным
        }
    }
}*/


//Prostie zadachi
//1. /* */
/*class Employee
{
    public string Name { get; set; }
    public string Position { get; private set; }
    public Employee(string name, string pos)
    {
        this.Name = name;
        this.Position = pos;
    }
}*/
//2.
/*class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area
    {
        get
        {
            return Width * Height;  
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}*/

//3.
/*static class AppConfig
{
    public static int MaxUsers { get; set; } = 100;  
}*/

//4. 
/*class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;  
        }
    }
}*/

//5. 
/*class Logger
{
    private static Logger instance;

    private Logger()
    {
    }
    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
    public void LogMessage(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}*/


//Practical
/*class InventoryItem
{
    public string Name { get; }

    public int Quantity { get; private set; }

    public decimal Price { get; set; }

    public decimal TotalValue
    {
        get
        {
            return Quantity * Price; 
        }
    }

    public InventoryItem(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public void AddStock(int amount)
    {
        if (amount > 0)
        {
            Quantity += amount;  
        }
    }
}*/