using static System.Console;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        List<string> nomes = new List<string>();
        List<double> notas1 = new List<double>();
        List<double> notas2 = new List<double>();
        List<double> notas3 = new List<double>();
        List<double> notas4 = new List<double>();
        List<double> mediaAluno = new List<double>();
        List<string> situacoes = new List<string>();

        bool continuar = true;

        while (continuar)
        {
            WriteLine("----- ESCOLA MUNICIPAL PROFESSOR EMERSON DE CAMARGO -----");
            WriteLine("--------------        MENU INICIAL        ---------------");
            WriteLine("---------------------------------------------------------");
            WriteLine("1. Cadastrar Alunos");
            WriteLine("2. Listar Alunos");
            WriteLine("3. Média das Notas da Turma");
            WriteLine("4. Alunos Aprovados");
            WriteLine("5. Alunos em Recuperacao");
            WriteLine("6. Alunos Reprovados");
            WriteLine("7. Editar Aluno");
            WriteLine("8. Excluir Aluno");
            WriteLine("9. Salvar Informacoes:");
            WriteLine("0. Sair:");
            WriteLine("---------------------------------------------------------");

            int opcao = int.Parse(ReadLine());

            switch (opcao)
            {
                case 1:
                    for (int i = 1; i <= 12; i++)
                    {
                        Clear();
                        WriteLine();
                        WriteLine("Digite o nome do Aluno " + i + ":");
                        string nome = ReadLine();
                        nomes.Add(nome);

                        WriteLine();
                        WriteLine("Digite a 1º nota do Aluno " + i + ":");
                        double nota1 = double.Parse(ReadLine());
                        notas1.Add(nota1);

                        WriteLine();
                        WriteLine("Digite a 2º nota do Aluno " + i + ":");
                        double nota2 = double.Parse(ReadLine());
                        notas2.Add(nota2);

                        WriteLine();
                        WriteLine("Digite a 3º nota do Aluno " + i + ":");
                        double nota3 = double.Parse(ReadLine());
                        notas3.Add(nota3);

                        WriteLine();
                        WriteLine("Digite a 4º nota do Aluno " + i + ":");
                        double nota4 = double.Parse(ReadLine());
                        notas4.Add(nota4);
                        WriteLine();

                        double media = (nota1 + nota2 + nota3 + nota4) / 4;

                        mediaAluno.Add(media);

                        string situacao;
                        if (media >= 7.0)
                        {
                            situacao = "APROVADO";
                        }
                        else if (media > 5.0)
                        {
                            situacao = "RECUPERAÇÃO";
                        }
                        else
                        {
                            situacao = "REPROVADO";
                        }

                        situacoes.Add(situacao);

                        WriteLine();
                    }
                    break;

                case 2:
                    Clear();
                    WriteLine(">>>> ALUNOS CADASTRADOS <<<<");
                    WriteLine();

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        WriteLine("Aluno: " + nomes[i]);
                        WriteLine();
                        WriteLine("Nota 1: " + notas1[i]);
                        WriteLine();
                        WriteLine("Nota 2: " + notas2[i]);
                        WriteLine();
                        WriteLine("Nota 3: " + notas3[i]);
                        WriteLine();
                        WriteLine("Nota 4: " + notas4[i]);
                        WriteLine();
                        WriteLine("Média: " + mediaAluno[i]);
                        WriteLine();
                        WriteLine("Situação: " + situacoes[i]);
                        WriteLine();
                    }
                    break;

                case 3:
                    double mediaNotas1 = 0;
                    double mediaNotas2 = 0;
                    double mediaNotas3 = 0;
                    double mediaNotas4 = 0;
                    double mediaTurmaGeral = 0;

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        mediaNotas1 = mediaNotas1 + notas1[i] / notas1.Count;
                        mediaNotas2 = mediaNotas2 + notas2[i] / notas2.Count;
                        mediaNotas3 = mediaNotas3 + notas3[i] / notas3.Count;
                        mediaNotas4 = mediaNotas4 + notas4[i] / notas4.Count;
                        mediaTurmaGeral = (mediaNotas1 + mediaNotas2 + mediaNotas3 + mediaNotas4) / 4;
                    }
                    Clear();
                    WriteLine("Média das notas 1 da turma: " + mediaNotas1);
                    WriteLine();
                    WriteLine("Média das notas 2 da turma: " + mediaNotas2);
                    WriteLine();
                    WriteLine("Média das notas 3 da turma: " + mediaNotas3);
                    WriteLine();
                    WriteLine("Média das notas 4 da turma: " + mediaNotas4);
                    WriteLine();
                    WriteLine("Média geral da turma: " + mediaTurmaGeral);
                    WriteLine();
                    break;

                case 4:
                    Clear();
                    WriteLine(">>>> ALUNOS APROVADOS <<<<");
                    WriteLine();
                    int totalAprovados = 0;

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        if (situacoes[i] == "APROVADO")
                        {
                            WriteLine("Aluno: " + nomes[i]);
                            WriteLine("Média: " + mediaAluno[i]);
                            WriteLine("Situação: " + situacoes[i]);
                            WriteLine();
                            totalAprovados++;
                        }
                    }
                    WriteLine("Total de alunos aprovados: " + totalAprovados);
                    WriteLine();
                    break;


                case 5:
                    Clear();
                    WriteLine(">>>> ALUNOS EM RECUPERAÇÃO <<<<");
                    WriteLine();
                    int totalRecuperacao = 0;

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        if (situacoes[i] == "RECUPERAÇÃO")
                        {
                            WriteLine("Aluno: " + nomes[i]);
                            WriteLine("Media: " + mediaAluno[i]);
                            WriteLine("Situacao: " + situacoes[i]);
                            WriteLine();
                            totalRecuperacao++;
                        }
                    }

                    WriteLine("Total de alunos em Recuperação: " + totalRecuperacao);
                    WriteLine();
                    break;


                case 6:
                    Clear();
                    WriteLine(">>>> ALUNOS REPROVADOS <<<<");
                    WriteLine();
                    int totalReprovados = 0;

                    for (int i = 0; i < nomes.Count; i++)
                    {
                        if (situacoes[i] == "REPROVADO")
                        {
                            WriteLine("Aluno: " + nomes[i]);
                            WriteLine("Média: " + mediaAluno[i]);
                            WriteLine("Situação: " + situacoes[i]);
                            WriteLine();
                            totalReprovados++;
                        }
                    }

                    WriteLine("Total de alunos Reprovados: " + totalReprovados);
                    WriteLine();
                    break;


                case 7:
                    Clear();
                    WriteLine(">>>> EDITAR ALUNO <<<<");
                    WriteLine();
                    WriteLine("Digite o nome do aluno que deseja editar:");
                    string nomeAluno = ReadLine();

                    int indiceAluno = nomes.IndexOf(nomeAluno);

                    if (indiceAluno != -1)
                    {
                        WriteLine("Digite o novo nome do aluno:");
                        WriteLine();
                        string novoNomeAluno = ReadLine();
                        nomes[indiceAluno] = novoNomeAluno;

                        WriteLine("Digite a nova 1ª nota do Aluno:");
                        WriteLine();
                        double novaNota1 = double.Parse(ReadLine());
                        notas1[indiceAluno] = novaNota1;

                        WriteLine("Digite a nova 2ª nota do Aluno:");
                        WriteLine();
                        double novaNota2 = double.Parse(ReadLine());
                        notas2[indiceAluno] = novaNota2;

                        WriteLine("Digite a nova 3ª nota do Aluno:");
                        WriteLine();
                        double novaNota3 = double.Parse(ReadLine());
                        notas3[indiceAluno] = novaNota3;

                        WriteLine("Digite a nova 4ª nota do Aluno:");
                        WriteLine();
                        double novaNota4 = double.Parse(ReadLine());
                        notas4[indiceAluno] = novaNota4;

                        double novaMedia = (novaNota1 + novaNota2 + novaNota3 + novaNota4) / 4;
                        mediaAluno[indiceAluno] = novaMedia;

                        string novaSituacao;
                        if (novaMedia >= 7.0)
                        {
                            novaSituacao = "APROVADO";
                        }
                        else if (novaMedia >= 4.0)
                        {
                            novaSituacao = "RECUPERAÇÃO";
                        }
                        else
                        {
                            novaSituacao = "REPROVADO";
                        }

                        situacoes[indiceAluno] = novaSituacao;

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine(">>>> DADOS DO ALUNO EDITADO COM SUCESSO <<<<");
                        ResetColor();
                        WriteLine();
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Aluno não encontrado!! Por favor, digite um nome que esteja na base de dados!!");
                        ResetColor();
                        WriteLine();
                    }
                    break;


                case 8:
                    Clear();
                    WriteLine(">>>> EXCLUIR ALUNO <<<<");
                    WriteLine();
                    WriteLine("Digite o nome do aluno que deseja excluir:");
                    WriteLine();
                    string nomeAlunoExcluir = ReadLine();

                    int indiceAlunoExcluir = nomes.IndexOf(nomeAlunoExcluir);

                    if (indiceAlunoExcluir != -1)
                    {
                        nomes.RemoveAt(indiceAlunoExcluir);
                        notas1.RemoveAt(indiceAlunoExcluir);
                        notas2.RemoveAt(indiceAlunoExcluir);
                        notas3.RemoveAt(indiceAlunoExcluir);
                        notas4.RemoveAt(indiceAlunoExcluir);
                        mediaAluno.RemoveAt(indiceAlunoExcluir);
                        situacoes.RemoveAt(indiceAlunoExcluir);

                        ForegroundColor = ConsoleColor.Green;
                        WriteLine(">>>> DADOS EXCLUIDOS COM SUCESSO <<<<");
                        ResetColor();
                        WriteLine();
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Aluno não encontrado!! Por favor, digite um nome que esteja na base de dados!!");
                        ResetColor();
                        WriteLine();
                    }
                    break;

                case 9:
                    Clear();
                    WriteLine("Salvar Informações:");
                    string caminhoArquivo = (@"C:\Users\ana14086\source\repos\DesafioTiozao\AlunosNotas.txt");

                    using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                    {
                        for (int i = 0; i < nomes.Count; i++)
                        {
                            writer.WriteLine("Aluno: " + nomes[i]);
                            writer.WriteLine("Nota 1: " + notas1[i]);
                            writer.WriteLine("Nota 2: " + notas2[i]);
                            writer.WriteLine("Nota 3: " + notas3[i]);
                            writer.WriteLine("Nota 4: " + notas4[i]);
                            writer.WriteLine("Média: " + mediaAluno[i]);
                            writer.WriteLine("Situação: " + situacoes[i]);
                            writer.WriteLine();
                        }
                    }
                    WriteLine();
                    WriteLine("Informações salvas com sucesso!");
                    WriteLine();
                    break;


                case 0:
                    continuar = false;
                    break;


                default:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Opção inválida. Digite novamente!");
                    ResetColor();
                    break;
            }
        }
        Clear();
        WriteLine(">>>> PROGRAMA ENCERRADO <<<<");
        ReadLine();
    }
}
