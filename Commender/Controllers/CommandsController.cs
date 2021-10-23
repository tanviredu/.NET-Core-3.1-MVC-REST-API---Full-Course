using System;
using Commender.Models;
using Commender.Data;
using Commender.Dtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace Commender.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController:ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;
        public CommandsController(ICommanderRepo repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        //private readonly MocCommanderRepo _repository = new MocCommanderRepo();


        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands(){
            var commandItems = _repository.GetAllCommand();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));

        }

        [HttpGet("{id}",Name="GetCommandbyId")]
        public ActionResult<CommandReadDto> GetCommandbyId(int id){

            var commanditem = _repository.GetCommandById(id);
            if(commanditem !=null){
                return Ok(_mapper.Map<CommandReadDto>(commanditem));

            }else{
                return NotFound();
        }

    }

    [HttpPost]
    public ActionResult<CommandReadDto> CreateCommand (CommandCreateDto commandCreateDto){

            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();
            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            //return Ok(commandReadDto);
            return CreatedAtRoute(nameof(GetCommandbyId),new{Id=commandReadDto.Id},commandReadDto);

    }

    [HttpPut("{id}")]
    public ActionResult UpdateCommand(int id,CommandUpdateDto commandUpdateDto){
        var commandModelFromRepo = _repository.GetCommandById(id);
        if(commandModelFromRepo == null){
            return NotFound();
        }

        _mapper.Map(commandUpdateDto,commandModelFromRepo);
        _repository.UpdateCommand(commandModelFromRepo); // not necessary
        _repository.SaveChanges();
        return NoContent();


    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCommand(int id){
        var commandModelFromRepo = _repository.GetCommandById(id);
        if(commandModelFromRepo == null){
            return NotFound();
        }
        _repository.DeleteCommand(commandModelFromRepo);
        _repository.SaveChanges();
        return NoContent();
    }
          


        
    }
}