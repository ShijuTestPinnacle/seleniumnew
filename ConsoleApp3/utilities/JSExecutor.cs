using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.utilities
{
    class JSExecutor
    {
        public static object Script(IWebDriver driver, String Customcmd)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(Customcmd);
        }
    }
}
