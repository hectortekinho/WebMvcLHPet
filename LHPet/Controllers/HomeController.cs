using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Ryan", "001.032.950-01", "ryan@gmail.com", "Hulk");
        Cliente cliente2 = new Cliente(02, "Luciana", "002.032.950-02", "luciana@gmail.com", "Teko");
        Cliente cliente3 = new Cliente(03, "Ryan", "003.032.950-03", "taty@gmail.com", "Black");
        Cliente cliente4 = new Cliente(04, "Ryan", "004.032.950-04", "rafa@gmail.com", "Look");
        Cliente cliente5 = new Cliente(05, "Ryan", "005.032.950-05", "tacy@gmail.com", "Ozzy");

        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>(); 
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo Fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01, "PetDream", "01.182.102/0001-01", "petdream@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "RcPet", "02.182.102/0001-02", "recpetm@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "TikPet", "03.182.102/0001-03", "tikpet@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "TokPet", "04.182.102/0001-04", "tokpet@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "LuluPet", "05.182.102/0001-05", "lulupet@gmail.com");

        // lista de fornecedores e atribui os fornecedores 
        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); 
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
