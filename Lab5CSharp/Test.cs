using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Test
{
    protected string subject;
    protected int maxScore;

    public Test(string subject, int maxScore)
    {
        this.subject = subject;
        this.maxScore = maxScore;

        Console.WriteLine("Test constructor called");
    }

    public abstract void ConductTest();
}

