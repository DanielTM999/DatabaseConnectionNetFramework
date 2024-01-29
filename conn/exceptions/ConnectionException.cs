﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionNetF.conn.exceptions
{
    public class ConnectionException : Exception
    {
        public ConnectionException(string message) : base("Connection Error: " + message) { }
    }
}
