using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDesignPatternDemo
{
    /// <summary>
    /// Has all the information about the request and based on that executes required action.
    /// </summary>
    public class ActivityCommand : ICommand
    {
        private readonly Activity _activity;
        private readonly AvailabilityAction _availabilityAction;
        private readonly int _amount;
        public ActivityCommand(Activity activity, AvailabilityAction availabilityAction, int amount)
        {
            _activity = activity;
            _availabilityAction = availabilityAction;
            _amount = amount;
        }
        public void ExecuteAction()
        {
            if (_availabilityAction == AvailabilityAction.Increase)
            {
                _activity.IncreaseAvailability(_amount);
            }
            else
            {
                _activity.DecreaseAvailability(_amount);
            }
        }
    }
}
