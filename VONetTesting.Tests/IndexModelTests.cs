using VONetTesting.Pages;

namespace VONetTesting.Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void OnGet_PopulatesFeatures()
        {
            var model = new IndexModel();

            model.OnGet();

            Assert.Equal(new[] {"Fast", "Secure", "Easy to use"}, model.Features);
        }
    }
}
