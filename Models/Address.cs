using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _zip;

        private static List<Address> _addresses = new List<Address> {};

        public Address (string street, string city, string state, string zip)
        {
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;
            _addresses.Add(this);
        }

        public string GetStreet()
        {
            return _street;
        }

        public void SetStreet(string newStreet)
        {
            _street = newStreet;
        }

        public string GetCity()
        {
            return _city;
        }

        public void SetCity(string newPhone)
        {
            _phone = newPhone;
        }

        public string GetState()
        {
            return _state;
        }

        public void SetState(string newState)
        {
            _state = newState;
        }

        public string GetZip()
        {
            return _zip;
        }

        public void SetZip(int newZip)
        {
            _zip = newZip;
        }

        public static List<Address> GetAllAddresses()
        {
            return _addresses;
        }

        public void Save()
        {
            Address newAddress = new Address(_street, _city, _state, _zip);
            _addresses.Add(newAddress);
        }

        public static void ClearAllAddresses()
        {
            _addresses.Clear();
        }
    }
}
