using System;
namespace ChainOfResponsibilityDesignPattern
{
	class ProjectLeader : Employee
	{
		private int MAX_LEAVES_CAN_APPROVE = 20;
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
            Console.WriteLine("ProjectLeader approved " + numberofDaysLeave + " days " + "Leave for the employee : "
                            + employeeName);

        }
    }
}
