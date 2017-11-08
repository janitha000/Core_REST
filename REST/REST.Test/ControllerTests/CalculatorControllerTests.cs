using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using REST.Web;
using REST.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace REST.Test.ControllerTests
{
    [TestClass]
    public class CalculatorControllerTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public CalculatorControllerTests()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task IShould_Return_Add()
        {
            var response =await _client.GetAsync("api/Calculator/Add?val1=10&val2=20");
            response.EnsureSuccessStatusCode();

            var responseString = response.Content.ReadAsStringAsync();

            Assert.Equals(30, responseString);
        }

        [TestMethod]
        public async Task IShould_Return_Sub()
        {
            var response = await _client.GetAsync("api/Calculator/Add?val1=20&val2=10");
            response.EnsureSuccessStatusCode();

            var responseString = response.Content.ReadAsStringAsync();

            Assert.Equals(10, responseString);
        }

        [TestMethod]
        public async Task IShould_Return_Mul()
        {
            var response = await _client.GetAsync("api/Calculator/Add?val1=10&val2=20");
            response.EnsureSuccessStatusCode();

            var responseString = response.Content.ReadAsStringAsync();

            Assert.Equals(200, responseString);
        }

        [TestMethod]
        public async Task IShould_Return_Div()
        {
            var response = await _client.GetAsync("api/Calculator/Add?val1=20&val2=10");
            response.EnsureSuccessStatusCode();

            var responseString = response.Content.ReadAsStringAsync();

            Assert.Equals(2, responseString);
        }

    }
}
