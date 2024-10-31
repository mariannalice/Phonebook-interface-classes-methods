public interface IContact
{
  /// <summary>
  /// Adds a new number to a new contact, or overwrites an existing number.
  /// </summary>
  /// <param name="newNumber">the phonenumber to add</param>
  void AddNumber(int newNumber);

/// <summary>
/// Adds a name to the number in a new contact, or overwrites existing name.
/// </summary>
/// <param name="newName"></param>
  void AddName(string newName);

}