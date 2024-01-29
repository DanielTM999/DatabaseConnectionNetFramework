﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionNetF.conn.exceptions
{
    public class QueryException : Exception
    {
        public QueryException(string message) : base("Query Exception: " + message) { }
    }
}
