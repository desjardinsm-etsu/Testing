using System;
using Xunit;



namespace MyFirstUnitTests
{
    public class UnitTest1
    {

        [Fact] //This is a test Annonotation
        public void TestPerson()
        {
            //Arrange - Prep all the data, test artifacts.
            var person = new Person.Person { Id = 1, FirstName = "Mathew", LastName = "Desjardins" };

            //Act - Simulate the call to the method or action.



            //Assert - Did the test pass or fail?
            Assert.Equal("Mathew", person.FirstName);
         
        }
    }
}
