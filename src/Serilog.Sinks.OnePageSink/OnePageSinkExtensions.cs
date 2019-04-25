﻿using System;
using Microsoft.AspNetCore.SignalR;
using Serilog.Configuration;

namespace Serilog.Sinks.OnePageSink
{
    public static class OnePageSinkExtensions
    {
        public static LoggerConfiguration OnePageSink(this LoggerSinkConfiguration loggerSinkConfiguration, IHubContext<EventHub> eventHub, IFormatProvider formatProvider = null)
        {
            return loggerSinkConfiguration.Sink(new OnePageSink(formatProvider, eventHub));
        }
    }
}
