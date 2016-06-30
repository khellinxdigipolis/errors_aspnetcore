﻿using System;

namespace Digipolis.Toolbox.Errors.Internal
{
    public class DefaultErrorMessage : ErrorMessage
    {
        public DefaultErrorMessage(string message) : base(Defaults.ErrorMessage.Key, message)
        { }
    }
}