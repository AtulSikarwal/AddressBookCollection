namespace AddressBookSystemDay23
{
    internal class AdressBookSystem
    {
        public Dictionary<string, AddressBook> adressBooks = new Dictionary<string, AddressBook>();
        public void AddAddressBook()
        {
            AddressBook adressBook = new AddressBook();
            adressBook.AddMultiple();
            Console.WriteLine("enter the addressbook name");
            string addressName = Convert.ToString(Console.ReadLine());
            adressBooks.Add(addressName.ToLower(), adressBook);

        }
    }
}