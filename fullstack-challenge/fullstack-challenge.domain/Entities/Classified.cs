﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fullstack_challenge.domain.Entities
{
    public class Classified
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

    }
}
