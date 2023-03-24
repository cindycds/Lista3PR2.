using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float exercicio, semana, valortotal, formpag, res, mes, ano, menu, n1, n2, subtraçao, adicao, multiplicacao, divisao, salario, diferenca;

            Console.WriteLine("========MENU=======");
            Console.WriteLine("exercico 1 digite- 1");
            Console.WriteLine("exercico 2 digite- 2");
            Console.WriteLine("exercico 3 digite- 3");
            Console.WriteLine("exercico 4 digite- 4");
            Console.WriteLine("exercico 5 digite- 5");
            Console.WriteLine("exercico 6 digite- 6");

            exercicio = float.Parse(Console.ReadLine());

            switch (exercicio)
            {
                case 1: //case referente ao exercicio 1
                    Console.WriteLine("EXERCICIO 1 sendo executado...");

                    Console.WriteLine("Digite um numero de 1 a 7 referente ao dia da semana:");
                    semana = float.Parse(Console.ReadLine());

                    switch (semana)
                    {
                        //exercicio 1 rodando aqui

                        case 1:
                            Console.WriteLine("numero referente a domingo");
                            break;
                        case 2:
                            Console.WriteLine("numero referente a segunda");
                            break;
                        case 3:
                            Console.WriteLine("numero referente a terça");
                            break;
                        case 4:
                            Console.WriteLine("numero referente a quarta");
                            break;
                        case 5:
                            Console.WriteLine("numero referente a quinta");
                            break;
                        case 6:
                            Console.WriteLine("numero referente a sexta");
                            break;
                        case 7:
                            Console.WriteLine("numero referente a sabado");
                            break;
                        default:
                            Console.WriteLine("opçao invalida");
                            break;


                    }
                    break;

                case 2: // exercicio 2
                    Console.WriteLine("EXERCICIO 2 sendo executado...");
                    Console.WriteLine("Difite o valor total da sua compra:");
                    valortotal = float.Parse(Console.ReadLine());

                    Console.WriteLine(" ====escolha o numero conforme a forma de pagamento======");
                    Console.WriteLine("1- dinheiro");
                    Console.WriteLine("2- pix");
                    Console.WriteLine("3- debito");
                    Console.WriteLine("4- credito");
                    formpag = float.Parse(Console.ReadLine());
                    switch (formpag)
                    {
                        //exercicio 2 rodando aqui

                        case 1:
                            res = valortotal - 0.15f;
                            Console.WriteLine("seu valor total fica: " + res);

                            break;
                        case 2:
                            res = valortotal - 0.1f;
                            Console.WriteLine("seu valor total fica:");
                            break;
                        case 3:
                            res = valortotal + 0.05f;
                            Console.WriteLine("seu valor total fica:");
                            break;
                        case 4:
                            res = valortotal + 0.1f;
                            Console.WriteLine("seu valor total fica:");
                            break;

                        default:
                            Console.WriteLine("opçao invalida");
                            break;


                    }
                    break;


                case 3: //exercicio 3
                    Console.WriteLine(" EXERCICIO 3 sendo executado...");
                    Console.WriteLine("Digite um numero de 1 a 12 referente ao dia da semana:");
                    mes = float.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        //exercicio 3 rodando aqui

                        case 1:
                            Console.WriteLine("numero referente a janeiro, possui 31 dias");
                            break;
                        case 2:
                            Console.WriteLine("numero referente a fevereiro, digite o ano para saber os dias desse mes:");
                            ano = float.Parse(Console.ReadLine());

                            res = ano % 4;

                            if (res == 0)
                                Console.WriteLine("esse ano é bissexto, o mes de fevereiro possui 29 dias");
                            else
                                Console.WriteLine("Esse ano nao é bissexto, o mes de fevereiro possui 28 dias");

                            break;
                        case 3:
                            Console.WriteLine("numero referente a março, possui 31 dias");
                            break;
                        case 4:
                            Console.WriteLine("numero referente a abril, possui 30 dias");
                            break;
                        case 5:
                            Console.WriteLine("numero referente a maio, possui 31 dias");
                            break;
                        case 6:
                            Console.WriteLine("numero referente a junho, possui 30 dias");
                            break;
                        case 7:
                            Console.WriteLine("numero referente a julho, possui 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("numero referente a agosto, possui 31 dias");
                            break;
                        case 9:
                            Console.WriteLine("numero referente a setembrom, possui 30 dias");
                            break;
                        case 10:
                            Console.WriteLine("numero referente a outubro, possui 31 dias ");
                            break;
                        case 11:
                            Console.WriteLine("numero referente a novembro, posui 30 dias");
                            break;
                        case 12:
                            Console.WriteLine("numero referente a dezembro, ppossui 31 dias");
                            break;
                        default:
                            Console.WriteLine("opçao invalida");
                            break;
                    }

                    break;

                case 4: // exercicio 4
                    Console.WriteLine("Executando exercicio 4....");
                    Console.WriteLine("====manu calculadora======");
                    Console.WriteLine("1- adição");
                    Console.WriteLine("2- Subtraçao");
                    Console.WriteLine("3- multiplicaçao");
                    Console.WriteLine("4- Divisão");
                    menu = float.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        //exercico 4 rodando aqui
                        case 1:
                            Console.WriteLine("Digite o primeiro valor: ");
                            n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite um segundo valor: ");
                            n2 = float.Parse(Console.ReadLine());

                            adicao = n1 + n2;

                            Console.WriteLine("valor total: " + adicao);
                            break;

                        case 2:
                            Console.WriteLine("Digite o primeiro valor: ");
                            n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite um segundo valor: ");
                            n2 = float.Parse(Console.ReadLine());

                            subtraçao = n1 - n2;

                            Console.WriteLine("valor total: " + subtraçao);

                            break;

                        case 3:
                            Console.WriteLine("Digite o primeiro valor: ");
                            n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite um segundo valor: ");
                            n2 = float.Parse(Console.ReadLine());

                            multiplicacao = n1 * n2;

                            Console.WriteLine("valor total: " + multiplicacao);

                            break;

                        case 4:
                            Console.WriteLine("Digite o primeiro valor: ");
                            n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Digite um segundo valor: ");
                            n2 = float.Parse(Console.ReadLine());

                            divisao = n1 / n2;

                            Console.WriteLine("valor total: " + divisao);

                            break;
                        default:
                            Console.WriteLine("opçao invalida");
                            break;
                    }


                    break;

                case 5:
                    Console.WriteLine("escolha o numero referente ao seu cargo:");
                    Console.WriteLine("1- professor");
                    Console.WriteLine("2- secretario");
                    Console.WriteLine("3- publicitario");
                    Console.WriteLine("4- jornalista");
                    Console.WriteLine("5- mecanico");
                    Console.WriteLine("6-estagiario");
                    Console.WriteLine("7- tecnico de TI");
                    menu = float.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.075f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 2:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.097f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 3:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.117f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 4:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.089f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 5:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.1324f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 6:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.104f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;
                        case 7:
                            Console.WriteLine("Digite o valor total do seu salario: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario + 0.146f;
                            diferenca = res - salario;

                            Console.WriteLine("seu salario era: " + salario + " com o acrescimo ele ficou: " + res + "a diferença entre eles é: " + diferenca);
                            break;

                        default:
                            Console.WriteLine("opção invalida");
                            break;


                    }


                    break;

                case 6:
                    Console.WriteLine("qual o valor da sua renda mensal:");
                    Console.WriteLine("1- ate  1.903,98");
                    Console.WriteLine("2- entre R$ 1.903,99 e R$ 2.826,65");
                    Console.WriteLine("3- entre  R$ 2.826,66 e R$ 3.751,05");
                    Console.WriteLine("4- entre R$ 3.751,06 e R$ 4.664,68");
                    Console.WriteLine("5- acima de R$ 4.664,68");

                    menu = float.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Voce esta insento de imposto de renda ");
                            
                            break;
                        case 2:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario - 0.075f;

                            Console.WriteLine("seu salrio liquido é de: " + res);
                            break;
                        case 3:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario - 0.15f;

                            Console.WriteLine("seu salrio liquido é de: " + res);
                            break;
                        case 4:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario - 0.225f;

                            Console.WriteLine("seu salrio liquido é de: " + res);
                            break;
                        case 5:
                            Console.WriteLine("Qual o valor exxato do seu salario?: ");
                            salario = float.Parse(Console.ReadLine());

                            res = salario - 0.275f;

                            Console.WriteLine("seu salrio liquido é de: " + res);
                            break;
                        
                        default:
                            Console.WriteLine("opção invalida");
                            break;


                    }

                    break;

























                default:
                    Console.WriteLine("Opçao invalida");
                    break;


            }
            Console.ReadKey();
        }
    }
}

