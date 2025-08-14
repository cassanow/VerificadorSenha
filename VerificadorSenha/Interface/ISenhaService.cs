using VerificadorSenha.Models;

namespace VerificadorSenha.Interface;

public interface ISenhaService
{
    bool VerificarCaractereEspecial(string senha);
    
    bool VerificarCaractereNumerico(string senha);
    
    bool VerificarMaiusculas(string senha);
    
    bool VerificarMinusculas(string senha);
}