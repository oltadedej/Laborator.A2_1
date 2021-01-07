using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laborator_A2_1_Web.Laborator3.Domain
{
    public class Configurations
    {
        public List<PhoneBook> phoneBooks { get; set; } = new List<PhoneBook>();

        public Configurations()
        {
            PhoneBook newItem = new PhoneBook();
            newItem.IdPhoneBook = 1;
            newItem.PhoneBookPersonName = "Test1";
            newItem.PhoneNumber = "88888541";
            newItem.PhoneType = 1;
            phoneBooks.Add(newItem);
            newItem = new PhoneBook();

            newItem.IdPhoneBook = 2;
            newItem.PhoneBookPersonName = "Test2";
            newItem.PhoneNumber = "879546666";
            newItem.PhoneType = 2;
            phoneBooks.Add(newItem);


        }


    }
}