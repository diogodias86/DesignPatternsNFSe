using System;
using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Commands.Impl
{
    public class SairSistemaCommand : IMenuCommand
    {
        public void Execute(MenuContext context)
        {
            Environment.Exit(0);
        }
    }
}
