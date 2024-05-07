﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary5
{
    // Клас, який інкапсулює виконання команди
    public class CommandInvoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command?.Execute();
        }
    }
}
