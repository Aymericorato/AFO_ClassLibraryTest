using NUnit.Framework;
using AFO_ClassLibraryTest;

namespace Test_Projet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //AAA
            //Arange
            Class1 C1 = new Class1();

            int a = 3;
            int b = 4;
            int c = 8;
            int expected = 15;
            //Act
            var value = C1.CalculeSomme(a, b, c);

            //Assert
            Assert.AreEqual(expected, value);
        }
        [Test]
        public void Test2()
        {
            //AAA
            //Arange
            Class1 C2 = new Class1();

            int a = 3;
            int b = 4;
            int c = 8;
            int expected = 14;

            //Act
            var value = C2.CalculeSomme(a, b, c);

            //Assert
            Assert.AreEqual(value, expected);
        }
    }
}