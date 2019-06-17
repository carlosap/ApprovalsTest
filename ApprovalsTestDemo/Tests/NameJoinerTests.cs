using ApprovalTests;
using ApprovalTests.Reporters;
using NameJoiner;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class NameJoinerTests
    {


        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void ShouldJoinNames()
        {
            var joiner = new Joiner();
            var results = joiner.Join("carlos", "perez");
            Approvals.Verify(results);
            
        }
    }
}