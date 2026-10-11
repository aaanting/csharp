using csharp_basics.Models;

public class PaintStore
{
  public PaintProduct[] Products { get; set; }

  public PaintStore(PaintProduct[] products)
  {
    Products = products;
  }

  public void DisplayPaintStore()
  {
    Console.WriteLine("All paint products:");
    foreach (PaintProduct product in Products)
    {
      product.DisplayInfo();
    }
  }
}