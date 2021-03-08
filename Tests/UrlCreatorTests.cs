using App.Services.ApiRequest;
using Microsoft.Extensions.Configuration;
using NSubstitute;
using NUnit.Framework;

namespace Tests
{
    public class UrlCreatorTests
    {
        [Test]
        public void GetBaseUri_RetunsBaseUriString()
        {
            // Arrange
            IConfiguration configurationStub = Substitute.For<IConfiguration>();
            configurationStub["UrlCreator:ApiKey"] = "test";

            IUrlCreator urlCreator = new UrlCreator(configurationStub);
            string expected = "https://content.guardianapis.com/search?show-blocks=all&api-key=test";

            // Act
            string result = urlCreator.GetBaseUri();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}