﻿namespace LetsPet854.Domain.Common
{
    public class PersonBase
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Contact PersonContact { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}