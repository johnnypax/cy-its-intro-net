﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez10_injection_test.classes
{
    internal class Utente
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Ruolo { get; set; } = null!;

        public override string ToString()
        {
            return $"{Id} {Username} {Password} {Ruolo}";
        }
    }
}
