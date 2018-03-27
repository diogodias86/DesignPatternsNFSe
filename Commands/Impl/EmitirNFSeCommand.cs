using DesignPatternsDiogoDias.Factory_Methods;
using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Commands.Impl
{
    public class EmitirNFSeCommand : IMenuCommand
    {
        public void Execute(MenuContext context)
        {
            var emissor = EmissorFactory.GetEmissor(context.UF);

            emissor.Emitir(new NFSe
            {
                UF = context.UF,
                NomeCliente = context.NomeCliente,
                DescricaoServico = context.DescricaoServico,
                Valor = context.Valor
            });
        }
    }
}
