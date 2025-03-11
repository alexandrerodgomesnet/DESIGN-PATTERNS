namespace VISITOR.MODO_PADRAO;

public class ModoPadrao
{
    public static void Run()
    {
        var departamento1 = new Departamento("Alimentação Básica");
        var arroz = new Produto("Arroz 5kg", 18, 30);
        var macarrao = new Produto("Macarrão", 3.20M, 15);
        departamento1.AdicionarProduto(arroz);
        departamento1.AdicionarProduto(macarrao);

        var departamento2 = new Departamento("Higiene");
        var papelHigienico = new Produto("PapelHigienico", 11, 35);
        var sabonete = new Produto("Sabonete", 1.20M, 10);
        departamento2.AdicionarProduto(papelHigienico);
        departamento2.AdicionarProduto(sabonete);

        var supermercado = new Supermercado("Supermecado");
        supermercado.AdicionarDepartamento(departamento1);
        supermercado.AdicionarDepartamento(departamento2);

        var lucratividade = new Lucratividade();
        var lucratividadeSupermercado = supermercado.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Supermercado R$ {lucratividadeSupermercado}");
        Console.WriteLine();

        var lucratividadeDepartamento1 = departamento1.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Departamento 1 R$ {lucratividadeDepartamento1}");
        Console.WriteLine();

        var lucratividadeArroz = arroz.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Arroz R$ {lucratividadeArroz}");
        Console.WriteLine();

        var lucratividadeMacarrao = macarrao.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Macarrão R$ {lucratividadeMacarrao}");
        Console.WriteLine();

        var lucratividadeDepartamento2 = departamento2.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Departamento 2 R$ {lucratividadeDepartamento2}");
        Console.WriteLine();

        var lucratividadePH = papelHigienico.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Papel Higiênico R$ {lucratividadePH}");
        Console.WriteLine();

        var lucratividadeSabonete = sabonete.Aceitar(lucratividade);
        Console.WriteLine($"Lucratividade Sabonete R$ {lucratividadeSabonete}");
        Console.WriteLine();
    }
}