using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Trial : Test
{
    private string trialType;

    public Trial() : base("Unknown", 0)
    {
        this.trialType = "Unknown";

        Console.WriteLine("Trial default constructor called");
    }
    public Trial(string subject) : base(subject, 0)
    {
        this.trialType = "Unknown";

        Console.WriteLine("Trial constructor with subject called");
    }
    public Trial(string subject, int maxScore, string trialType)
        : base(subject, maxScore)
    {
        this.trialType = trialType;

        Console.WriteLine("Trial constructor with subject, maxScore, and trialType called");
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting trial for {subject} of type {trialType}");
    }
}

