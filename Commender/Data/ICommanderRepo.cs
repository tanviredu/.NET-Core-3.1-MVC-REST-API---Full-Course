using System;
using System.Collections.Generic;
using Commender.Models;


namespace Commender.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommand();
        Command GetCommandById(int id);
    }
}