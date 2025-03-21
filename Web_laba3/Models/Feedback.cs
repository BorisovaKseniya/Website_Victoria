﻿using System.ComponentModel.DataAnnotations;

namespace Web_laba3.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Theme { get; set; }
        public string Message { get; set; }
    }
}
