using System;

class Program {
  public static void Main (string[] args) {
    // for (int cont=0;cont<=10;cont++) é uma forma de declarar o cont porem ele só pode ser usado na estrutura em que foi declarado, se precisar apresentar o cont fora da estrutura ele nao conta como declarado; a menos que seja declarado dentro da estrutura e na proxima tambem.
   //int cont
    //for (cont=0;cont<=10;cont++)//cont=cont+1
   /* {
      Console.WriteLine(" {0}º Valor", cont);
      //em c# podemos mudar o valor de cont, mas em outras linguagens pode nao ter como, assim como a linguagem c, que nao permite.
      //cont=cont*2
    }
    Console.WriteLine("Valor de cont pós estrutura: {0}", cont);*/


    /*
    //arrumando por passo.
   

    if(inicio<final && passo<0)
    {
    Console.WriteLine("1º IF");
    passo=passo*-1;
    }
    if(inicio>final && passo>0)
    {
    Console.WriteLine("2º IF");
    passo=passo*-1;
    }
    
    
    //arrumando por inversão:
  if(inicio<final && passo<0)
    {
    Console.WriteLine("3º IF");
    aux=inicio;
    inicio=final;
    final=aux;
    }
    if(inicio>final && passo>0)
    {
    Console.WriteLine("4º IF");
    aux=inicio;
    inicio=final;
    final=aux;
    }
    */

   int cont, inicio, final, passo, aux, op;
    Console.Write("Digite o inicio: ");
    inicio=int.Parse(Console.ReadLine());
    Console.Write("Digite o final: ");
    final=int.Parse(Console.ReadLine());
    Console.Write("Digite o passo: ");
    passo=int.Parse(Console.ReadLine());

    if(inicio<final && passo<0 || inicio>final && passo>0)
    {
      do
      {
        
        Console.WriteLine("╔══════════════════════════════╗ ");
        Console.WriteLine("║            Digite            ║");
        Console.WriteLine("║ 1 = Inverter o Passo         ║");
        Console.WriteLine("║ 2 = Inversão de inicio/final ║");
        Console.WriteLine("╚══════════════════════════════╝ ");
        op=int.Parse(Console.ReadLine());
  
        switch(op)
        {
          case 1:
            //ARRUMANDO O PASSO
            if(inicio<final && passo<0)
            {
              Console.WriteLine("1º IF");
              passo=passo*-1;
            }
            if(inicio>final && passo>0)
            {
              Console.WriteLine("2º IF");
              passo=passo*-1;
            }
          break;
          case 2:
            //ARRUMANDO POR INVERSÃO DE INICIO E FINAL
            if(inicio<final && passo<0)
            {
              Console.WriteLine("3º IF");
              aux=inicio;
              inicio=final;
              final=aux;
            }
            if(inicio>final && passo>0)
            {
              Console.WriteLine("4º IF");
              aux=inicio;
              inicio=final;
              final=aux;
            }
          break;
          default:
            Console.WriteLine("Opção Inválida!!!");
          break;
        }
      }while(op!=1 && op!=2);
    }
    
    if(inicio<final && passo>0)
    {
      Console.WriteLine("1º FOR");
      for(cont=inicio;cont<=final;cont=cont+passo) 
      {
        Console.WriteLine("{0}- valor", cont);
      }
    }
    else
    {
      Console.WriteLine("2º FOR");
      for(cont=inicio;cont>=final;cont=cont+passo) 
      {
        Console.WriteLine("{0}- valor", cont);
      }
    } 
    Console.Write("ACABÔ!");
   
  }
}