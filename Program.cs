namespace Sorting_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            int[] vetor = new int[tam];

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite um número aleatório para a posição {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            
            Sort.Selection(vetor);

            foreach(int n in vetor)
            {
                Console.Write(n + " ");
            }
        }
    }
}