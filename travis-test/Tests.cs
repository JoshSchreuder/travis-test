using System.Collections.Generic;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;
namespace travis_test
{
    [UseReporter(typeof(DiffReporter))]
    public class Tests
    {
        [Fact]
        public void TestNormal()
        {
            Assert.Equal(4, 2 * 2);
        }

        [Fact]
        public void TestApprovals()
        {
            Approvals.VerifyAll(new Dictionary<int, int>
            {
                { 2, 1 * 2 },
                { 4, 2 * 2 },
                { 6, 3 * 2 },
                { 8, 4 * 2 }
            });
        }
    }
}
