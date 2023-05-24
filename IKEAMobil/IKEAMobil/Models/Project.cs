using System;
using System.Collections.Generic;
using System.Text;

namespace IKEAMobil.Models
{
    public class Project
    {
        public bool IsActive { get; set; }

        public List<Segment> segments { get; set; } = new List<Segment>();

        private Segment activeSegment;


        public double Duration 
        { 
            get
            {
                double totalTime = 0.0;
                foreach (Segment segment in segments) 
                {
                    totalTime += segment.Duration;
                }
                return totalTime;
            }
            
        }

        private DateTime startTime;
        private DateTime endTime;

        public void Start()
        {
            IsActive = true;
        }

        public void Start(DateTime startTime)
        {
            activeSegment = new Segment();
            activeSegment.Start(startTime);
        }

        public void End(DateTime endTime)
        {
            activeSegment.End(endTime);
            segments.Add(activeSegment);
        }
    }
}
