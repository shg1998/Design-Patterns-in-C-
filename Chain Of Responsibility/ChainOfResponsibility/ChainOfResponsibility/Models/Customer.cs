﻿namespace ChainOfResponsibility.Models
{
    internal class Customer
    {
        public int AccountValue { get; set; }
        public bool IsActive { get; set; }
        public int MaxDateValue { get; set; }
        public string Password { get; set; } = "";
    }
}
