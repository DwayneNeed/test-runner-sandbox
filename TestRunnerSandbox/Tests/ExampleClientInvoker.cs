using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRunner;

namespace Tests
{
    public class ExampleClientInvoker
    {
        public async Task<TestStepResult> Invoke(string stepName, bool isCritical, Func<Task> lambda)
        {
            string failureMessage = null;

            try
            {
                await lambda();
            }
            catch (InvalidOperationException ex)
            {
                failureMessage = ex.Message;
            }

            return new TestStepResult(stepName, isCritical, failureMessage);
        }

        public TestStepResult Invoke(string stepName, bool isCritical, Action lambda)
        {
            string failureMessage = null;

            try
            {
                lambda();
            }
            catch (InvalidOperationException ex)
            {
                failureMessage = ex.Message;
            }

            return new TestStepResult(stepName, isCritical, failureMessage);
        }
    }
}
