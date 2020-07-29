using System.Collections.Generic;
using NETCoreWebAPIExample.Models;

namespace NETCoreWebAPIExample.Data {
    public class MockNETCoreWebAPIExampleRepo : INETCoreWebAPIExampleRepo
    {
        private readonly INETCoreWebAPIExampleRepo _repository;

        public MockNETCoreWebAPIExampleRepo()
        {
        }

        MockNETCoreWebAPIExampleRepo(INETCoreWebAPIExampleRepo repository) {
            _repository = repository;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command{Id=0, HowTo="Example data here 1", Line="More example data 1", Platform="More more data... 1"},
                new Command{Id=0, HowTo="Example data here 2", Line="More example data 2", Platform="More more data... 2"},
                new Command{Id=0, HowTo="Example data here 3", Line="More example data 3", Platform="More more data... 3"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Example data here", Line="More example data", Platform="More more data..."};
        }
    }
}