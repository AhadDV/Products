
internal class ProductDb
{
    Product[] Products = new Product[2];


    public void AddProduct(Product product)
    {
        if (Products[Products.Length - 1] != null)
        {
            Console.WriteLine("Yer doludur");
            return;
        }
        int Index = Array.IndexOf(Products, null);

        if (Index != -1)
            Products[Index] = product;
    }

    public void SearchProduct(string search)
    {
        foreach (var item in Products)
        {
            if (item != null)
            {
                if (item.Name == search)
                {
                    Console.WriteLine(item.Name);
                    break;
                }
            }
        }
    }

    public void SearchProduct2(string search)
    {
        int index = Array.IndexOf(Products, null);

        index = index == -1 ? Products.Length :index;

        for (int i = 0; i < index; i++)
        {
            if (Products[i].Name.Contains(search))
            {
                Console.WriteLine(Products[i].Name);
            }
        }
    }

}
