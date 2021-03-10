using App.Services.ApiRequest;
using NUnit.Framework;

namespace Tests
{
    public class UrlCreatorTests
    {
        [Test]
        public void GetBaseUri_RetunsBaseUriString()
        {
            // Arrange
            IUrlCreator urlCreator = new UrlCreator();
            string expected = "https://content.guardianapis.com/search?show-blocks=all&api-key=7a75b617-4388-40dc-80f3-b15f4e0e42f6&show-fields=thumbnail";

            // Act
            string result = urlCreator.GetBaseUri();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}