using System.Security.Cryptography.X509Certificates;

namespace POO.Models;

internal class Consulta
{
    public Medico Medico { get; }
    public Pet Pet { get; }
    public DateTime DataHora { get; }

    public Consulta(Medico medico, Pet pet, DateTime dataHora)
    {
        Medico = medico;
        Pet = pet;
        DataHora = dataHora;
    }
}
