using System.Linq;
using System.Collections.Generic;
using App.Models;
using App.Models.ViewModels;
using App.Services.ResponseProcessor.Interfaces;
using App.Services.Factories.Interfaces;

namespace App.Services.ResponseProcessor
{
    public class ResponseProcessorService : IResponseProcessorService
    {

        private readonly IArticleVMFactory _ArticleVMFactory;

        public ResponseProcessorService(IArticleVMFactory articleVMFactory)
        {
            _ArticleVMFactory = articleVMFactory;
        }

        public MultipleArticleVM ProcessResponse(IEnumerable<ResultsModel> resultsModels)
        {
            IList<ArticleVM> articleVMs = new List<ArticleVM>();

            
            foreach (ResultsModel resultModel in resultsModels)
            {
                if (resultModel.Blocks.Main.Id != null)
                {
                    ArticleVM actualArticleVM = _ArticleVMFactory.Create(resultModel.Blocks, resultModel.WebTitle, 
                    resultModel.Fields.Thumbnail, resultModel.Fields.TrailText);

                    articleVMs.Add(actualArticleVM);
                }

            }

            MultipleArticleVM mAVM = new MultipleArticleVM
            {
                Articles = articleVMs
            };

            return mAVM;

        }
    }
}