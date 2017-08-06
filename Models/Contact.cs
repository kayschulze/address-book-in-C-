using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phone;
        private Address _address;
        private int _id;

        private static List<Contact> _contacts = new List<Contact> {};

        public Contact (string name, string phone, Address fulladdress)
        {
            _name = name;
            _phone = phone;
            _address = fulladdress;
            _id = _contacts.Count;
            _contacts.Add(this);
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public string GetPhone()
        {
            return _phone;
        }

        public void SetPhone(string newPhone)
        {
            _phone = newPhone;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public void SetAddress(Address newAddress)
        {
            _address = newAddress;
        }

        public int GetID()
        {
            return _id;
        }

        public void SetID(int newID)
        {
            _id = newID;
        }

        // public string GetThisStreet()
        // {
        //   Address.GetStreet();
        // }

        public static List<Contact> GetAll()
        {
            return _contacts;
        }

        public void Save()
        {
            Contact newContact = new Contact(_name, _phone, _address);
            _contacts.Add(newContact);
        }

        public static void ClearAll()
        {
            _contacts.Clear();
        }

        public static Contact Find(int searchID)
        {
            return _contacts[searchID];
        }

        public static void DeleteContact(Contact thiscontact)
        {
            _contacts.RemoveAt(thiscontact._id);
        }
    }
}
