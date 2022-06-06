using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using test_wpf.Interfaces;
using test_wpf.Models;


namespace test_wpf.Services
{
    public class BiCalculator : IBiCalculator
    {
        private Calculator _calculator { get; set; }
        private bool enterIsPressedDown =false;
        private Dictionary<string, Inputs> validValues { get; set; }
        public BiCalculator()
        {
            _calculator = new Calculator();
            validValues = new Dictionary<string, Inputs>();
            validValues.Add("return", new Inputs() { Type = InputType.controller, Value = "Repeat" });
            validValues.Add("numpad1", new Inputs() { Type = InputType.digit, Value = "1" });
            validValues.Add("numpad0", new Inputs() { Type = InputType.digit, Value = "0" });
            validValues.Add("d1", new Inputs() { Type = InputType.digit, Value = "1" });
            validValues.Add("d0", new Inputs() { Type = InputType.digit, Value = "0" });
            validValues.Add("oemplus", new Inputs() { Type = InputType.operators, Value = "Add" });
            validValues.Add("oemminus", new Inputs() { Type = InputType.operators, Value = "Subtract" });
            validValues.Add("add", new Inputs() { Type = InputType.operators, Value = "Add" });
            validValues.Add("subtract", new Inputs() { Type = InputType.operators, Value = "Subtract" });
            validValues.Add("back", new Inputs() { Type = InputType.controller, Value = "back" });
            validValues.Add("escape", new Inputs() { Type = InputType.controller, Value = "ClearEverything" });
            validValues.Add("space", new Inputs() { Type = InputType.controller, Value = "ClearEntry" });
        }
        public string Input(string value)
        {
            if (!validValues.ContainsKey(value.ToLower()))
            {
                if (string.IsNullOrEmpty(_calculator.LastValue))
                    return _calculator.Result;
                else
                    return _calculator.LastValue;
            }
            var keyboardInput = validValues[value.ToLower()];

            if (keyboardInput.Type == InputType.operators || keyboardInput.Type == InputType.controller)
            {
                
                this.GetType().GetMethod(keyboardInput.Value).Invoke(this, new object[] { });
            }
            else if (keyboardInput.Type == InputType.digit && (keyboardInput.Value == "1" || keyboardInput.Value == "0"))
            {
                _calculator.LastValue += keyboardInput.Value;
                if (string.IsNullOrEmpty(_calculator.Operation))
                {
                    _calculator.Result = _calculator.LastValue;
                }
                return _calculator.LastValue;
            }
            else
            {

            }
            return _calculator.Result;

        }
        public void Add()
        {
            if (_calculator.Operation == _calculator.LastOperation && _calculator.LastOperation == "+")
            {
                _calculator.LastValue = String.IsNullOrEmpty(_calculator.LastValue) ? "0" : _calculator.LastValue;
                _calculator.Result = BinaryConversion(_calculator.Result, _calculator.LastValue, "+");
            }
            else if (enterIsPressedDown)
            {
                enterIsPressedDown = false;
            }
            else
            {
                Repeat();
            }
            _calculator.LastOperation = "+";
            _calculator.Operation = "+";
            _calculator.LastValue = String.Empty;
        }

        public void ClearEntry()
        {
            _calculator.LastValue = String.Empty;
        }

        public void ClearEverything()
        {
            _calculator = null;
            GC.Collect();

            _calculator = new Calculator();
        }


        public void Subtract()
        {
            if (_calculator.Operation == _calculator.LastOperation && _calculator.LastOperation == "-")
            {
                _calculator.LastValue = String.IsNullOrEmpty(_calculator.LastValue) ? "0" : _calculator.LastValue;
                _calculator.Result = BinaryConversion(_calculator.Result, _calculator.LastValue, "-");
            }
            else if (enterIsPressedDown)
            {
                enterIsPressedDown = false;
            }
            else
            {
                Repeat();
            }
            _calculator.LastOperation = "-";
            _calculator.Operation = "-";
            _calculator.LastValue = String.Empty;
        }
        private string BinaryConversion(string value1, string value2, string operation)
        {
            if (operation == "+")
                return Convert.ToString(Convert.ToInt64(_calculator.Result, 2) + Convert.ToInt64(_calculator.LastValue, 2), 2);
            return Convert.ToString(Convert.ToInt64(_calculator.Result, 2) - Convert.ToInt64(_calculator.LastValue, 2), 2);

        }

        public void Repeat()
        {
            enterIsPressedDown = true;
            if (!string.IsNullOrEmpty(_calculator.Operation) && _calculator.Operation == _calculator.LastOperation && !string.IsNullOrEmpty(_calculator.LastValue))
            {
                _calculator.Result = _calculator.Operation == "+" ?
                _calculator.Result = BinaryConversion(_calculator.Result, _calculator.LastValue, "+") :
                _calculator.Result = BinaryConversion(_calculator.Result, _calculator.LastValue, "-");
            }
        }
    }
}
