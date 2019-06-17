using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using HangmanGame;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests
{
    [TestFixture]
    public class HangmanGame
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void GameState()
        {
            var sb = new StringBuilder();

            var game = new GameEngine("Microsoft");
            game.Guess('i');
            game.Guess('y');
            game.Guess('t');

            //1st check the state before the first letter s
            sb.AppendLine(game.ToString());

            game.Guess('s');

            //2nd check for the state after the letter s
            sb.AppendLine(game.ToString());

            Approvals.Verify(sb.ToString());
        }
    }
}
