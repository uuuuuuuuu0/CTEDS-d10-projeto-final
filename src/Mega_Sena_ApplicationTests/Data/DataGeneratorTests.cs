using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mega_sena_front.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front.Data.Tests
{
    [TestClass()]
    public class DataGeneratorTests
    {
        [TestMethod()]
        public void MegaSenasTest()
        {
            try
            {
                MegaSena[] megas = DataGenerator.MegaSenas(6);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}