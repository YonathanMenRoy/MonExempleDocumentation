using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaExempleDocumentation
{
    /// <summary>
    /// This interface is an exemple for documentation.
    /// </summary>
    /// 
    public interface IExemple
    {
        /// <summary>
        /// This function is here only to show an example for documentation.
        /// </summary>
        /// <param name="param1"> First parameter (to add)</param>
        /// <param name="param2">Second parameter (to add)</param>
        /// <returns> An int , this function could add two integers. </returns>
        int ExampleFunction(int param1, int param2);
    }
}
