using System.Collections.Generic;

namespace ContactList.Objects
{
  public class Contact
  {
    private string _name;
    private int _number;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, int number, string address)
    {
      _name = name;
      _number = number;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public int GetNumber()
    {
      return _number;
    }
    public string GetAddress()
    {
      return _address;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
  }
}
