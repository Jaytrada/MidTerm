using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170F23;
using NUnit.Framework;

namespace TempConversionTest
{
    public class Class1
    {
        [TestFixture]
        public class TempConversionTest
        {
            private Temp _temp;

            [SetUp]
            public void Setup()
            {
                _temp = new Temp();
            }

            [Test] public void TempretureConverterInputIsMinus1() {

                //Arrange
                float TempInput = -1.0f;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }

            [Test]
            public void TempretureConverterInputIsMinus2()
            {

                //Arrange
                float TempInput = -2.0f;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIsMinus5()
            {

                //Arrange
                float TempInput = -5.0f;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs32()
            {

                //Arrange
                float TempInput = 32.0f;
                string expectedOutput = "It's Boiling!!";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs35()
            {

                //Arrange
                float TempInput = 35.0f;
                string expectedOutput = "It's Boiling!!";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs40()
            {

                //Arrange
                float TempInput = 40.0f;
                string expectedOutput = "It's Boiling!!";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs21()
            {

                //Arrange
                float TempInput = 21.0f;
                string expectedOutput = "It's nice today";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs27()
            {

                //Arrange
                float TempInput = 27.0f;
                string expectedOutput = "It's nice today";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs29pt5()
            {

                //Arrange
                float TempInput = 29.5f;
                string expectedOutput = "It's nice today";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs15()
            {

                //Arrange
                float TempInput = 15.0f;
                string expectedOutput = "It's very pleasant";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs17()
            {

                //Arrange
                float TempInput = 17.0f;
                string expectedOutput = "It's very pleasant";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIs10()
            {

                //Arrange
                float TempInput = 10.0f;
                string expectedOutput = "It's very pleasant";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIsMinus1()
            {

                //Arrange
                float TempInput = -1;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIsMinus1()
            {

                //Arrange
                float TempInput = -1;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }
            [Test]
            public void TempretureConverterInputIsMinus1()
            {

                //Arrange
                float TempInput = -1;
                string expectedOutput = "Your Input Tempreture is not within the range";

                //Act
                string result = _temp.TemperatureConverter(TempInput);

                // Assert
                Assert.AreEqual(expectedOutput, result);

            }

        }

       
}
