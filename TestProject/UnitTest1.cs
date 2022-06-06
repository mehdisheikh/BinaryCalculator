using test_wpf.Services;
using System.Windows.Input;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            BiCalculator biCalculator = new BiCalculator();
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Add.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D0.ToString().ToLower());
            Assert.AreEqual("1001", biCalculator.Input(Key.Enter.ToString().ToLower()));
        }
        [TestMethod]
        public void Subtract()
        {
            BiCalculator biCalculator = new BiCalculator();
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Subtract.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D0.ToString().ToLower());
            Assert.AreEqual("101", biCalculator.Input(Key.Enter.ToString().ToLower()));
        }
        [TestMethod]
        public void Enter()
        {
            BiCalculator biCalculator = new BiCalculator();
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Subtract.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Enter.ToString().ToLower());
            Assert.AreEqual("101", biCalculator.Input(Key.Enter.ToString().ToLower()));
        }
        [TestMethod]
        public void ClearAll()
        {
            BiCalculator biCalculator = new BiCalculator();
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Subtract.ToString().ToLower());
            biCalculator.Input(Key.D1.ToString().ToLower());
            biCalculator.Input(Key.Enter.ToString().ToLower());
            Assert.AreEqual("0", biCalculator.Input(Key.Escape.ToString().ToLower()));
        }
    }
}