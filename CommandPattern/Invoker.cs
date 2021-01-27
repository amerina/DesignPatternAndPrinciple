using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Invoker
    {
        private ICommand Command;

        public void SetCommand(ICommand command)
        {
            this.Command = command;
        }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
