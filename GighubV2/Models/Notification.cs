using System;

namespace GighubV2.Models
{
    public class Notification
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public NotificationType Type { get; set; }

        public DateTime? OriginalDateTime { get; set; }

        public string OriginalValue { get; set; }

        public Gig Gig { get; set; }
    }
}