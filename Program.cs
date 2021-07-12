using System;

namespace CommandDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Modify();
            var activity = new Activity("12345", 50);

            Execute(invoker, new ActivityCommand(activity, AvailabilityAction.Increase, 10));
            Execute(invoker, new ActivityCommand(activity, AvailabilityAction.Decrease, 5));
            Execute(invoker, new ActivityCommand(activity, AvailabilityAction.Increase, 20));
            Execute(invoker, new ActivityCommand(activity, AvailabilityAction.Decrease, 1));

            Console.WriteLine(activity);
        }

        private static void Execute(Modify modifyAvailability, ICommand activityCommand)
        {
            modifyAvailability.SetCommand(activityCommand);
            modifyAvailability.Invoke();
        }
    }
}
