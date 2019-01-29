using System;
using System.Collections.Generic;

namespace DotnetcoreMediaPanion.ViewModels1
{
    public partial class Contect
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string JobTitle { get; set; }
        public string CompaneyName { get; set; }
        public int? Budget { get; set; }
        public string Message { get; set; }
        public bool? IsJoined { get; set; }
    }
}
