using System;
using Commender.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Commender.Data
{
    public class CommanderContext : DbContext
    {
        // remember this
        public CommanderContext(DbContextOptions<CommanderContext> opt):base(opt)
        {

        }

        public DbSet<Command> Commands {get;set;}


    }
}