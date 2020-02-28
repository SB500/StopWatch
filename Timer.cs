using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Timer
    {
        private DateTime _startTimer;
        private DateTime _stopTimer;
        private TimeSpan _duration;

        public DateTime Start()
        {
            _startTimer = DateTime.Now;
            Console.WriteLine(_startTimer);
            return _startTimer;
        }

        public TimeSpan Stop()
        {
            _stopTimer = DateTime.Now;
            Console.WriteLine(_stopTimer);
            _duration = _stopTimer - _startTimer;
            Console.WriteLine(_duration.TotalSeconds);
            return _duration;
        }
    }
}

