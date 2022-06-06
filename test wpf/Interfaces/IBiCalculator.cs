using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_wpf.Interfaces
{
    public  interface IBiCalculator
    {
        /// <summary>
        /// This method receives a string value and add it to previous result
        /// </summary>
        /// <param name="value">the value that will be added to the previous result</param>
        /// <returns></returns>
        public void Add();
        /// <summary>
        /// This method receives a string value and subtract it from previous result 
        /// </summary>
        /// <param name="value">the value that will be subtracted to the previous result</param>
        /// <returns></returns>
        public void Subtract();
        /// <summary>
        /// This method removes the last entry
        /// </summary>
        public void ClearEntry();
        /// <summary>
        /// This method clear all values and entries 
        /// </summary>
        public void ClearEverything();
        /// <summary>
        /// This method is responsible to interact with UI
        /// </summary>
        /// <param name="value">this value should be 0,1 and the operations</param>
        public string Input(string value);
        /// <summary>
        /// This method repeat the previous operation (it's = button)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Repeat();

    }
}
