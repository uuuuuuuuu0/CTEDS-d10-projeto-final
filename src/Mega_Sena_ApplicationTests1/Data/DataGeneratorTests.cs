using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mega_sena_front.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mega_sena_front.Models;

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
                MegaSena[] senas = DataGenerator.MegaSenas(15);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void LotoFacilsTest()
        {
            try
            {
                LotoFacil[] lfs = DataGenerator.LotoFacils(15);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void DuplaSenasTest()
        {
            try
            {
                DuplaSena[] duplas = DataGenerator.DuplaSenas(15);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void QuinasTest()
        {
            try
            {
                Quina[] quinas = DataGenerator.Quinas(15);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod()]
        public void LotomaniasTest()
        {
            try
            {
                Lotomania[] lm = DataGenerator.Lotomanias(15);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}