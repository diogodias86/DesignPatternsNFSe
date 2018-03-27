using DesignPatternsDiogoDias.Factory_Methods.Impl;
using System;

namespace DesignPatternsDiogoDias.Factory_Methods
{
    public class EmissorFactory
    {
        public static IEmissorNFSe GetEmissor(string uf)
        {
            var _uf = uf.Trim().ToLower();

            switch (_uf)
            {
                case "rj": return new EmissorNFSeRJ();
                case "sp": return new EmissorNFSeSP();
                case "mg": return new EmissorNFSeMG();

                default: throw new ArgumentException("O emissor para o estado selecionado não está implementado.");
            }
        }
    }
}
