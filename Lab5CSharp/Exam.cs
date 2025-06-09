using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Exam : Test
{
    private string examDate;

    public Exam() : base("Unknown", 0)
    {
        this.examDate = "Unknown";
        
        Console.WriteLine("Exam default constructor called");
    }
    public Exam(string subject) : base(subject, 0)
    {
        this.examDate = "Unknown";

        Console.WriteLine("Exam constructor with subject called");
    }
    public Exam(string subject, int maxScore, string examDate)
        : base(subject, maxScore)
    {
        this.examDate = examDate;

        Console.WriteLine("Exam constructor with subject, maxScore, and examDate called");
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting exam for {subject} on {examDate}");
    }
}

