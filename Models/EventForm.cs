using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ActivitiesEvent.Models
{
    public class FormEvent
    {
        [Key]
        public int EventFormId {get; set;}

        [Required]
        public string Title {get; set;}

        [Required]
        // [Range(typeof(DateTime), "11/01/2020", "05/10/2020")]
        public DateTime Date {get; set;}

        // [Required]
        // public DateTime TimeDate {get; set;}

        [Required]
        public int EventDuration {get; set;}

        [Required]
        public string Duration {get; set;}

        [Required]
        public string Description {get; set;}
        
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public int UserId {get; set;}

        public Users ThePlanner {get; set;}

        public List<Associates> Attending {get; set;}
    }
}