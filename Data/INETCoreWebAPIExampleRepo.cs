using System.Collections.Generic;
using NETCoreWebAPIExample.Models;

namespace NETCoreWebAPIExample.Data {
    public interface INETCoreWebAPIExampleRepo {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}