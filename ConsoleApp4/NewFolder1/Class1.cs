using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4.NewFolder1.Test1
{
    [TestFixture]
    [Parallelizable]
    class Class1
    {
        [Test]
        public void Test()
        {
            Thread.Sleep(8000);

        }
    }
}
