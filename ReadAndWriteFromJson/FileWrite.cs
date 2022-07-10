using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AddressBookSystemDay23
{
    internal class FileWrite
    {
        public static string path = @"G:\FellowShip517\Dya23_CollectionAddressBook\Day23_AddressBookCollections\CollectinAddressBook\AddressBookFile.txt";
        public static string csvPath = @"G:\FellowShip517\Dya23_CollectionAddressBook\Day23_AddressBookCollections\CollectinAddressBook\CSV_AddressBook.csv";
        public static string jsonPath = @"G:\FellowShip517\Dya23_CollectionAddressBook\Day23_AddressBookCollections\CollectinAddressBook\JSON_AddressBook.json";
        public static void WriteUsingStreamWriter(List<Contact> data)
        {

            if (File.Exists(path))
            {
                File.WriteAllText(path, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("FirstName\tLastName\t Address\t City\t State\t Zip\t Contact\t Email");
                    foreach (Contact contacts in data)
                    {
                        streamWriter.WriteLine(contacts.FirstName + "\t" + contacts.LastName + "\t" + contacts.Address + "\t" + contacts.City + "\t" + contacts.State + "\t" + contacts.Zip + "\t" + contacts.PhoneNumber + "\t" + contacts.EmailId);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void readFile()
        {
            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
        public static void csvFileWriter(List<Contact> dataa)
        {

            if (File.Exists(csvPath))
            {
                File.WriteAllText(csvPath, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(csvPath))
                {
                    streamWriter.WriteLine("FirstName,LastName,Address,City,State,Zip,Contact,Email");
                    foreach (Contact contacts in dataa)
                    {
                        streamWriter.WriteLine(contacts.FirstName + "," + contacts.LastName + "," + contacts.Address + "," + contacts.City + "," + contacts.State + "," + contacts.Zip + "," + contacts.PhoneNumber + "," + contacts.EmailId);
                    }
                    streamWriter.Close();
                    Console.WriteLine("Contacts Stored in Csv_File.");
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
        public static void readFromCSVFile()
        {
            if (File.Exists(csvPath))
            {
                using (StreamReader streamReader = File.OpenText(csvPath))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        string[] csv = data.Split(",");
                        foreach (string dataCsv in csv)
                        {
                            Console.Write(dataCsv + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void WriteContactsInJSONFile(List<Contact> contacts)
        {
            if (File.Exists(jsonPath))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(jsonPath))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Conatact stored in Json File...");
            }
            else
            {
                Console.WriteLine("File not found...");
            }
        }
        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(jsonPath))
            {
                IList<Contact> contactsRead = JsonConvert.DeserializeObject<IList<Contact>>(File.ReadAllText(jsonPath));
                foreach (Contact contact in contactsRead)
                {
                    contact.DisplayData();
                }
            }
            else
            {
                Console.WriteLine("File not found...");
            }
        }
    }
}
