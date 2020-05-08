using System;

class Login{

protected string usuario="vinhosvaldos";
protected int senha=1234;

public bool Verificarlogin(string usu, int sen){
  if(usuario == usu && senha == sen)
  {
    Console.WriteLine("Úsuario e senha, corretos!");
    return true;
  }
  else
  {
    Console.WriteLine("Úsuario e senha, incorretos!");
    return false;
  }
}

}


class CadastroFuncionario{

//Variaveis

  protected string nomePessoa;
  protected int idade;
  protected int cpf;
  protected string dataNascimento;
  protected string dataAdmissao;
  protected string setor;
  protected string funcao;

//Sets e Gets

  public void SetnomePessoa(string recnomePessoa){
    nomePessoa = recnomePessoa;
  }
  public string GetnomePessoa(){
    return nomePessoa;
  }

  public void Setidade(int recidade){
    idade = recidade;
  }
  public int Getidade(){
    return idade;
  }

  public void Setcpf(int reccpf){
    cpf = reccpf;
  }
  public int Getcpf(){
    return cpf;
  }

}

class CadastroExames{

//Variaveis

protected string nomeEXM;

//Sets e Gets

public void SetnomeEXM(string recnomeEXM){
    nomeEXM = recnomeEXM;
  }
  public string GetnomeEXM(){
    return nomeEXM;
  }

}

class CadastroFuncoes{

//Variaveis

protected string nomeFun;

//Sets e Gets

public void SetnomeFun(string recnomeFun){
    nomeFun = recnomeFun;
  }
  public string GetnomeFun(){
    return nomeFun;
  }

}

class CadastroSetores{

//Variaveis

protected string nomeSetores;

//Sets e Gets++

public void SetnomeSetores(string recnomeSetores){
    nomeSetores = recnomeSetores;
  }
  public string GetnomeSetores(){
    return nomeSetores;
  }

}

class GeradorFichaEmpresa{

}

class GeradorFichaClinica{

}

class MainClass {
  public static void Main (string[] args) {
    
    string usu;
    int sen;

    Console.WriteLine ("Bem Vindo ao Programa de CPMSO, Digite seu login e senha.");
    Login log = new Login();
    usu = Console.ReadLine();
    sen = Convert.ToInt32(Console.ReadLine());
    log.Verificarlogin(usu, sen);




  }
}