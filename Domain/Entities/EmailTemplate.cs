﻿namespace Domain.Entities
{
    public class EmailTemplate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool Active { get; set; }
    }
}