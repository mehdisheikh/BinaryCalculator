
using System;
using System.ComponentModel;

namespace test_wpf.Models
{
    internal class Calculator
    {
        private bool disposed;
        public string LastValue { get; set; }=string.Empty;
        public string Result{ get; set; }="0";
        public string Operation { get; set; } = string.Empty;
        public string LastOperation { get; set; } = string.Empty;
    }
}
