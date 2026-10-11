using csharp_basics.Models;

public class Order
{
  public readonly DateTime CreatedAt;
  public PaintProduct[] Products { get; set; }
  public int[] Quantities { get; set; }
  public decimal TotalPrice { get; }

  // constructor
  public Order(PaintProduct[] paintProducts, int[] quantities)
  {
    CreatedAt = DateTime.Now;
    Products = paintProducts;
    Quantities = quantities;
    TotalPrice = GetTotalOrderPrice();
  }

  public void DisplayOrder()
  {
    Console.WriteLine("Order information:");
    Console.WriteLine($"CreatedAt: {CreatedAt}");
    for (int i = 0; i < Products.Length; i++)
    {
      Products[i].DisplayInfo();
      Console.WriteLine($"Quantity: {Quantities[i]}");
    }
    Console.WriteLine($"Total order price: {TotalPrice:F2}");
  }

  public decimal GetTotalPrice(PaintProduct product, int quantity)
  {
    return quantity * product.GetFinalPrice();
  }

  // calculate total order price
  public decimal GetTotalOrderPrice()
  {
    decimal sum = 0m;
    for (int i = 0; i < Products.Length; i++)
    {
      sum += GetTotalPrice(Products[i], Quantities[i]);
    }
    return sum;

  }

}