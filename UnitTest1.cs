// StudentTests.cs in SchoolDataTests project
using NUnit.Framework;

namespace SchoolDataTests
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        [TestCase("John", "Doe",true)]
        [TestCase("Jane", "Smith",true)]
        
        
        public void Student_IsValidFullName(string firstName, string lastName, bool expectedResult)
        {
            // Arrange
            var student = new Student(firstName, lastName);

            // Act
            var result = student.IsValidFullName();

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult),
                $"For {firstName} {lastName}, expected: {expectedResult}, but got: {result}");
        }

        [Test]
        public void Student_Constructor_ValidInitialization()
        {
            // Arrange
            string firstName = "John";
            string lastName = "Doe";

            // Act
            var student = new Student(firstName, lastName);

            // Assert
            Assert.That(student.FirstName, Is.EqualTo(firstName));
            Assert.That(student.LastName, Is.EqualTo(lastName));
        }

        // Add more tests for other methods and properties in the Student class
    }
}
