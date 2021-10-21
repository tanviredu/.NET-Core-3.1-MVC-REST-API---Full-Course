using System;
using System.Collections.Generic;
using Commender.Models;
namespace Commender.Data
{
    public class MocCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command>{
                    new Command{Id=0,HowTo="Boil an Egg",Line="Boil water",Platform="kettle and Pan"},
                    new Command{Id=1,HowTo="Make sandwitch",Line="make sandwitch",Platform="egg and Pan"},
                    new Command{Id=2,HowTo="make Eggos",Line="make eggos",Platform="just egg"},
                    new Command{Id=3,HowTo="making pizzas",Line="make pizzas",Platform="bread and butter"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id=0,HowTo="Boil an Egg",
                Line="Boil water",
                Platform="kettle and Pan"};
        }
    }
}