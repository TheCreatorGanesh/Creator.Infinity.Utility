

namespace Creator.Infinity.Json.Test
{
    using Newtonsoft.Json;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SerializeDictionaryTest()
        {
            var dict = new Dictionary<string, TestObject> {
                { "FirstObject", new TestObject("I am the First Object") }
            };
            var jsonString1 = JsonConvert.SerializeObject(dict);
            var jsonString2 = dict.ToJson<string, TestObject>();
            if (jsonString1 == jsonString2)
            {
                Assert.Pass();
            }
            else
            {
                Console.WriteLine($"jsonString1:{jsonString1}");
                Console.WriteLine($"jsonString2:{jsonString2}");
                Assert.Fail();
            }
        }

        [Test]
        public void SerializeObjectTest()
        {
            var obj = new TestObject("I am the First Object");
            var jsonString1 = JsonConvert.SerializeObject(obj);
            var jsonString2 = obj.ToJson();
            if (jsonString1 == jsonString2)
            {
                Assert.Pass();
            }
            else
            {
                Console.WriteLine($"jsonString1:{jsonString1}");
                Console.WriteLine($"jsonString2:{jsonString2}");
                Assert.Fail();
            }
        }
    }
}