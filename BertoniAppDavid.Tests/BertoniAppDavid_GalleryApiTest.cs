using BertoniAppDavid.DAL.DataSource;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BertoniAppDavid.Tests
{
    public class BertoniAppDavid_GalleryApiTest
    {

        public readonly IDataApi _dataApi;

        public BertoniAppDavid_GalleryApiTest()
        {
            _dataApi = new DataApi("http://jsonplaceholder.typicode.com/");
        }

        [Fact]
        public async void Get_Should_Retrieve_Galleries()
        {
            var response = await _dataApi.GetAllAlbums();
            Assert.True(response.Count > 0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async void Get_should_Retrieves_Photos(int id)
        {
            var response = await _dataApi.GetCommentsByPhotoId(id);
            Assert.True(response.Count > 0);
        }

    }
}
