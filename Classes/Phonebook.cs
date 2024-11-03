using ContactApp;

public class Phonebook : IPhonebook
{
  public List<Contact> ContactList;

  public Phonebook()
  {
    ContactList = new List<Contact>();
  }

  public void AddContact(Contact newContact)
  {
    ContactList.Add(newContact);
  }

  public bool RemoveContactByName(string name)
  {
    foreach (var contact in ContactList)
    {
      if (contact.name.ToLower().Equals(name.ToLower()))
      {
        ContactList.Remove(contact);
        Console.WriteLine("Successfully removed: " + contact);
        return true;
      }
    }
    Console.WriteLine("Found no contact with the name: " + name);
    return false;
    
  }

  public int GetContactCount()
  {
    return ContactList.Count();
  }
}