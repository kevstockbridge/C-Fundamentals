using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitilized = false;

            isDeclaredAndInitilized = true;
        }
        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char numbers = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }
        [TestMethod]
        public void WholeNumber()
        {
            byte byteExample = 255;
            sbyte sByteExample = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longWxample = 9223372036854775807;
            Int64 longMin = 9223372036854775807;

            int a. = 15;
            int b. = -15;

            byte age = 25;
        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExampe = 1.2578907289045789789789789787897m;

            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);

        }       
       enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Cake;

        }
        [TestMethod]
        public void Structs()
        {
            DateTime 
        }


}
