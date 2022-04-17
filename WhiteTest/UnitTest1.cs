using NUnit.Framework;
using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;



namespace WhiteTest
{
    public class Tests
    {
        private Application _application;
        private readonly string PATH = "C:\\Users\\ADMIN\\Desktop\\Tests\\TestLabCalcApp\\bin\\Debug\\TestLabCalcApp.exe";

        public Window GetWindow()
        {
            return _application.GetWindow("Form1");
        }

        private object ResultTextBox()
        {
            string str = GetWindow().Get<Label>("label1").Text;
            return str;
        }
        public Button GetButton(string nameWindow)
        {
            var button = GetWindow().Get<Button>(SearchCriteria.ByText(nameWindow));
            if (button != null) return button;
            return null;
        }

        [Test]
        public void PlusNumbers()
        {
            _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("1").Click();
            GetButton("+").Click();
            GetButton("2").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "3");
            _application.Close();
        }

        [Test]
        public void DevNumbers()
        {
            _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("3").Click();
            GetButton("/").Click();
            GetButton("6").Click();
            GetButton("-/+").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "-0,5");
            _application.Close();
        }

        [Test]
        public void DevByZeroNumbers()
        {
            _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("4").Click();
            GetButton("/").Click();
            GetButton("0").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "Error: Division By Zero");
            _application.Close();
        }

        [Test]
        public void DelSubNumbers()
        {
            _application = Application.Launch(PATH);
            Assert.IsNotNull(_application);
            GetButton("5").Click();
            GetButton("7").Click();
            GetButton("5").Click();
            GetButton("<").Click();
            GetButton("-").Click();
            GetButton("7").Click();
            GetButton("8").Click();
            GetButton("9").Click();
            GetButton("0").Click();
            GetButton("<").Click();
            GetButton("=").Click();
            Assert.AreEqual(ResultTextBox(), "-732");
            GetButton("C").Click();
            Assert.AreEqual(ResultTextBox(), "0");
            _application.Close();
        }
    }
}