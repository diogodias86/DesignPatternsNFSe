using DesignPatternsDiogoDias.Factory_Methods;
using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Commands.Impl
{
    public class ConsultarNFSeCommand : IMenuCommand
    {
        public void Execute(MenuContext context)
        {
            var emissor = EmissorFactory.GetEmissor(context.UF);

            emissor.Consultar(context.ChaveAcesso);
        }
    }
}
