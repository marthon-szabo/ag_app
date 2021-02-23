using System;
using App.Services.RequestServices;
using NUnit.Framework;

namespace Tests
{
    public class UrlCreatorTests
    {
       [Test]
       public void CreateURL_String_ReturnsApiQueryString()
       {
            // Arrange
            IUrlCreator creator = new UrlCreator();
            string parameters = "q=debate&tag=politics";
           
           // Act
           string result =  creator.CreateURL(parameters);

           // Assert
           Assert.AreEqual(
               "https://content.guardianapis.com/search?q=debate&tag=politics&api-key=7a75b617-4388-40dc-80f3-b15f4e0e42f6",
               result
               );
       }
    }
}