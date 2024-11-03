using System.Security.Cryptography;
namespace ContactApp
{
  public class Contact : IContact
  {
    // Private fields to store name and number
    public string name;
    public int number;

  // Constructor
    public Contact(string newName, int newNumber)
    {
      name = newName;
      number = newNumber;
    }

    public void AddName(string newName)
    {
      name = newName;
    }

    public void AddNumber(int newNumber)
    {
      number = newNumber;
    }

    public override string ToString()
    {
      return name + ", " + number;
    }
  }
}