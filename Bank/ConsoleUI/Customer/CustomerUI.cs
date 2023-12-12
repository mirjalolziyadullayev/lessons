using Bank.Interfaces;
using Bank.Models;

namespace Bank.ConsoleUI.Customer;

public class CustomerUI
{
    ICustomerService customerService;
    public void toCreate()
    {
        string Cfirstname = string.Empty;
        string Clastname = string.Empty;
        string Cphone = string.Empty;
        DateTime Cdateofbirth = DateTime.MinValue;

        Console.Clear();

        Console.WriteLine("------ (Customer Service Menu) Create Customer ------\n");
        Console.Write("Enter your Firstname: ");
        Cfirstname = Console.ReadLine();

        Console.Write("Enter your Lastname: ");
        Clastname = Console.ReadLine();

        Console.Write("Enter your Phone number: ");
        Cphone = Console.ReadLine();

        Console.Write("Enter you date of birth: ");
        Cdateofbirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        CustomerModel customer = new CustomerModel();
        customer.FirstName = Cfirstname;
        customer.LastName = Clastname;
        customer.Phone = Cphone;
        customer.DateOfBirth = Cdateofbirth;
        customerService.Create(customer);
    }
    public void toUpdate()
    {
        string Ufirstname = string.Empty;
        string Ulastname = string.Empty;
        string Uphone = string.Empty;
        DateTime Udateofbirth = DateTime.MinValue;

        Console.Clear();

        Console.WriteLine("------ (Customer Service Menu) Update Customer ------\n");
        Console.Write("Enter your Firstname: ");
        Ufirstname = Console.ReadLine();

        Console.Write("Enter your Lastname: ");
        Ulastname = Console.ReadLine();

        Console.Write("Enter your Phone number: ");
        Uphone = Console.ReadLine();

        Console.Write("Enter you date of birth: ");
        Udateofbirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

        CustomerModel customer = new CustomerModel();
        customer.FirstName = Ufirstname;
        customer.LastName = Ulastname;
        customer.Phone = Uphone;
        customer.DateOfBirth = Udateofbirth;

        customerService.Update(customer);
    }
    public void toDelete()
    {
        Console.Clear();

        int Did = 0;

        Console.WriteLine("------ (Customer Service Menu) Delete Customer ------\n");
        Console.WriteLine(" Enter an ID: ");
        string stringID = Console.ReadLine();
        if (stringID != "")
        {
            Did = int.Parse(stringID);
        }
        var found = customerService.Delete(Did);
        if (found == false)
        {
            Console.WriteLine($"Customer with ID {Did} not found!");
        }
    }
    public void toGetByID()
    {
        Console.Clear();

        int Did = 0;

        Console.WriteLine("------ (Customer Service Menu) Get by ID Customer ------\n");
        Console.WriteLine(" Enter an ID: ");
        string stringID = Console.ReadLine();
        if (stringID != "")
        {
            id = int.Parse(stringID);
        }
        customerService.Delete(Did);
    }
    public void toGetAll()
    {

    }
}


