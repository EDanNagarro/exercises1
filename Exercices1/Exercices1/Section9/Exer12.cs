using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1.Section9
{
    internal class Exer12
    {
        public class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }

            public void Call()
            {
                System.Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
            }
            public Contact(string name, string phone)
            {
                Name = name;
                Phone = phone;
            }
        }

        public class PhoneBook : IEnumerable<Contact>
        {

            public List<Contact> Contacts;

            public PhoneBook()
            {
                Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
            }

            IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
            {
                return Contacts.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        public static class Program
        {
            static public void Run()
            {
                PhoneBook MyPhoneBook = new PhoneBook();

                foreach (Contact contact in MyPhoneBook)
                {
                    contact.Call();
                }
            }
        }
    }
}
