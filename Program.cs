Console.Write("Números pares entre 0 e ? ");
int fim = Convert.ToInt32(Console.ReadLine());

int contador = 0;

while(contador <= fim)
{
    Console.Write($"{contador} ");
    contador = contador + 2;
}