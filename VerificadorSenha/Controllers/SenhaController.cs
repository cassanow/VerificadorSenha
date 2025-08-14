using Microsoft.AspNetCore.Mvc;
using VerificadorSenha.Interface;
using VerificadorSenha.Models;

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
    public IActionResult Verificar(string senha)
    {
        var criterios = new List<CriterioSenha>
        {
            new CriterioSenha { descricao = "Pelo menos uma letra maiuscula", atendido = _senhaService.VerificarMaiusculas(senha) },
            new CriterioSenha { descricao = "Pelo menos uma letra minuscula", atendido = _senhaService.VerificarMinusculas(senha) },
            new CriterioSenha { descricao = "Pelo menos um caractere especial (!, @, #, $, %, ^, &, *)", atendido = _senhaService.VerificarCaractereEspecial(senha) },
            new CriterioSenha { descricao = "Pelo menos um numero", atendido = _senhaService.VerificarCaractereNumerico(senha) },
            new CriterioSenha { descricao = "Minimo 15 caracteres", atendido = senha.Length >= 15 }
        };

        return Json(new
        {
            essencial = criterios.All(c => c.atendido),
            criterios,
        });
    }
}