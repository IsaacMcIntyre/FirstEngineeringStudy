using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace FirstEngineeringStudy.IntegrationTest
{
    [TestFixture]
    public class EmployeeResource
    {
        private WebApplicationFactory<Startup> _factory;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _factory = new WebApplicationFactory<Startup>();
        }

        [Test]
        public async Task Get_EndpointReturn200AndCorrectContentType()
        {
            //Arrange
            const string url = "/api/employee";
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync(url);

            //Assert
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Test]
        public async Task Delete_EndpointReturn204()
        {
            //Arrange
            const string url = "/api/employee";
            var client = _factory.CreateClient();

            //Act
            var response = await client.DeleteAsync(url);

            //Assert
            Assert.AreEqual(204, (int)response.StatusCode);
        }

        [Test]
        public async Task Get_SuppliedWithIdEndpointReturn200AndCorrectContentType()
        {
            //Arrange
            const string url = "/api/employee/1";
            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync(url);

            //Assert
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Test]
        public async Task Put_EndpointReturn204()
        {
            //Arrange
            const string url = "/api/employee";
            var client = _factory.CreateClient();

            //Act
            var response = await client.PutAsync(url, null);

            //Assert
            Assert.AreEqual(204, (int) response.StatusCode);
        }

        [Test]
        public async Task Post_EndpointReturn204()
        {
            //Arrange
            const string url = "/api/employee";
            var client = _factory.CreateClient();

            //Act
            var response = await client.PostAsync(url, null);

            //Assert
            Assert.AreEqual(201, (int)response.StatusCode);

            IEnumerable<string> values;
            response.Headers.TryGetValues("Location", out values);
            Assert.IsNotNull(values);
        }
    }
}