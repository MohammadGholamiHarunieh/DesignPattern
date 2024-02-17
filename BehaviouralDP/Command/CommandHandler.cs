using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP.Command
{
    public class CommandHandler
    {
        public readonly ICommand _command;
        public CommandHandler(ICommand command)
        {
            _command = command;
        }
        public void Handle()
        {
            _command.Execute();
        }
    }
}
