using DesignPatternsDiogoDias.Factory_Methods;
using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Commands.Impl
{
    public class CancelarNFSeCommand : IMenuCommand
    {
        public void Execute(MenuContext context)
        {
            var emissor = EmissorFactory.GetEmissor(context.UF);

            emissor.Cancelar(new NFSe
            {
                Numero = context.NumeroNF
            });
        }
    }
}
