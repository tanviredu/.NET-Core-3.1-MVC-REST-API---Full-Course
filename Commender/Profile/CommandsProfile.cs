using AutoMapper;
using Commender.Models;
using Commender.Dtos;

namespace Commender.Profiles{

    public class CommandsProfile : Profile{
        public CommandsProfile()
        {
            // source -> target
            CreateMap<Command,CommandReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<CommandUpdateDto,Command>();


        }
    }
}