using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Registration_Management_System.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventCategory { get; set; }
        public string EventVenue { get; set; }
        public DateTime EventDate { get; set; }
        public decimal EventFee { get; set;}
        public int EventCapacity { get; set; }
        public EventStatus EventStatus { get; set; }

        public Event(int eventId,string eventName,string eventCategory,string eventVenue,DateTime eventDate,decimal eventFee,int eventCapacity,EventStatus eventStatus)
        {
            EventId = eventId;
            EventName = eventName;
            EventCategory = eventCategory;
            EventVenue = eventVenue;
            EventDate = eventDate;
            EventFee = eventFee;
            EventCapacity = eventCapacity;
            EventStatus = eventStatus;

        }
    }
}
