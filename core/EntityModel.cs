﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionNetF.core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class EntityModel: Attribute
    {
    }
}
