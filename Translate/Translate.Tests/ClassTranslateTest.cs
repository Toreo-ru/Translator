using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YandexLinguistics.NET;

namespace Translate.Tests
{
    [TestClass]
    public class ClassTranslateTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange

            string wordTranslate = "Hello!";
            string inputLang = "Английский";
            string outputLang = "Русский";
            string expected = "Привет!";
            string actual;

            //act

            actual = ClassTranslate.Translator(wordTranslate, inputLang, outputLang);

            //assert

            Assert.AreEqual(expected, actual);

        }
    }
}
