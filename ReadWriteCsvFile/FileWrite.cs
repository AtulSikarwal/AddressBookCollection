using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookSystemDay23
{
    internal class FileWrite
    {
        public static string path = @"D:\dotnet\AddressBookSystemDay23AddressBookFile.txt";
        public static string csvPath = @"D:\dotnet\CSVFileForAddressBook.csv";
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

    }
}
