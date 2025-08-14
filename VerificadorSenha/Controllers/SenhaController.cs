using Microsoft.AspNetCore.Mvc;
using VerificadorSenha.Interface;

namespace VerificadorSenha.Controllers;

public class SenhaController : Controller
{
    private readonly ISenhaService _senhaService;

    public SenhaController(ISenhaService senhaService)
    {
        _senhaService = senhaService;
    }
    
    [HttpGet]
    public IActionResult Verificar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Verificar(string senha)
    {
        
        
        return View(senha);
    }
}