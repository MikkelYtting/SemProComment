using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SemProComment;
using SemProComment.Manager;

namespace SemProCommentWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        // GET: CommentController
        private readonly CommentManager _CommentManager = new CommentManager();
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _CommentManager.getAll();
        }

        // GET: CommentController/Details/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _CommentManager.GetById(id);
        }

        [HttpPost]
        public Comment Post([FromBody] Comment value)
        {
            return _CommentManager.Add(value);
        }
        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public Comment Put(int id, [FromBody] Comment value)
        {
            return _CommentManager.Update(id, value);
        }
        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public Comment Delete(int id)
        {
            return _CommentManager.Delete(id);
        }

    }
}
