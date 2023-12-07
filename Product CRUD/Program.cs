using Product_CRUD;

List<Product> products = new List<Product>();

bool loop = true;


while (loop == true)
{
    Console.WriteLine("--------------------------------");
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Product Inventory program.");
    Console.ResetColor();
    Console.WriteLine("--------------------------------\n");
    Console.WriteLine("1. Get list of products.");
    Console.WriteLine("2. Create new Product.");
    Console.WriteLine("3. Update product.");
    Console.WriteLine("4. Delete product.\n");
    Console.WriteLine("5. Exit program.\n");
    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.Write("Enter your choice: ");
    Console.ResetColor();

    string choice = (Console.ReadLine());
    Console.Clear();

    switch (choice)
    {
        case "1":
            GetAllProducts();
            break;
        case "2":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Create Product----|\n");
            Console.ResetColor();
            createName:
            Console.Write("Enter product's Name: ");
            string name1 = Console.ReadLine();
            if (name1 == "")
            {
                Console.WriteLine("Press any key to re-enter");
                goto createName;
            }
            createDescription:
            Console.Write("Enter product's Description: ");
            string description1 = Console.ReadLine();
            if (description1 == "")
            {
                Console.WriteLine("Press any key to re-enter");
                goto createDescription;
            }
            Console.WriteLine("-------------------------\n");

            CreateProduct(name1, description1);
            break;
        case "3":
            
            int id = 0;
            string name = string.Empty;
            string description = string.Empty;

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Update Product----|\n");
            Console.ResetColor();
            updateId:
            Console.Write("Enter product's ID: ");
            string[] values = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9,", "0" };
            var getUpdate = Console.ReadLine();
            if (getUpdate != "" && (values.Any(getUpdate.Contains)))
            {
                id = int.Parse(getUpdate);
            }
            else
            {
                Console.WriteLine("Press any key to re-enter");
                goto updateId;
            }
            updateName:
            Console.Write("Enter product's Name: ");
            name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("Press any key to re-enter");
                goto updateName;
            }
            updateDescription:
            Console.Write("Enter product's Description: ");
            description = Console.ReadLine();
            if (description == "")
            {
                Console.WriteLine("Press any key to re-enter");
                goto updateDescription;
            }
            Console.WriteLine("-------------------------\n");

            UpdateProduct(id ,name, description);
            break;
        case "4":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|-----Delete Product----|\n");
            Console.ResetColor();
            deleteId:
            Console.Write("Enter product's ID: ");
            string[] values1 = new string[] {"1","2","3","4","5","6","7","8","9,","0"};
            var getDelete = Console.ReadLine();
            if (getDelete != "" && (values1.Any(getDelete.Contains))) 
            {
                int id2 = int.Parse(getDelete);
                DeleteProduct(id2);
            }
            else
            {
                Console.WriteLine("Press any key to re-enter");
                goto deleteId;
            }
            Console.WriteLine("-------------------------\n");
            break;
        case "5":
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Exit program...\n");
            Console.ResetColor();
            loop = false;
            break;
        default:

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid input.");
            Console.ResetColor();
            continue;
    }
}


void CreateProduct(string name, string description)
{
    Product product = new Product();
    product.Id = products.Count + 1;
    product.Name = name;
    product.Description = description;

    products.Add(product);

    Console.Clear();
    Console.WriteLine("----------------Created Product----------------\n");
    Console.WriteLine($"Product's ID: {product.Id}");
    Console.WriteLine($"Product's Name: {product.Name}");
    Console.WriteLine($"Product's Description: {product.Description}");
    Console.WriteLine("-----------------------------------------------\n");
}
void GetAllProducts()
{
    if (products.Count==0)
    {
        Console.Clear();

        Console.WriteLine($"-----------------------------GetAllProducts------------------------------\n");
        Console.WriteLine("No product's here, you should create them");
        Console.WriteLine("--------------------------------------------------------------------------\n");
        return;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"--------------------------GetAllProducts---------------------------------\n");
        foreach (var product in products)
        {
            Console.WriteLine($"----------------Product {product.Id}----------------\n");
            Console.WriteLine($"Product's ID: {product.Id}");
            Console.WriteLine($"Product's Name: {product.Name}");
            Console.WriteLine($"Product's Description: {product.Description}");
            Console.WriteLine("-------------------------------------------------\n");
        }
        Console.WriteLine("--------------------------------------------------------------------------\n");
    }
}
void DeleteProduct(int id)
{
    bool found = false;
    foreach (var product in products)
    {
        if (product.Id == id)
        {
            Console.Clear();
            Console.WriteLine("------------------Delete Product-----------------\n");
            Console.WriteLine($"Product with ID {product.Id} removed");
            Console.WriteLine("-------------------------------------------------\n");
            products.Remove(product);
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.Clear();
        Console.WriteLine("------------------Delete Product-----------------\n");
        Console.WriteLine("no product with such an ID");
        Console.WriteLine("-------------------------------------------------\n");
        return;
    }
}
void UpdateProduct(int id, string name, string description)
{
    bool found = false;
    foreach (var product in products)
    {
        if (product.Id == id)
        {
            if (name != "")
            {
                product.Name = name;
            }
            if (description != "")
            {
                product.Description = description;
            }
            Console.Clear();
            Console.WriteLine("------------------Update Product-----------------\n");
            Console.WriteLine($"Product with ID {product.Id} updated");
            Console.WriteLine("-------------------------------------------------\n");
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.Clear();
        Console.WriteLine("------------------Update Product-----------------\n");
        Console.WriteLine("no product with such an ID");
        Console.WriteLine("-------------------------------------------------\n");
        return;
    }
}
