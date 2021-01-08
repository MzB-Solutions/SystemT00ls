using SManager.Core.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SManager.Core.CommandFactory
{
    public class Factory
    {
        public ICommand GetCommand(CommandSource source)
        {
            return source switch
            {
                CommandSource.logger => new LoggerCommand(),
                CommandSource.modules => null,
                _ => null,
            };
        }
    }
}