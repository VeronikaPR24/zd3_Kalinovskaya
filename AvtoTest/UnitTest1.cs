using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

using zd3_ind;

namespace AvtoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGood_Mileage()
        {
            string input = "150000";
            string result = string.Empty;
            string mileage = Validation.CarNull(input);
            Assert.AreEqual(result, mileage);
        }
        [TestMethod]
        public void TestGood_Brand()
        {
            string input = "BMW";
            string result = string.Empty;
            string brand = Validation.CarNull(input);
            Assert.AreEqual(result, brand);
        }
        [TestMethod]
        public void Test_TolkoNum()
        {
            string input = "dfhd";
            string result = "Неправильный ввод данных, ввод только цифрами";
            string num = Validation.TolkoNum(input);
            Assert.AreEqual(result, num);
        }
        [TestMethod]
        public void Test_TolkoBukv()
        {
            string input = "23523";
            string result = "Неправильный ввод данных, ввод только буквами";
            string bukv = Validation.TolkoBukv(input);
            Assert.AreEqual(result, bukv);
        }
    }
}
