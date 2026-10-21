using Event_Registration_Management_System.Models;
using Event_Registration_Management_System.Services;
using System.ComponentModel;
EventService service = new EventService();
Event events = new Event(101,
    "Hackathon",
    "College",
    "Main Hall",
    new DateTime(2027, 3, 15),
    500m,
    200,
    EventStatus.Open);
service.AddEvent(events);
service.DisplayEvents();

