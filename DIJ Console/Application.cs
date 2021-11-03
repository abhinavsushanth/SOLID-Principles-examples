using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIJLibrary;

namespace DIJ_Console
{
    public class Application : IApplication
    {
        IBusinessLogic _businesslogic;
        public Application(IBusinessLogic businessLogic)
        {
            _businesslogic = businessLogic;
        }

        public void Run()
        {
            _businesslogic.ProcessData();
        }
    }
}
