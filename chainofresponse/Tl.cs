using System;
namespace ChainOfResponsibilityDesignPattern
{
    public class TeamLeader : Employee
    {
        private int MAX_LEAVES_CAN_APPROVE = 10;
        public override void applyLeave(string employeeName, int numberofDaysLeave)
        {
            if (numberofDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                ApproveLeave(employeeName, numberofDaysLeave);
            }
            else
            {
                supervisor.applyLeave(employeeName, numberofDaysLeave);
            }
        }
        private void ApproveLeave(string employeeName, int numberofDaysLeave)
        {
            Console.WriteLine("TeamLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);

        }
    }
}