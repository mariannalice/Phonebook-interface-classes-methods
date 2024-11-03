using ContactApp;

namespace Phonebook_interface_classes_methods;

class Program
{
    static void Main(string[] args)
    {
       // Contact contactOne = new Contact("Alice", 23206578);
       // Contact contactTwo = new Contact ("Garry", 55336677);
       // Contact contactThree = new Contact ("Magda", 44557722);
       // Contact contactFour = new Contact("Valborg", 66882299);

       // Console.WriteLine(contactTwo);


        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();

        Phonebook myPhonebook = new Phonebook();

        Console.WriteLine("Welcome to your new Phonebook!");
        string? userSelection  = "";
        while (!userSelection.Equals("exit"))
        {
            Console.WriteLine(@"
            To add a new contact write: Add
            To remove a contact write: Delete
            To view contact count write: Count
            To exit phonebook write: Exit");

            userSelection = Console.ReadLine().ToLower();

            if(userSelection.Equals("add"))
            {
                Console.WriteLine("What's the name of the new contact?");
                string? inputName = Console.ReadLine();
                Console.WriteLine("What's the number of the new contact?");
                int inputNumber = int.Parse(Console.ReadLine());
                Contact newContact = new Contact(inputName, inputNumber);
                myPhonebook.AddContact(newContact);
                Console.WriteLine("New contact added to phonebook: " + newContact); 
                
            }
            
            if(userSelection.Equals("delete"))
            {
                Console.WriteLine("Write the name of the contact you would like to delete:");
                string? inputName = Console.ReadLine();
                myPhonebook.RemoveContactByName(inputName);
            }

            if(userSelection.Equals("count"))
            {
                int count = myPhonebook.GetContactCount();
                Console.WriteLine("You have " + count + " contacts in your phonebook");
                
            }
        }

    }
}
