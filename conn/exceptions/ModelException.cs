﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionNetF.conn.exceptions
{
    public class ModelException : Exception
    {
        public ModelException(string message) : base("Model Error: " + message) { }
    }
}
