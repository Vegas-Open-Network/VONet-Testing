using VONetTesting.Pages;

namespace VONetTesting.Tests
{
    public class TestModelTests
    {
        [Fact]
        public void OnGet_PopulatesRandomData()
        {
            var model = new TestModel();

            model.OnGet();

            Assert.InRange(model.RandomNumber, 1, 999);
            Assert.Equal(8, model.RandomString.Length);
            Assert.NotEqual(default, model.CurrentTime);
            Assert.Equal(5, model.RandomFacts.Count);
            Assert.Contains("Honey never spoils.", model.RandomFacts);
        }
    }
}
