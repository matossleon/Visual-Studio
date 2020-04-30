﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities.Exceptions
{
    class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
