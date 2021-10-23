using System;
using System.Collections.Generic;
using Commender.Models;


namespace Commender.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommand();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        bool SaveChanges();
        void DeleteCommand(Command cmd);
    }
}