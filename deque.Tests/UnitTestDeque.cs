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
    }
   
}
