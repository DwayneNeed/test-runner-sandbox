using System;

namespace TestRunner
{
    public class TestStepResult
    {
        public string Name { get; init; }

        public bool IsCritical { get; init; }

        public TimeSpan Duration { get; init; }

        public string FailureMessage { get; init; }

        public bool Failed => this.FailureMessage != null;
        public bool Succeeded => this.FailureMessage == null;

        public TestStepResult(string name, bool isCritical, string failureMessage)
        {
            this.Name = name;
            this.IsCritical = isCritical;
            this.FailureMessage = failureMessage;
        }
    }
}
