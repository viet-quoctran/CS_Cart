namespace CS_GetSet005;
class ShoppingCart
{
    public List<Product> Items { get; private set; }
    public ShoppingCart()
    {
        Items = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Items.Add(product);     
    }
    public void RemoveProduct(string productName)
    {
        var item = Items.Find(item => item.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        if(item != null)
        {
            Items.Remove(item);
            Console.WriteLine("Remove product" + productName);
        }
        else
        {
            Console.WriteLine("Remove product" + productName);
        }
    }
    public void ViewCart(){
        if(Items.Count == 0)
        {
            Console.WriteLine("Cart is empty");
            return;
        }
        foreach( var item in Items )
        {
            Console.WriteLine($"Product: {item.Name}, Price: {item.Price} \r\n");
        }
    }
}