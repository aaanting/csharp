using System;

namespace csharp_basics.Models;

public class PaintSpecification
{
  public string Color;
  public int SizeInLiters;

  public PaintSpecification(string color, int sizeInLiters)
  {
    Color = color;
    SizeInLiters = sizeInLiters;
  }

  public void DisplaySpecification()
  {
    string description = $"Color: {Color}, \nSize in liters: {SizeInLiters}";
    Console.WriteLine(description);
  }

}