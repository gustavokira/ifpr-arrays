using System;
class Principal {
  public static void Main (string[] args) {
    
    int[] alturas = new int[5];
    alturas[0] = 1;
    alturas[1] = 12;
    alturas[2] = 3;
    alturas[3] = 6;
    alturas[4] = 12;
    
    double somaDosDoisPrimeirosNumeros = alturas[0]+alturas[1];
    double somaDoPrimeiroUltimoNumeros = alturas[0]+alturas[4];
    
    double media = 0;
    double soma = 0;
    
    for(int i =0;i<alturas.Length;i++){
      Console.WriteLine("posicao "+i+" -> tem o valor: "+alturas[i]);
      soma = soma + alturas[i];
    }
    
    media = soma/alturas.Length;
    Console.WriteLine("soma de todos os valores "+soma);
    Console.WriteLine("media de todos os valores "+media);
    
    
  }
}