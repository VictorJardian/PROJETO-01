using System;
using System.IO;
using System.Text;

class Login{

protected string usuario="vinhosvaldos";
protected int senha=1234;

public bool Verificarlogin(string usu, int sen){
  if(usuario == usu && senha == sen)
  {
    Console.Clear();
    Console.WriteLine("Úsuario e senha, corretos!");
    return true;
  }
  else
  {
    Console.Clear();
    Console.WriteLine("Úsuario e senha, incorretos!");
    return false;
  }
}
}

class Interface{

public void exibirOpcoes(){

Console.WriteLine("1- Gerar ficha medica da Empresa.");
Console.WriteLine("2- Gerar ficha medica da Clinica.");
Console.WriteLine("3- Visualizar lista de funcionarios.");
Console.WriteLine("4- Sair.");
}

}

class GeradorFichaEmpresa{

}

class GeradorFichaClinica{

protected string localConsulta;
protected string nomeEmpresa;

public void SetlocalConsulta(string reclocalConsulta){
    localConsulta = reclocalConsulta;
  }
  public string GetlocalConsulta(){
    return localConsulta;
  }

public void SetnomeEmpresa(string recnomeEmpresa){
    nomeEmpresa = recnomeEmpresa;
  }
  public string GetnomeEmpresa(){
    return nomeEmpresa;
  }

public GeradorFichaClinica (){
localConsulta = "Av. Valdopolis, 2000, Telefone: (27) 2000 - 2000, Aberto de Seg. a Sexta das 08:00 as 16:00.";
nomeEmpresa = "VinhosValdos";
}

}

class MainClass {
  public static void Main (string[] args) {
    
    int opcao;
    string entradaArq;
    string usu;
    int sen;

    Console.WriteLine ("Bem Vindo ao Programa de CPMSO, Digite seu login e senha.");

    Login log = new Login();
    usu = Console.ReadLine();
    sen = Convert.ToInt32(Console.ReadLine());
    log.Verificarlogin(usu, sen);

    Console.WriteLine ("");
    Console.WriteLine ("Digite o numero da opção que deseja");
    Console.WriteLine ("");

    Interface inter = new Interface();
    inter.exibirOpcoes();
    opcao = Convert.ToInt32(Console.ReadLine());

    if(opcao==1) //Gerar ficha medica da Empresa.
    {
      Console.Clear();
    }

    if(opcao==2) //Gerar ficha medica da Clinica.
    {
      Console.Clear(); 
    }

    if(opcao==3) //Visualizar lista de funcionarios.
    {
      Console.Clear();

      FileStream arquivofuncionarios = new FileStream("listaInfFuncionarios.txt", FileMode.Open, FileAccess.Read);
      StreamReader lendo = new StreamReader(arquivofuncionarios, Encoding.UTF8);
      entradaArq = lendo.ReadLine();
      Console.WriteLine (entradaArq);

    }

    if(opcao==4) //SAIR.
    { 
      Console.Clear();
    }


  }
}