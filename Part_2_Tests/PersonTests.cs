using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Part_2;
using Xunit.Sdk;

namespace Part_2_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Person_IsIPerson()
        {
            // Act && Assert
            Assert.IsTrue(new Person() is IPerson);
        }

        [TestMethod]
        public void Person_ContainsNeededProperties()
        {
            // Arrange
            Type person = typeof(Person);

            // Act
            PropertyInfo id = person.GetProperty("Id");
            PropertyInfo firstName = person.GetProperty("FirstName");
            PropertyInfo lastName = person.GetProperty("LastName");
            PropertyInfo email = person.GetProperty("Email");
            PropertyInfo gender = person.GetProperty("Gender");

            // Assert
            Assert.IsNotNull(id);
            Assert.IsNotNull(firstName);
            Assert.IsNotNull(lastName);
            Assert.IsNotNull(email);
            Assert.IsNotNull(gender);
            Assert.AreEqual(typeof(long), id.PropertyType);
            Assert.AreEqual(typeof(string), firstName.PropertyType);
            Assert.AreEqual(typeof(string), lastName.PropertyType);
            Assert.AreEqual(typeof(string), email.PropertyType);
            Assert.AreEqual(typeof(Gender), gender.PropertyType);
        }

        [TestMethod]
        public void Person_ContainsNeededMethods()
        {
            // Arrange
            Type person = typeof(Person);

            // Act
            MethodInfo getFullName = person.GetMethod("GetFullName");


            // Assert
            Assert.IsNotNull(getFullName);
            Assert.AreEqual(typeof(string), getFullName.ReturnType);
        }
    }
}
