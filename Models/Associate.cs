using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ActivitiesEvent.Models
{
    public class Associates
    {
        [Key]
        public int AssociatesId {get; set;}

        public int UserId {get; set;}

        public Users User {get; set;}

        public int EventFormId {get; set;}

        public FormEvent EventForms {get; set;}
    }
}