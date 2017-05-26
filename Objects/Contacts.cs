using System.Collections.Generic;

namespace Contacts.Objects
{
  public class Contacts
  {
    private string _name;
    private int _number;
    private string _address;
    private int _id;
    private static List<Contacts> _instances = new List<Contacts> {};

    public Contacts (string name, int number, string address)
    {
      _name = name;
      _number = number;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }
  }
}
