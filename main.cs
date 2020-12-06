using System;

class MainClass {

  public static void Main (string[] args) {

    //Data data = new Data("1","2","2018");
    Data data = new Data();

    digitaDatas();
  }

  public static void digitaDatas(){
    string resposta = "s";
    string dataDigitada = ""; 

    while(resposta == "s"){
      Console.WriteLine("Digite uma data no formado dd/mm/aaaa:");
      dataDigitada = Console.ReadLine();

      Console.WriteLine("Digite 's' para mais uma data ou qualquer tecla para sair.");

      resposta = Console.ReadLine();
    }
  
    Console.WriteLine(dataDigitada.Substring(0, 2));
  }
}