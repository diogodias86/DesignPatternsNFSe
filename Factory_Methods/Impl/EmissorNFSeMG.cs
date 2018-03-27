using System;
using DesignPatternsDiogoDias.Models;
using DesignPatternsDiogoDias.Proxy;
using DesignPatternsDiogoDias.Proxy.Impl;

namespace DesignPatternsDiogoDias.Factory_Methods.Impl
{
    public class EmissorNFSeMG : IEmissorNFSe
    {
        IHttpClient _httpClient = new HttpClientProxy();

        public void Cancelar(NFSe nfse)
        {
            Console.WriteLine($"Cancelando NFSe nº {nfse.Numero} na UF {nfse.UF}");

            _httpClient.Exec(new Request());

            Console.WriteLine("NFSe cancelada com sucesso.");
        }

        public void Consultar(string chaveAcesso)
        {
            Console.WriteLine($"Consultando NFSe com a chave de acesso {chaveAcesso}");

            _httpClient.Exec(new Request());

            Console.WriteLine("Consulta realizada com sucesso.");
        }

        public void Emitir(NFSe nfse)
        {
            Console.WriteLine($"Emitindo NFSe para o cliente {nfse.NomeCliente} com o valor {nfse.Valor} na UF {nfse.UF}");

            _httpClient.Exec(new Request());

            Console.WriteLine("NFSe emitida com sucesso.");
        }
    }
}