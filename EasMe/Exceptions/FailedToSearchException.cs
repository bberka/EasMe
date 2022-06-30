﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasMe.Exceptions
{
    public class FailedToSearchException : Exception
    {
        public FailedToSearchException(string message, Exception? Inner = null) : base(message, Inner)
        {

        }
        public FailedToSearchException(string message) : base(message)
        {

        }
    }
}
