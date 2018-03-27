using DesignPatternsDiogoDias.Commands;
using DesignPatternsDiogoDias.Commands.Impl;
using DesignPatternsDiogoDias.Models;
using System;

namespace DesignPatternsDiogoDias
{
    enum MenuOption
    {
        OPT_EMITIR = 1,
        OPT_CONSULTAR,
        OPT_CANCELAR,
        OPT_EXIT,
        OPT_INVALIDA
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Emissor de NFSe com Design Patterns.    ");
            Console.WriteLine("========================================");

            while (true)
            {
                try
                {
                    InitMenu();

                    var opt = ReadInput();

                    Console.WriteLine("Opção selecionada: " + opt.ToString());

                    IMenuCommand cmd;

                    switch (opt)
                    {
                        case MenuOption.OPT_EMITIR:
                            var contextEmitir = ReadInputForEmitir();

                            cmd = new EmitirNFSeCommand();
                            cmd.Execute(contextEmitir);

                            break;
                        case MenuOption.OPT_CONSULTAR:
                            var contextConsultar = ReadInputForConsultar();

                            cmd = new ConsultarNFSeCommand();
                            cmd.Execute(contextConsultar);

                            break;
                        case MenuOption.OPT_CANCELAR:
                            var contextCancelar = ReadInputForCancelar();

                            cmd = new CancelarNFSeCommand();
                            cmd.Execute(contextCancelar);

                            break;
                        case MenuOption.OPT_EXIT:
                            cmd = new SairSistemaCommand();
                            cmd.Execute(null);

                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("========================================");
                            Console.WriteLine("Opção inválida.");
                            Console.WriteLine("========================================");

                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Erro: " + ex.Message);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private static MenuContext ReadInputForCancelar()
        {
            Console.Write("Informe a UF: ");
            var uf = Console.ReadLine();

            Console.Write("Informe o Número da NFSe: ");
            var numero = Console.ReadLine();

            var context = new MenuContext
            {
                UF = uf,
                NumeroNF = numero
            };

            return context;
        }

        private static MenuContext ReadInputForConsultar()
        {
            Console.Write("Informe a UF: ");
            var uf = Console.ReadLine();

            Console.Write("Informe a chave de acesso: ");
            var chave = Console.ReadLine();

            var context = new MenuContext
            {
                UF = uf,
                ChaveAcesso = chave
            };

            return context;
        }

        private static MenuContext ReadInputForEmitir()
        {
            Console.Write("Informe a UF: ");
            var uf = Console.ReadLine();

            Console.Write("Informe o nome do cliente: ");
            var cliente = Console.ReadLine();

            Console.Write("Informe o valor do serviço: ");
            var valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o serviço: ");
            var servico = Console.ReadLine();

            var context = new MenuContext
            {
                UF = uf,
                NomeCliente = cliente,
                Valor = valor,
                DescricaoServico = servico
            };

            return context;
        }

        private static MenuOption ReadInput()
        {
            MenuOption opt = MenuOption.OPT_INVALIDA;

            Console.Write("Informe uma opção: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                try
                {
                    opt = (MenuOption)result;
                }
                catch (Exception)
                {
                    opt = MenuOption.OPT_INVALIDA;
                }
            }

            return opt;
        }

        private static void InitMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Menu Principal:    ");
            Console.WriteLine("========================================");

            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");
            Console.WriteLine("1 - Emitir uma NFSe. ");
            Console.WriteLine("2 - Consultar uma NFSe. ");
            Console.WriteLine("3 - Cancelar uma NFSe. ");
            Console.WriteLine("4 - Sair do sistema. ");
            Console.WriteLine("");
        }
    }
}
