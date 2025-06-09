using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class GraduationExam : Test
{
    private string graduationDate;

    public GraduationExam() : base("Unknown", 0)
    {
        this.graduationDate = "Unknown";

        Console.WriteLine("GraduationExam default constructor called");
    }
    public GraduationExam(string subject) : base(subject, 0)
    {
        this.graduationDate = "Unknown";

        Console.WriteLine("GraduationExam constructor with subject called");
    }
    public GraduationExam(string subject, int maxScore, string graduationDate)
        : base(subject, maxScore)
    {
        this.graduationDate = graduationDate;

        Console.WriteLine("GraduationExam constructor with subject, maxScore, and graduationDate called");
    }

    public override void ConductTest()
    {
        Console.WriteLine($"Conducting graduation exam for {subject} on {graduationDate}");
    }
}

