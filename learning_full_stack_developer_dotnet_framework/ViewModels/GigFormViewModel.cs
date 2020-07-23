using System;
using System.Collections.Generic;
using learning_full_stack_developer_dotnet_framework.Models;

namespace learning_full_stack_developer_dotnet_framework.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime => DateTime.Parse($"{Date} {Time}");
    }
}