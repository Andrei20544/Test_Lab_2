using NUnit.Framework;
using _3_Lab_2;
using System.Security.Cryptography;

namespace UnitTestLab_2
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            //Arrange
            string source = "12";
            string truehash = "6b51d431df5d7f141cbececcf79edf3dd861c3b4069f0b11661a3eefacbba918";

            //Act
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = _3_Lab_2.Program.GetHash(sha256Hash, source);

                //Assert
                Assert.AreEqual(truehash, hash);
            }                      

           
        }
    }
}