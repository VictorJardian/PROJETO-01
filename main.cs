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

  protected string nomePessoa;
  protected int idade;
  protected int cpf;
  protected string dataNascimento;
  protected string dataAdmissao;
  protected string setor;
  protected string funcao;

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

protected string nomeEXM;

public void SetnomeEXM(string recnomeEXM){
    nomeEXM = recnomeEXM;
  }
  public string GetnomeEXM(){
    return nomeEXM;
  }

}

class CadastroFuncoes{

protected string nomeFun;

public void SetnomeFun(string recnomeFun){
    nomeFun = recnomeFun;
  }
  public string GetnomeFun(){
    return nomeFun;
  }

}

class CadastroSetores{

protected string nomeSetores;

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
localConsulta = "Av. Valdopolis, 2000, Telefone: (27) 2000 - 2000, Aberto de Seg. a Sexta das 08:00 as 16:00."
nomeEmpresa = "VinhosValdos";
}

}

class MainClass {
  public static void Main (string[] args) {
    
    string entrada;
    string usu;
    int sen;

    FileStream arquivo = new FileStream("listaInfFuncionarios.txt", Filemode.Open,FileAccess.Read);

    StreamReader lerArquivo = new StreamReader(arquivo, Encoding.UTF8);

    entrada = lendo.ReadLine();
    Console.WriteLine(entrada);

    Console.WriteLine ("Bem Vindo ao Programa de CPMSO, Digite seu login e senha.");

    Login log = new Login();
    usu = Console.ReadLine();
    sen = Convert.ToInt32(Console.ReadLine());
    log.Verificarlogin(usu, sen);

  }
}