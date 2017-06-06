﻿using System.Windows.Input;
using Hdd.Contract;

namespace Hdd.Presentation.Core
{
    public interface IModuleCommand : IModuleConnector
    {
        /// <summary>
        ///     Identifier of command (language neutral)
        /// </summary>
        string Id { get; }

        /// <summary>
        ///     Is true if the command can be run.
        /// </summary>
        bool Active { get; }

        /// <summary>
        ///     Command to execute.
        /// </summary>
        /// <returns>The command action.</returns>
        ICommand Command { get; }

        /// <summary>
        ///     Display name of the command.
        /// </summary>
        /// <returns>The command action.</returns>
        string Name { get; }
    }
}