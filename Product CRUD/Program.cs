using Product_CRUD;

List<Product> products = new List<Product>();

bool loop = true;

while (loop == true)
{
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Product Inventory program.");
    Console.WriteLine("--------------------------------\n");
    Console.WriteLine("1. Get list of products.");
    Console.WriteLine("2. Create new Product.");
    Console.WriteLine("3. Update product.");
    Console.WriteLine("4. Delete product.\n");
    Console.WriteLine("5. Exit program.\n");
    Console.Write("Enter your choice: ");
    string choice = (Console.ReadLine());

    Console.Clear();

    switch (choice)
    {
        case "1":
            GetAllProducts();
            break;
        case "2":
            Console.WriteLine("|-----Create Product----|\n");
            Console.Write("Enter product's Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter product's Description: ");
            string description1 = Console.ReadLine();
            Console.WriteLine("-------------------------\n");

            CreateProduct(name1, description1);
            break;
        case "3":
            Console.WriteLine("|-----Update Product----|\n");
            Console.Write("Enter product's ID: ");
            int id1 = int.Parse(Console.ReadLine());
            Console.Write("Enter product's Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter product's Description: ");
            string description2 = Console.ReadLine();
            Console.WriteLine("-------------------------\n");

            UpdateProduct(id1 ,name2, description2);
            break;
        case "4":
            Console.WriteLine("|-----Delete Product----|\n");
            Console.Write("Enter product's ID: ");
            int id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------\n");

            DeleteProduct(id2);
            break;
        case "5":
            Console.WriteLine("Exit program...\n");
            loop = false;
            break;
        default: 
            Console.WriteLine("Invalid input.");
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
        Console.WriteLine($"-----------------------------GetAllProducts------------------------------\n");
        Console.WriteLine("No product's here, you shold create them");
        Console.WriteLine("--------------------------------------------------------------------------\n");
        return;
    }
    else
    {
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
            Console.WriteLine("------------------Update Product-----------------\n");
            Console.WriteLine($"Product with ID {product.Id} updated");
            Console.WriteLine("-------------------------------------------------\n");
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine("------------------Update Product-----------------\n");
        Console.WriteLine("no product with such an ID");
        Console.WriteLine("-------------------------------------------------\n");
        return;
    }
}