using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleDriverLoading
{
    class Program
    {
        static void Main(string[] args)
        {

            WebDriver webdiver = new ChromeDriver();
            webdiver.Url = "http://google.com";
            webdiver.Navigate();
        }
    }
}
