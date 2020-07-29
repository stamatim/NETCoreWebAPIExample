using Microsoft.AspNetCore.Mvc;
using NETCoreWebAPIExample.Data;
using NETCoreWebAPIExample.Models;
using System.Collections.Generic;

namespace NETCoreWebAPIExample.Controllers {
    
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase {

        private readonly MockNETCoreWebAPIExampleRepo _repository = new MockNETCoreWebAPIExampleRepo();

        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands() {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        // GET api/commands/{id}
        [Route("{id}")]
        [HttpGet]
        public ActionResult <Command> GetCommandById(int id) {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}