namespace csharp_basics.Models;

public class User
{
  public string Name { get; set; }
  public int Age { get; set; }

  public User(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public void DisplayUserInfo()
  {
    Console.WriteLine($"Name: {Name}, Age: {Age}");
  }

  public void UpdateUserInfo(string name, int age)
  {
    Name = name;
    Age = age;
  }
}