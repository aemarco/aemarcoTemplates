using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassTemplates
{
    /// <summary>
    /// Purpose:
    /// Created by: $username$
    /// Created at: $time$
    /// </summary>
    public class SimpleClass
    {
        #region ctor

        private readonly ILogger<SimpleClass> _log;
        public SimpleClass(ILogger<SimpleClass> log)
        {
            _log = log;
        }

        #endregion

    }
}
