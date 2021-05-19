using BertoniAppDavid.Services.Services;
using BertoniAppDavid.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniAppDavid.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IAlbumServices _albumsService;
        private readonly IPhotoService _photosService;

        public GalleryController(IAlbumServices albumsService, IPhotoService photosService, ICommentsService commentsService)
        {
            _albumsService = albumsService;
            _photosService = photosService;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _albumsService.GetAll();

            return View(albums);
        }

        public async Task<IActionResult> Photos(int Id)
        {
            var photos = await _photosService.GetPhotosByAlbumId(Id);

            return View(photos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
