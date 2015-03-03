using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.ViewModels;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            var viewModel = new StoreIndexViewModel{
                NumberOfGenres = genres.Count(),
                Genres = genres
            };
            return this.View(viewModel);
        }
    }
}
