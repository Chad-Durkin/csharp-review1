using System.Collection.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _phoneNumber;
    private int _id;
    private static List<Contact> _contacts = new List<Contact> {};

    public Contact(string name, string address, int phoneNumber)
    {
      _name = name;
      _address = address;
      _phoneNumber = phoneNumber;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string address)
    {
      _address = address;
    }

    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(int phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _contacts;
    }

    public static Contact FindContact(int searchId)
    {
      return _contacts[searchId-1];
    }

    public static void ClearAll()
    {
      _contacts.Clear();
    }
  }
}
