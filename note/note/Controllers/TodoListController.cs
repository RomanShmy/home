using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using note.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace note.Controllers
{
    [Route("api/[controller]")]
    public class TodoListController : Controller
    {
        private List<Note> notes = new List<Note>
            { new Note
              {
                Id = 1,
                Text = "Buy milk"
              },
              new Note
              {
                Id = 2,
                Text = "Buy book"
              }
            };

        // GET: api/values
        [HttpGet]
        public List<Note> Get()
        {
            return notes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Note Get(int id)
        {
            return Get()[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]int id, string text)
        {
            Note note = new Note();
            note.Id = id;
            note.Text = text;
            notes.Add(note);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            notes.Remove(notes[id]);
        }
    }
}
