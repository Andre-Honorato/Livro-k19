using System;

namespace Pag_37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando a varíavel do menu
            int op = 1;
            do {
                #region "Menu"
                //Limpando a tela
                Console.Clear();

                //Imprimindo as opções
                Console.WriteLine("[1] - Classe Aluno");
                Console.WriteLine("[2] - Classe Funcionario");
                Console.WriteLine("[3] - Classe Turma");
                Console.WriteLine("[4] - Sair");

                //Lendo a opção escolhida
                Console.Write("\nDigite uma opção: ");
                op = int.Parse(Console.ReadLine());
                #endregion
                //Analisando cada opção
                switch(op) {
                    case 1:
                        Console.Clear();
                        #region "Aluno"
                        //Criando dois objetos da classe Aluno
                        var Aluno1 = new Aluno();
                        var Aluno2 = new Aluno();
                        
                        //Atribuindo valores ao primeiro objeto
                        Aluno1.nome = "Ricardo";
                        Aluno1.rg = 123;
                        Aluno1.nascimento = "20/05/2010";

                        //Atribuindo valores ao segundo objeto
                        Aluno2.nome = "Marcos";
                        Aluno2.rg = 456;
                        Aluno2.nascimento = "20/01/2004";

                        //Imprimindo na tela as informações do primeiro objeto
                        Console.WriteLine("Aluno 1\n");
                        Console.WriteLine("Nome: " + Aluno1.nome);
                        Console.WriteLine("RG: " + Aluno1.rg);
                        Console.WriteLine("Data de nascimento: " + Aluno1.nascimento);

                        //Imprimindo na tela as informações do segundo objeto
                        Console.WriteLine("\nAluno 2\n");
                        Console.WriteLine("Nome: " + Aluno2.nome);
                        Console.WriteLine("RG: " + Aluno2.rg);
                        Console.WriteLine("Data de nascimento: " + Aluno2.nascimento);
                        
                        //Voltando ao menu
                        Console.Write("\nAperte ENTER para continuar");

                        //Lendo a tecla ENTER
                        Console.ReadLine();
                        #endregion
                    break;
                    case 2:
                        Console.Clear();
                        #region "Funcionario"
                        //Criando dois objetos da classe Funcionario
                        var Funcionario1 = new Funcionario();
                        var Funcionario2 = new Funcionario();

                        //Atribuindo valores ao primeiro objeto
                        Funcionario1.nome = "Roberto";
                        Funcionario1.cargo = "Supervisor";

                        //Atribuindo valores ao segundo objeto
                        Funcionario2.nome = "Carlos";
                        Funcionario2.cargo = "Gerente";

                        //Imprimindo na tela as informações do primeiro objeto
                        Console.WriteLine("Funcionario 1\n");
                        Console.WriteLine("Nome: " + Funcionario1.nome);
                        Console.WriteLine("Cargo: " + Funcionario1.cargo);

                        //Imprimindo na tela as informações do segundo objeto
                        Console.WriteLine("\nFuncionario 2\n");
                        Console.WriteLine("Nome: " + Funcionario2.nome);
                        Console.WriteLine("Cargo: " + Funcionario2.cargo);
                        
                        //Voltando ao menu
                        Console.Write("\nAperte ENTER para continuar");

                        //Lendo a tecla ENTER
                        Console.ReadLine();
                        #endregion
                    break;
                    case 3:
                        Console.Clear();
                        #region "Turma"
                        //Criando dois objetos da classe Turma
                        var Turma1 = new Turma();
                        var Turma2 = new Turma();

                        //Atribuindo valores ao primeiro objeto
                        Turma1.periodo = "Manhã";
                        Turma1.serie = 4;
                        Turma1.sigla = "4A";
                        Turma1.ensino = "Fundamental";

                        //Atribuindo valores ao segundo objeto
                        Turma2.periodo = "Tarde";
                        Turma2.serie = 1;
                        Turma2.sigla = "1B";
                        Turma2.ensino = "Médio";

                        //Imprimindo na tela as informações do primeiro objeto
                        Console.WriteLine("Turma 1\n");
                        Console.WriteLine("Período: " + Turma1.periodo);
                        Console.WriteLine("Série: " + Turma1.serie);
                        Console.WriteLine("Sigla: " + Turma1.sigla);
                        Console.WriteLine("Ensino: " + Turma1.ensino);

                        //Imprimindo na tela as informações do segundo objeto
                        Console.WriteLine("\nTurma 2\n");
                        Console.WriteLine("Período: " + Turma2.periodo);
                        Console.WriteLine("Série: " + Turma2.serie);
                        Console.WriteLine("Sigla: " + Turma2.sigla);
                        Console.WriteLine("Ensino: " + Turma2.ensino);
                        
                        //Voltando ao menu
                        Console.Write("\nAperte ENTER para continuar");

                        //Lendo a tecla ENTER
                        Console.ReadLine();
                        #endregion
                    break;
                    case 4:
                    break;
                    default:
                    #region "Opção inválida"
                    //Limpando a tela
                    Console.Clear();

                    //Mostrando a mensagem de erro
                    Console.WriteLine("Opção inválida!");

                    //Voltando ao menu
                    Console.Write("\nAperte ENTER para continuar");

                    //Lendo a tecla ENTER
                    Console.ReadLine();
                    #endregion
                    break;
                }
            }while(op!=4);
            #region "Fim do programa"
            //Limpando a tela
            Console.Clear();

            //Imprimindo na tela o fim do programa
            Console.WriteLine("Programa encerrado");
            #endregion
        }
    }
}