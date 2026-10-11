using csharp_basics.Enums;
using csharp_basics.Interfaces;

namespace csharp_basics.Models;

public class PaintProduct : IBuyable
{
	public readonly decimal TaxRate;
	public const decimal DefaultDiscount = 0.05m;

	public string Name { get; set; }
	public PaintType Type { get; set; }
	public PaintSpecification Specification { get; set; }
	public decimal Price { get; set; }
	public Brand Brand;

	public PaintProduct(string name, PaintType type, PaintSpecification specification, decimal price, Brand brand)
	{
		Name = name;
		Type = type;
		Specification = specification;
		Price = price;
		TaxRate = 0.1m;
		Brand = brand;
	}

	public decimal GetFinalPrice()
	{
		return Price * (1 - DefaultDiscount) * (TaxRate + 1);
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"\nName: {Name}, \nType: {Type},\nBrand: {Brand.Name}");
		Specification.DisplaySpecification();
		string description = $"Price: {Price},\nFinal price: {GetFinalPrice():F2}";
		Console.WriteLine(description);
	}

	public decimal GetMaxDiscount(int rate, bool isOverridable)
	{
		if (rate < 0 || rate > 100)
		{
			Console.WriteLine("Rate must be between 0 to 100");

		}

		if (!isOverridable)
		{
			return DefaultDiscount;
		}
		else
		{
			return rate / 100m;
		}
	}
}