using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private int _id;
    private static List<Contact> _contacts = new List<Contact> {};

    public Contact(string name, string address, string phoneNumber)
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

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string phoneNumber)
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

    public static void DeleteContact(string name)
    {
      for(var index = 0; index < _contacts.Count; index++)
      {
        if(_contacts[index].GetName().ToLower() == name.ToLower())
        {
          _contacts.RemoveAt(index);
        }
      }
    }
  }
}
