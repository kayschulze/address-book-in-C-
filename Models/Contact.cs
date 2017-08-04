using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phone;
        private string _address;

        private static List<Contact> _contacts = new List<Contact> {};

        public Contact (string name, string phone, string address)
        {
            _name = name;
            _phone = phone;
            _address = address;
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

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string newAddress)
        {
            _address = newAddress;
        }

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
    }
}
