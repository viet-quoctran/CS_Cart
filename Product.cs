namespace CS_GetSet005;
class Product
{
    public string Name { get; set; }
    private double price;
    public double Price
    {
        get => price;
        set
        {
            if (value <= 0) throw new ArgumentException("Value must be greater than zero.");
            price = value;
        }
    }
    private int quantity;
    public int Quantity 
    {
        get => quantity;
        set
        {
            if (value < 0) throw new ArgumentException("Value must be non-negative.");
            quantity = value;
        }
    }
    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}