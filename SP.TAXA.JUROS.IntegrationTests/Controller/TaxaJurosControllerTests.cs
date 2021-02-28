using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SP.TAXA.JUROS.IntegrationTests.Controller
{
    public class TaxaJurosControllerTests
    {
        private readonly HttpClient _httpClient;

        public TaxaJurosControllerTests()
        {
            _httpClient = new WebApplicationFactory<Startup>().CreateClient();
        }

        [Fact]
        public async Task DadaRequiscaoGetDeveRetornarUmPorcento()
        {
            var endpoint = "TaxaJuros";

            var response = await _httpClient.GetAsync(endpoint);
            var result = Convert.ToDecimal(await response.Content.ReadAsStringAsync());

            response.StatusCode.Should().Be(200);
            result.Should().Be(0.01m);
        }
    }
}
