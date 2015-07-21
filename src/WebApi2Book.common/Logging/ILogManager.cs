﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace WebApi2Book.common.Logging
{
    public interface ILogManager
    {
        ILog GetLog(Type typeAssociatedWithReuqestedLog);
    }
}