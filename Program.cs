namespace Add_Binary;
class Program
{

    static string AdicionarBinario(string stringx, string stringy)
    {
        //settando a string resultado
        string resultado = "";

        //settando o somador
        int somador = 0;

        //definindo os tamanhos
        int i = stringx.Length - 1;
        int j = stringy.Length - 1;

        while (i >= 0 || j >= 0 || somador == 1)
        {

            somador += ((i >= 0) ? stringx[i] - '0' : 0);
            somador += ((j >= 0) ? stringy[j] - '0' : 0);

            //adicionar 1 no final, quando existir 1 ou 3
            resultado = (char)(somador % 2 + '0') + resultado;

            //fazer um carry e mover para o próximo resultado
            somador /= 2;
            i--; j--;
        }

        return resultado;
    }

    static string DecimalParaBinario(int numero)
    {
        //definindo uma string binária
        string binario = "";

        //esse é um valor em 8 bits!
        for (int i = 8; i >= 0; i--)
        {
            int k = numero >> i;
            if ((k & 1) > 0)
                binario += "1";
            else
                binario += "0";
        }
        //retornar o valor
        return binario;
    }


    static void Main(string[] args)
    {
        //adicionar strings em binários
        Console.WriteLine("Coloque dois números decimais, X e Y: ");

        //descrevendo X
        Console.WriteLine("Descreva X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        //descrevendo Y
        Console.WriteLine("Descreva Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        //as string x e y receberão o valor das funções
        string stringx = DecimalParaBinario(x);
        string stringy = DecimalParaBinario(y);

        //colocando as respostas em binário
        Console.WriteLine(x + " em binário é: " + stringx);
        Console.WriteLine(y + " em binário é: " + stringy);

        //mostrar a soma em binário!
        Console.WriteLine("A soma entre esses dois números em binário é: ");
        Console.Write(AdicionarBinario(stringx,stringy));
    }
}
