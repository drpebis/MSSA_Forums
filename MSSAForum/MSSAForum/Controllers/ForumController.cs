using Microsoft.AspNetCore.Mvc;
using MSSAForum.Data;
using MSSAForum.Data.Models;
using MSSAForum.Models.Forum;
using System.Collections.Generic;
using System.Linq;

namespace MSSAForum.Controllers
{
    public class ForumController : Controller
    {

        private readonly IForum _forumService;

        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index() 
        {
            var forums = _forumService.GetAll()
                .Select(Forum => new ForumListingModel
                {
                    Id = Forum.Id,
                    Name = Forum.Title,
                    Description = Forum.Description
                });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }
    }
}
