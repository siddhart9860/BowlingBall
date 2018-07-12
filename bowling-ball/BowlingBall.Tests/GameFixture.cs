using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void AllStrike()
        {
            var game = new Game();
            Roll(game, 10, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        [TestMethod]
        public void AllSpare()
        {
            var game = new Game();
            Roll(game, 5, 21);
            Assert.AreEqual(150, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        [TestMethod]
        public void ProblemStatementTestcase()
        {
            var game = new Game();
            int[] pinInputs = { 10, 9, 1, 5, 5, 7, 2, 10, 10, 10, 9, 0, 8, 2, 9, 1, 10 };

            for (int i = 0; i < pinInputs.Length; i++)
            {
                game.Roll(pinInputs[i]);
            }

            Assert.AreEqual(187, game.GetScore());
        }
    }
}
