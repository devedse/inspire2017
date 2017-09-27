using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace StarWarsApi.ErrorHandler
{
    public class AiExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            if (context != null && context.Exception != null)
            {
                var ai = new TelemetryClient();
                ai.InstrumentationKey = TelemetryConfiguration.Active.InstrumentationKey;
                ai.TrackException(context.Exception);
            }
            base.Log(context);
        }
    }
}