using System;

namespace ServodataTask.Repositories.ActualTime
{
    public class SampleTime : IActualTime
    {
        public DateTime GetActualTime()
        {
            return DateTime.Now;
        }
    }
}