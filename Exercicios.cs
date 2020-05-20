using System;

class Aluno {
    public string nome;
    public int rg;
    public string nascimento;
}

class Funcionario {
    public string nome;
    public string cargo;
}

class Turma {
    public string periodo;
    public int serie;
    public string sigla;
    public string ensino;
}

/* Devido aos números de classes de teste todas elas estão comentadas, para vê-la funcionando basta apenas descomentar,
mas lembre-se, apenas uma classe de teste pode estar descomentada por vez */

class TestaAluno {
    /*
    static void Main(string[] args) {
        //Limpando a tela
        Console.Clear();
        //Criando dois objetos da classe Aluno
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        //Atribuindo valores ao primeiro objeto
        aluno1.nome = "João";
        aluno1.rg = 123;
        aluno1.nascimento = "20/01/2004";
        //Atribuindo valores ao segundo objeto
        aluno2.nome = "Maria";
        aluno2.rg = 456;
        aluno2.nascimento = "15/05/2004";
        //Imprimindo na tela as informações do primeiro objeto
        Console.WriteLine("Aluno 1\n");
        Console.WriteLine("Nome: " + aluno1.nome);
        Console.WriteLine("RG: " + aluno1.rg);
        Console.WriteLine("Data de nascimento: " + aluno1.nascimento);
        //Imprimindo na tela as informações do segundo objeto
        Console.WriteLine("\nAluno 2\n");
        Console.WriteLine("Nome: " + aluno2.nome);
        Console.WriteLine("RG: " + aluno2.rg);
        Console.WriteLine("Data de nascimento: " + aluno2.nascimento);
    }
    */
}

class TestaFuncionario {
    /*
    static void Main(string[] args) {
        //Limpando a tela
        Console.Clear();
        //Criando dois objetos da classe Funcionario
        Funcionario funcionario1 = new Funcionario();
        Funcionario funcionario2 = new Funcionario();
        //Atribuindo valores ao primeiro objeto
        funcionario1.nome = "Ricardo";
        funcionario1.cargo = "Gerente";
        //Atribuindo valores ao segundo objeto
        funcionario2.nome = "Carlos";
        funcionario2.cargo = "Supervisor";
        //Imprimindo na tela as informações do primeiro objeto
        Console.WriteLine("Funcionario 1\n");
        Console.WriteLine("Nome: " + funcionario1.nome);
        Console.WriteLine("Cargo: " + funcionario1.cargo);
        //Imprimindo na tela as informações do segundo objeto
        Console.WriteLine("\nFuncionario 2\n");
        Console.WriteLine("Nome: " + funcionario2.nome);
        Console.WriteLine("Cargo: " + funcionario2.cargo);
    }
    */
}

class TestaTurma {
    /*
    static void Main(string[] args) {
        //Limpando a tela
        Console.Clear();
        //Criando dois objetos da classe Turma
        Turma turma1 = new Turma();
        Turma turma2 = new Turma();
        //Atribuindo valores ao primeiro objeto
        turma1.periodo = "Manhã";
        turma1.serie = 2;
        turma1.sigla = "2A";
        turma1.ensino = "Médio";
        //Atribuindo valores ao segundo objeto
        turma2.periodo = "Tarde";
        turma2.serie = 8;
        turma2.sigla = "8B";
        turma2.ensino = "Fundamental 2";
        //Imprimindo na tela as informações do primeiro objeto
        Console.WriteLine("Turma 1\n");
        Console.WriteLine("Período: " + turma1.periodo);
        Console.WriteLine("Série: " + turma1.serie);
        Console.WriteLine("Sigla: " + turma1.sigla);
        Console.WriteLine("Ensino: " + turma1.ensino);
        //Imprimindo na tela as informações do segundo objeto
        Console.WriteLine("\nTurma 2\n");
        Console.WriteLine("Período: " + turma2.periodo);
        Console.WriteLine("Série: " + turma2.serie);
        Console.WriteLine("Sigla: " + turma2.sigla);
        Console.WriteLine("Ensino: " + turma2.ensino);
    }
    */
}