

//Tabuada:

int resultado, numero;


Console.WriteLine("Informe o número inteiro > \t");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <=10; i++){
    
    resultado = numero * i ;
    Console.WriteLine(numero + "x" + i + "=" + resultado);
}

Console.WriteLine("\n Fim do processamento......");
Console.ReadKey();


