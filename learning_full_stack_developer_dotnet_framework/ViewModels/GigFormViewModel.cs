using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using learning_full_stack_developer_dotnet_framework.Models;

namespace learning_full_stack_developer_dotnet_framework.ViewModels
{
    public class GigFormViewModel
    {
        [Required] public string Venue { get; set; }

        [Required] [FutureDate] public string Date { get; set; }

        [Required] [ValidTime] public string Time { get; set; }

        [Required] public int Genre { get; set; }

        [Required] public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
            
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}