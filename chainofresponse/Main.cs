using System;
using System;
namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader = new TeamLeader();
            ProjectLeader projectLeader = new ProjectLeader();
            HR hr = new HR();
            teamLeader.setNextSupervisor(projectLeader);
            projectLeader.setNextSupervisor(hr);

            teamLeader.applyLeave("Anu", 9);
            Console.WriteLine();
            teamLeader.applyLeave("Priya", 18);
            Console.WriteLine();
            teamLeader.applyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.applyLeave("Abishek", 50);

            Console.Read();
        }
    }
}