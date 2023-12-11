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

        Console.WriteLine("------ (Customer Service Menu) Create Suctomer ------\n");
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

        Console.WriteLine("------ (Customer Service Menu) Update Suctomer ------\n");
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

    }
    public void toGetByID()
    {

    }
    public void toGetAll()
    {

    }
}


