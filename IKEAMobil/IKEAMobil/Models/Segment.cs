using System;
using System.Collections.Generic;
using System.Text;

namespace IKEAMobil.Models
{
    public class Segment
    {
        public double Duration
        {
            get
            {
                return (endTime - startTime).TotalSeconds;
            }
        }

        private DateTime startTime;
        private DateTime endTime;

        public void Start(DateTime startTime)
        {
            this.startTime = startTime;
        }

        public void End(DateTime endTime)
        {
            this.endTime = endTime;
        }
    }
}
