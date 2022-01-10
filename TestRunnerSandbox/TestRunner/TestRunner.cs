using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRunner
{
    public class TestRunner
    {
        public async Task RunTestSequence(IAsyncEnumerable<TestStepResult> sequence)
        {
            await foreach (var testStepResult in sequence)
            {
                if (testStepResult.Succeeded)
                {
                    Console.WriteLine($"Test step '{testStepResult.Name}' SUCCEEDED");
                }
                else
                {

                    if (!testStepResult.IsCritical)
                    {
                        Console.WriteLine($"Test step '{testStepResult.Name}' FAILED with message '{testStepResult.FailureMessage}' but is not critical so continuing sequence.");
                    }
                    else
                    {
                        Console.WriteLine($"Test step '{testStepResult.Name}' FAILED with message '{testStepResult.FailureMessage}' and is critical so stopping sequence.");
                        break;
                    }
                }
            }
        }
    }
}
