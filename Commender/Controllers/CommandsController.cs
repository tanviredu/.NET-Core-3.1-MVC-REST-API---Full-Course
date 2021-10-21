using System;
using Commender.Models;
using Commender.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Commender.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController:ControllerBase
    {
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
            
        }
        //private readonly MocCommanderRepo _repository = new MocCommanderRepo();


        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repository.GetAllCommand();
            return Ok(commandItems);

        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandbyId(int id){

            var commanditem = _repository.GetCommandById(id);
            return Ok(commanditem);
        }
        
    }
}