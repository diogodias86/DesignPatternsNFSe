using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Commands
{
    public interface IMenuCommand
    {
        void Execute(MenuContext context);
    }
}
