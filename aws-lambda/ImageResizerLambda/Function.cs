using System;
using Amazon.Lambda.Core;

namespace ImageResizerLambda
{
    public class Function
    {
        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public string MyHandler(int count, ILambdaContext context) {
            var logger = context.Logger;
            logger.LogLine("received count: " + count);
            return count.ToString();    
        }
    }
}