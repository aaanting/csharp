
using csharp_basics.Enums;
using csharp_basics.Models;

class Program
{
  static void Main()
  {
    Brand dulux = new Brand("Dulux");
    Brand au = new Brand("Australian own");
    Brand sweet = new Brand("Sweet");

    PaintProduct[] paintProducts =
    {
      new PaintProduct("Best", PaintType.BaseCoat, new PaintSpecification("white", 4), 100m, dulux),
      new PaintProduct("British Product", PaintType.Glossy, new PaintSpecification("grey", 4), 60m, sweet),
      new PaintProduct("Zin", PaintType.Matte, new PaintSpecification("blue", 10), 200m, au)
    };

    PaintStore store = new PaintStore(paintProducts);
    store.DisplayPaintStore();

    Console.WriteLine();

    PaintProduct[] tobuy =
    {
    store.Products[0], store.Products[2]
  };
    int[] quantities = [2, 4];
    Order order = new Order(tobuy, quantities);
    order.DisplayOrder();
  }
}