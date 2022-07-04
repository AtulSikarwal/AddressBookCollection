namespace AddressBookSystemDay23
{
    class Program
    {
        public static void Main(String[] args)
        {
            AddressBook address = new AddressBook();
            address.CreateContact();
            address.Display();
        }
    }
}