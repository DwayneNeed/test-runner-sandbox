using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestRunner;

namespace Tests
{
    [TestClass]
    public class UnitTest1 : EdgeZoneResourceTests
    {
        [TestMethod]
        public async Task ExampleTest()
        {
            await RunTestSequence(ExampleSequences.ExampleSequence());
        }
    }
}
