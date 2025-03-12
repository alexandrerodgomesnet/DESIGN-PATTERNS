using System.Text;

namespace SINGLETON.MODO_COMUM;

public class ModoComum
{
    public static void Run()
    {
        var query = new StringBuilder();
        query.AppendLine("CREATE TABLE usuario(id INT(11) AUTO_INCREMENT PRIMARY KEY,");
        query.AppendLine("nome VARCHAR(100) NOT NULL");
        query.AppendLine("email VARCHAR(60)");
        query.AppendLine("senha VARCHAR(100))");
        
        Console.WriteLine("Banco 1");
        var banco1 = new MySql();
        banco1.ExecuteQuery(query.ToString());
        Console.WriteLine(banco1);

        Console.WriteLine("Banco 2");
        var banco2 = new MySql();
        banco2.ExecuteQuery(query.ToString());
        Console.WriteLine(banco2);

        Console.WriteLine("Alteracao user Banco 1");
        banco1.SetUser("blabla");
        Console.WriteLine(banco1);

    }
}