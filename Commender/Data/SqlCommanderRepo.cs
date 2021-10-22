using System.Collections.Generic;
using System.Linq;

using Commender.Models;

namespace Commender.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        public CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
            
        }

        

        public IEnumerable<Command> GetAllCommand()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p=>p.Id == id);
        }
    }
}