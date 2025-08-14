using VerificadorSenha.Interface;
using VerificadorSenha.Models;

namespace VerificadorSenha.Service;

public class SenhaService : ISenhaService
{
    public bool VerificarCaractereEspecial(string senha)
    {
        var caracteresEspeciais = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*'};

        var senhaChar = TransformarEmChar(senha);

        for (int i = 0; i < senhaChar.Length; i++)
        {
            if (senhaChar[i] != caracteresEspeciais[i])
            {
                return false;
            }
        }
       
        return true;
    }

    public bool VerificarCaractereNumerico(string senha)
    {
        var numeros = new List<char> {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        
        var senhaChar = TransformarEmChar(senha);

        for (int i = 0; i < senhaChar.Length; i++)
        {
            if (senhaChar[i] != numeros[i])
            {
                return false;
            }
        }
        return true;
    }

    public bool VerificarMaiusculas(string senha)
    {
        var letrasMaiusculas = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
            'W', 'X', 'Y', 'Z'
        };
        
        var senhaChar = TransformarEmChar(senha);

        for (int i = 0; i < senhaChar.Length; i++)
        {
            if (senhaChar[i] != letrasMaiusculas[i])
            {
                return false;
            }
        }
        return true;
    }

    public bool VerificarMinusculas(string senha)
    {
        var letrasMinusculas = new List<char>
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
            'w', 'x', 'y', 'z'
        };
        
        var senhaChar = TransformarEmChar(senha);

        for (int i = 0; i < senhaChar.Length; i++)
        {
            if (senhaChar[i] != letrasMinusculas[i])
            {
                return false;
            }
        }
        return true;
    }

    public char[] TransformarEmChar(string senha)
    {
        char[] charArray = new char[senha.Length];
        
        for (int i = 0; i < senha.Length; i++)
        {
            charArray[i] = senha[i];
        }
        
        return charArray;
    }
    
}