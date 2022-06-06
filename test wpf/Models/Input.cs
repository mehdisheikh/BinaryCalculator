using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_wpf.Models
{
    public class Inputs
    {
        public string Value { get; set; }
        public InputType Type{ get; set; }
    }
    public enum InputType
    {
        digit,
        operators,
        controller
    }
}
