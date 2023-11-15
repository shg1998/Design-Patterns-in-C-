﻿using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Dtos
{
    internal class RequestDto
    {
        public string Password { get; set; } = "";
        public int Value { get; set; }
        public Customer? FromCustomer { get; set; }
        public Customer? ToCustomer { get; set; }
    }
}
