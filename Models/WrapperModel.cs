using Microsoft.EntityFrameworkCore;
using System; 
using System.Collections.Generic;

namespace ActivitiesEvent.Models
{
    public class WrapperViewModel
    {
        public Users NewUser {get; set;}

        public Users SecondUser {get; set;}

        public Associates NewAssociates {get; set;}

        public FormEvent NewEventForm {get; set;}

        public Login LoginUser {get; set;}

        public List<Users> ListUsers {get; set;}

        public List<Associates> ListAssociates {get; set;}

        public List<FormEvent> ListEvents {get; set;}
    }
}