using System;
using Xunit;
using GothicMathLib;

namespace GothicMathTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var test = GothicMath.getAngle(Matrix4.Zero);
        }
    }
}