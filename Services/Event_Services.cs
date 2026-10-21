using System;
using System.Linq;
using Event_Registration_Management_System.Models;
using System.Collections.Generic;
using System.Text;
using Event_Registration_Management_System.Exceptions;
using System.ComponentModel;

namespace Event_Registration_Management_System.Services
{
   public class EventService {
        private List<Event> events = new List<Event>();
        public void AddEvent(Event newEvent)
        {
            events.Any(x => x.EventId == newEvent.EventId);
            events.Add(newEvent);
        }
        public void DisplayEvents()
        {
            foreach(Event ev in events)
            {
                Console.WriteLine($"ID: {ev.EventId} ,Name: {ev.EventName} ,Category: {ev.EventCategory} ,Venue: {ev.EventVenue} ,Date: {ev.EventDate} ,Fee: {ev.EventFee} ,Capacity: {ev.EventCapacity} ,Status: { ev.EventStatus}");
            }
        }
        public Event? GetEventById(int eventId)
        {
            return events.FirstOrDefault(x => x.EventId == eventId);
        }
        public List<Event> SearchByName(string eventName)
        {
            return events.Where(x => x.EventName.Contains(eventName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public bool UpdateEventVenue(int eventId, string eventVenue)
        {
            Event? ev = GetEventById(eventId);

            if (ev == null)
            {
                return false;
            }

            ev.EventVenue = newVenue;
            return true;

        }

    }
}
 