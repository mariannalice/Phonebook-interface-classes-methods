using System.Runtime.CompilerServices;
using ContactApp;

public interface IPhonebook
{
  /// <summary>
  /// Adds a new contact to a list of contacts
  /// </summary>
  /// <param name="newContact"></param>
  public void AddContact(Contact newContact);

/// <summary>
/// Removes a contact from a list of contacts
/// </summary>
/// <param name="name"></param>
  public bool RemoveContactByName(string name);

/// <summary>
/// Shows how many contacts we have in our phonebook
/// </summary>
/// <param name="ContactCount"></param>
/// <returns>count of contacts</returns>
  public int GetContactCount();
}
