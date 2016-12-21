using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MaslavyevAM
{
    public class TestBase
    {
        public Manager manager;

        [TestFixtureSetUp]
        public void RunApp() //Включение приложения
        {
            manager = new Manager();
        }

        [TestFixtureTearDown]
        public void StopApp() //Остановка приложения
        {
            manager.Stop();
        }
    }
}
