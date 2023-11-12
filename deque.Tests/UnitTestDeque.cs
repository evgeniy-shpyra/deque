namespace deque.Tests;
using CustomCollection;

public class Tests
{
    [TestFixture]
    public class TestDeque
    {
        [Test]
        public void TestAddFirst()
        {
            var deque = new CustomDeque<string>();

            deque.AddFirst("first");
            deque.AddFirst("second");

            Assert.AreEqual("second", deque.First());
            Assert.AreEqual(2, deque.Count);
        }

        [Test]
        public void TestAddLast()
        {
            var deque = new CustomDeque<string>();

            deque.AddLast("first");
            deque.AddLast("second");

            Assert.AreEqual("second", deque.Last());
            Assert.AreEqual(2, deque.Count);
        }

        [Test]
        public void TestRemoveFirst()
        {
            var deque = new CustomDeque<string>();

            deque.AddLast("first");
            deque.AddLast("second");

            deque.RemoveFirst();

            Assert.AreEqual("second", deque.First());
            Assert.AreEqual(1, deque.Count);
        }

        [Test]
        public void TestRemoveLast()
        {
            var deque = new CustomDeque<string>();

            deque.AddLast("first");
            deque.AddLast("second");

            deque.RemoveLast();

            Assert.AreEqual("first", deque.Last());
            Assert.AreEqual(1, deque.Count);
        }

        [Test]
        public void TestClear()
        {
            var deque = new CustomDeque<string>();

            deque.AddLast("first");
            deque.AddLast("second");

            deque.Clear();

            Assert.AreEqual(0, deque.Count);
            Assert.IsTrue(deque.IsEmpty);
        }

        [Test]
        public void TestContains()
        {
            var deque = new CustomDeque<string>();

            deque.AddLast("first");
            deque.AddLast("second");

            Assert.IsTrue(deque.Contains("first"));
            Assert.IsFalse(deque.Contains("third"));
        }

    }

}
