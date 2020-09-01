using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24HoursAssignment.WebAPI.Controllers
{
    [Authorize]
    public class PostController : ApiController
    {
        public IHttpActionResult Get()
        {
            PostService postService = CreatePostService();
            var notes = postService.GetPosts();
            return Ok(notes);
        }
        public IHttpActionResult Post(PostCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateNoteService();

            if (!service.CreateNote(note))
                return InternalServerError();

            return Ok();
        }
        private PostService CreatePostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new PostService(userId);
            return noteService;
        }
        public IHttpActionResult Get(int id)
        {
            PostService noteService = CreateService();
            var note = noteService.GetNoteById(id);
            return Ok(note);
        }


    }
}
