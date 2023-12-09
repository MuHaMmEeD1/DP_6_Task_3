



public class ClothesShop
{
    private double endirimFaizi; 
    
    List<Customer> customers = new List<Customer>();

    public double EndirimFaizi
    {
        get { return endirimFaizi; } 
        set { endirimFaizi = value; XeberVer(); } 

    }

    void XeberVer()
    {
        foreach (var item in customers)
        {
            Console.WriteLine($"{item.Name} mustermiz {endirimFaizi} endirim var");
        }
        
    }


    public void addCustomer(Customer customer){customers.Add(customer);}

    public void removeCustomer(Customer customer) { customers.Remove(customer); }



}



public class Customer
{
    public string Name { get; set; }




}


public class Program
{
    static void Main(string[] args)
    {
        ClothesShop clothesShop = new ClothesShop();
        
        Customer customer1 = new Customer() { Name="murad" };
        Customer customer2 = new Customer() { Name="selim" };
        Customer customer3 = new Customer() { Name="kamal" };

        clothesShop.addCustomer(customer1);
        clothesShop.addCustomer(customer2);
        clothesShop.addCustomer(customer3);


        clothesShop.EndirimFaizi = 4;


        clothesShop.removeCustomer(customer3);

        Console.WriteLine();

        clothesShop.EndirimFaizi = 9;


    }



}









