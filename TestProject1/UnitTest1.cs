using Address_Book_ADO;
using NUnit.Framework;

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
    }
}