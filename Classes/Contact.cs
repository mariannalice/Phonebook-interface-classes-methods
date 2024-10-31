using System.Security.Cryptography;

public class Contact : IContact
{
  // Private fields to store name and number
  private string name;
  private int number;

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
}