using System;

// ======================================
// INTERFACE
// ======================================
public interface IFile{
    void AccessFile();
}

// ======================================
// REAL SUBJECT
// ======================================
public class RealFile : IFile{
    private string fileName;

    public RealFile(string fileName){
        this.fileName = fileName;
    }
    //Metodo para Acessar o arquivo
    public void AccessFile(){
        Console.WriteLine($"Acessando arquivo: {fileName}");
    }
}

// ======================================
// PROXY
// ======================================
public class FileProxy : IFile{
    private RealFile realFile; //Instancia do arquivo, pode ser null ou um arquivo que buscou
    private string fileName; //Nome do arquivo que deseja abrir
    private bool isAdmin; //he um administrador?

    public FileProxy(string fileName, bool isAdmin){
        this.fileName = fileName;
        this.isAdmin = isAdmin;
    }
    public void AccessFile(){
        Console.WriteLine("Proxy: Verificando permissões...");
        if (isAdmin){ // Verifica se he um administrador
            // Cria o objeto real apenas quando necessário
            if (realFile == null){ // Buscar arquivo
                realFile = new RealFile(fileName);
            }
            realFile.AccessFile();
        }else{ // Regeitar a busca pelo arquivo
            Console.WriteLine("Acesso negado.");
        }
    }
}

// ======================================
// MAIN
// ======================================
public class Program{
    public static void Main(){
        //Geralmente para que o campo de isAdmin seja true, geralmente tem que 
        //inserir a senha. He um sistema parecido com o sudo do linux

        Console.WriteLine("=== Usuario Admin ===");

        IFile adminFile = new FileProxy("relatorio.txt", true);
        adminFile.AccessFile();

        Console.WriteLine();
        Console.WriteLine("=== Usuario Comum ===");

        IFile userFile = new FileProxy("relatorio.txt", false);
        userFile.AccessFile();
    }
}
