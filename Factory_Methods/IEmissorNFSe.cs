using DesignPatternsDiogoDias.Models;

namespace DesignPatternsDiogoDias.Factory_Methods
{
    public interface IEmissorNFSe
    {
        void Emitir(NFSe nfse);
        void Consultar(string chaveAcesso);
        void Cancelar(NFSe nfse);
    }
}
