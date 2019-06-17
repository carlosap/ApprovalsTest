using System.Linq;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using HangmanGame;
using NUnit.Framework;
using NUnit.Framework.Internal;
using StringUtils;

namespace Tests
{
    [TestFixture]
    public class ReverserTests
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void ReverseWordTraditional()
        {
            var names = new[] {"carlos", "perez"};
            var reverser = new WordReverser();
            var reverseNames = reverser.Reverse(names).ToArray();

            //Assert.AreEqual("solrac", reverseNames[0]);
            //Assert.AreEqual("zerep", reverseNames[1]);

            //you can also add headers like so
            //Approvals.VerifyAll("header", reverseNames, x => string.Format("{0}", x));

            Approvals.VerifyAll(reverseNames, "Name", x => x.PadLeft(10));

        }
    }
}
