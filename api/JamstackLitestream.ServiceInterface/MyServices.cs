using System;
using ServiceStack;
using JamstackLitestream.ServiceModel;

namespace JamstackLitestream.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
