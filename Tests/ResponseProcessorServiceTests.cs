using System.Linq;
using System.Collections.Generic;
using App.Models;
using App.Services.ApiRequest;
using App.Services.Factories;
using App.Services.ResponseProcessor;
using NUnit.Framework;
using App.Services.Factories;
using App.Services.Factories.Interfaces;
using App.Services.ResponseProcessor.Interfaces;

namespace Tests
{
    public class ResponseProcessorServiceTests
    {
        [Test]
        public void ProcessResponse_ResultsModel_ReturnsMultipleArticleVM()
        {
            // Arrange
            IArticleVMFactory articleVMFactory = new ArticleVMFactory();

            IResponseProcessorService responseProcessorService = new ResponseProcessorService(articleVMFactory);
            IEnumerable<ResultsModel> results = GetResultsModels();

            // Act
            var result = responseProcessorService.ProcessResponse(results);

            // Assert
            Assert.NotNull(result.Articles.ToArray()[0].MainBlock.Id);

        }

        private IEnumerable<ResultsModel> GetResultsModels()
        {
            IUrlCreator urlCreator = new UrlCreator(); 
            IApiRequestService requestService = new ApiRequestService(urlCreator);

            return requestService.Call().Result;
        }
    }
}