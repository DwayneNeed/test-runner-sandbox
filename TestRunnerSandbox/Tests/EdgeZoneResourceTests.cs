using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public abstract class EdgeZoneResourceTests
    {
        private static TestRunner.TestRunner testRunner;

        static EdgeZoneResourceTests()
        {
            // Executes once for the test class. (Optional)
            testRunner = new TestRunner.TestRunner();
        }

        protected async Task RunTestSequence(IAsyncEnumerable<TestRunner.TestStepResult> sequence)
        {
            await testRunner.RunTestSequence(sequence);
        }
    }
}
