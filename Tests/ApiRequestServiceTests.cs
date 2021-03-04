using System.Linq;
using App.Services.ApiRequest;
using NUnit.Framework;
using System.Threading.Tasks;
using NSubstitute;

namespace Tests
{
    public class ApiRequestServiceTets
    {
        [Test]
        public async Task Call_ReturnNotNull()
        {
            // Arrange
            IUrlCreator urlCreatorStub = Substitute.For<IUrlCreator>();
            string baseUri = "https://content.guardianapis.com/search?show-blocks=all&api-key=7a75b617-4388-40dc-80f3-b15f4e0e42f6";
            
            urlCreatorStub.GetBaseUri().Returns(baseUri);
            
            IApiRequestService reqService = new ApiRequestService(urlCreatorStub);

            // Act
            var result = await reqService.Call();

            // Assert
            Assert.NotNull(result.ToArray()[0].Blocks.Main.Id);
        }
    }
}