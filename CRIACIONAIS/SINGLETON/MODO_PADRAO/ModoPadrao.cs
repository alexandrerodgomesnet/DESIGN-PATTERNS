using System.Text;

namespace SINGLETON.MODO_PADRAO;

public class ModoPadrao
{
    public static void Run()
    {
        var query = new StringBuilder();
        query.AppendLine("CREATE TABLE usuario(id INT(11) AUTO_INCREMENT PRIMARY KEY,");
        query.AppendLine("nome VARCHAR(100) NOT NULL");
        query.AppendLine("email VARCHAR(60)");
        query.AppendLine("senha VARCHAR(100))");
        
        Console.WriteLine("Banco 1");
        var banco1 = MySql.GetInstance();
        banco1.ExecuteQuery(query.ToString());
        Console.WriteLine(banco1);

        Console.WriteLine("Banco 2");
        var banco2 = MySql.GetInstance();
        banco2.ExecuteQuery(query.ToString());
        Console.WriteLine(banco2);

        Console.WriteLine("Alteracao user Banco 1");
        banco1.SetUser("blabla");
        Console.WriteLine(banco1);


        Console.WriteLine("Banco 2");
        Console.WriteLine(banco2);

    }
}