using System.Linq;
using System.Collections.Generic;
using App.Models;
using App.Services.ApiRequest;
using App.Services.Factories;
using App.Services.ResponseProcessor;
using NUnit.Framework;
using App.Services.Factories.Interfaces;
using App.Services.ResponseProcessor.Interfaces;
using NSubstitute;
using Microsoft.Extensions.Configuration;

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
            IConfiguration configurationStub = Substitute.For<IConfiguration>();
            configurationStub["UrlCreator:ApiKey"] = "test";

            IUrlCreator urlCreator = new UrlCreator(configurationStub);
            IApiRequestService requestService = new ApiRequestService(urlCreator);

            return requestService.Call().Result;
        }
    }
}