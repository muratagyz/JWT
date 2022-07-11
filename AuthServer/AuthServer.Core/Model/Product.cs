﻿using System;

namespace AuthServer.Core.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Decimal { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }
    }
}