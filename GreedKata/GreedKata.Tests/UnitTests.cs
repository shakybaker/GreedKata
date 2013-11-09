using GreedKata.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedKata.Tests
{
    [TestFixture]
    public class UnitTests
    {
        //see http://nimblepros.com/media/36619/greed%20kata.pdf for game rules

        [Test]
        public void Player_rolls_a_single_1()
        {
            IGame game = new Game();
            var dice = new int[] { 1, 2, 3, 4, 6 };
            var actual = game.Score(dice);

            Assert.AreEqual(100, actual);
        }

        [Test]
        public void Player_rolls_a_single_5()
        {
            IGame game = new Game();
            var dice = new int[] { 6, 2, 3, 4, 5 };
            var actual = game.Score(dice);

            Assert.AreEqual(50, actual);
        }

        [Test]
        public void Player_rolls_triple_1s()
        {
            IGame game = new Game();
            var dice = new int[] { 1, 1, 1, 4, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(1000, actual);
        }

        [Test]
        public void Player_rolls_triple_2s()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 2, 2, 4, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(200, actual);
        }

        [Test]
        public void Player_rolls_triple_3s()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 3, 3, 4, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(300, actual);
        }

        [Test]
        public void Player_rolls_triple_4s()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 4, 4, 4, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(400, actual);
        }

        [Test]
        public void Player_rolls_triple_5s()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 5, 5, 5, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(500, actual);
        }

        [Test]
        public void Player_rolls_triple_6s()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 6, 6, 6, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(600, actual);
        }

        [Test]
        public void Player_rolls_4_of_a_kind()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 6, 6, 6, 6, 3 };
            var actual = game.Score(dice);

            Assert.AreEqual(1200, actual);
        }

        [Test]
        public void Player_rolls_5_of_a_kind()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 6, 6, 6, 6, 6 };
            var actual = game.Score(dice);

            Assert.AreEqual(2400, actual);
        }

        [Test]
        public void Player_rolls_6_of_a_kind()
        {
            IGame game = new Game();
            var dice = new int[] { 6, 6, 6, 6, 6, 6 };
            var actual = game.Score(dice);

            Assert.AreEqual(4800, actual);
        }

        [Test]
        public void Player_rolls_3_pairs()
        {
            IGame game = new Game();
            var dice = new int[] { 2, 2, 3, 3, 4, 4 };
            var actual = game.Score(dice);

            Assert.AreEqual(800, actual);
        }

        [Test]
        public void Player_rolls_a_straight()
        {
            IGame game = new Game();
            var dice = new int[] { 1, 2, 3, 4, 5, 6 };
            var actual = game.Score(dice);

            Assert.AreEqual(1200, actual);
        }
    }
}
