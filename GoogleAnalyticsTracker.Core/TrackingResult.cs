﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace GoogleAnalyticsTracker.Core;

[PublicAPI]
public class TrackingResult
{
    public TrackingResult(
        string url,
        IDictionary<string, string> parameters,
        string query)
    {
        Url = url;
        Parameters = parameters;
        Query = query;
    }

    public string Url { get; set; }
    public IDictionary<string, string> Parameters { get; set; }
    public string Query { get; set; }
    public bool Success { get; set; }
    public Exception? Exception { get; set; }
}