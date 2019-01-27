using System;

namespace GighubV2.Models
{
    public class Notification
    {
        public int Id { get; private set; }

        public DateTime DateTime { get; private set; }

        public NotificationType Type { get; private set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalValue { get; set; }

        public Gig Gig { get; private set; }

        protected Notification()
        {
        }

        public Notification(Gig gig, NotificationType type)
        {
            if (gig == null)
                throw new ArgumentNullException();

            DateTime = DateTime.Now;
            Gig = gig;
            Type = type;
        }
    }
}