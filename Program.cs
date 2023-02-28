/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/

Console.WriteLine("Digite a hora inicial do jogo: ");
int inicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a hora final do jogo: ");
int final = int.Parse(Console.ReadLine());
int duracao;

if (inicial < final)
{
    duracao = final - inicial;
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
else
{
    duracao = 24 - inicial + final;
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}
