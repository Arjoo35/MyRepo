using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssign7
{
    public class Contact
    {
        private static List<Contact> contacts = new List<Contact>();
        public string ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }

        public override string ToString() => $"ContactNo: {ContactNo}\nName: {ContactName}\nCell No: {CellNo}\n";
        public static void AddContact()
        {
            var contact = new Contact();

            Console.Write("Enter ContactNo: ");
            contact.ContactNo =Console.ReadLine();


            Console.Write("Enter ContactName: ");
            contact.ContactName = Console.ReadLine();


            Console.Write("Enter CellNo: ");
            contact.CellNo = Console.ReadLine();
            contacts.Add(contact);
            Console.WriteLine("Added to contact");
        }


        public static void DisplayContact()
        {
            Console.Write("Enter ContactNo: ");
            var contactNo = Console.ReadLine();


            foreach (var item in contacts)
            {
                if (item.ContactNo == contactNo)
                {
                    Console.WriteLine(item);
                    return;
                }
            }
            Console.WriteLine("No match!!");
        }


        public static void EditContact()
        {
            Console.Write("Enter ContactNo: ");
            var contactNo = Console.ReadLine();
            Contact contact = null;
            foreach (var item in contacts)
            {
                if (item.ContactNo == contactNo)
                {
                    contact = item;
                    break;
                }
            }
            if (contact == null)
            {
                Console.WriteLine("No match found!!");
                return;
            }


            Console.Write("Enter new ContactNo: ");
            contact.ContactNo = Console.ReadLine();
            Console.Write("Enter new ContactName: ");
            contact.ContactName = Console.ReadLine();
            Console.Write("Enter new CellNo: ");
            contact.CellNo = Console.ReadLine();
            Console.WriteLine("Contact has been updated");

        }


        public static void ShowAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Empty contact list");
                return;
            }
            foreach(var item in contacts)
            {
                Console.WriteLine(item);
            }

        }
    }
    class Q1Contact
    {
       // private static List<Contact> contacts = new List<Contact>();
        
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add contact\n2. Display contact\n3. Edit contact\n4. Show all contacts\n5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Contact.AddContact();
                        break;


                    case 2:
                        Contact.DisplayContact();
                        break;


                    case 3:
                        Contact.EditContact();
                        break;


                    case 4:
                        Contact.ShowAllContacts();
                        break;


                    case 5:
                        return;


                    default:
                        break;
                }

            }
        }
        
    }
    

}

            
            




