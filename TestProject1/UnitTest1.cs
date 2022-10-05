using Address_Book_ADO;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        AddressBookRepositories addressBookRepo;
        [SetUp]
        public void Setup()
        {
             addressBookRepo = new AddressBookRepositories();
        }

        [Test]
        public void Test1()
        {
            int actual = addressBookRepo.GetContactDetails();
            int expected = 6;
            Assert.That(actual, Is.EqualTo(expected));
            //Assert.Pass();
        }
       
        [Test]
        public void TestMethodToCheckModify()
        {
            AddressBook addressBook = new AddressBook();
            addressBook.FirstName = "xxx";
            addressBook.LastName = "yyy";
            addressBook.PhoneNumber = "7412369852";
            addressBook.email = "xyz@gmail.com";
            int actual = addressBookRepo.ModifyDetails(addressBook);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DeleteContact()
        {
            AddressBook addressBook = new AddressBook();
            addressBook.FirstName = "Mohd";
            addressBook.LastName = "Aadil";
            int actual = addressBookRepo.DeletePerson(addressBook);
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PrintContactBasedOnCityName()
        {
            int actual = addressBookRepo.PrintDataBasedOnCity("Chennai");
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrintCountBasedOnCityAndState()
        {
            List<int> actual = addressBookRepo.PrintCountBasedOnCityAndStateName();
            int[] temp = { 1, 1, 3, 1 };
            var expected = new List<int>(temp);
            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void SortBasedOnNameGivenCity()
        {
            List<string> actual = addressBookRepo.PrintSortedNameBasedOnCity("Chennai");
            string[] temp = { "Amir", "Ram" };
            var expected = new List<string>(temp);
            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void TestMethodPrintCountBasedOnType()
        {
            List<int> actual = addressBookRepo.PrintCountBasedOnAddressBookType();
            int[] temp = { 2, 2, 1 };
            var expected = new List<int>(temp);
            CollectionAssert.AreEqual(actual, expected);
        }

    }
}