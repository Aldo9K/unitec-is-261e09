using Xunit;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebUI.IntegrationTest
{
    public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;
        public IntegrationTestPages(WebApplicationFactory<Program>factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("Index")]
        [InlineData("Privacy")]
        [InlineData("Aplicaciones")]
        [InlineData("Programa")]
        [InlineData("Recursos")]
        [InlineData("Servicios")]
        public async Task TestGetPages(string url)
        {
            var response=await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}