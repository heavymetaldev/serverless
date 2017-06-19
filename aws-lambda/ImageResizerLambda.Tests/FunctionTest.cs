using System;
using Xunit;
using Amazon.Lambda.TestUtilities;

namespace ImageResizerLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void Test1()
        {
            var ctx = new TestLambdaContext();
            var fun = new Function();

            var c = 0;

            var resp = fun.MyHandler(c, ctx);

            Assert.Equal(c.ToString(), resp);
        }
    }
}
