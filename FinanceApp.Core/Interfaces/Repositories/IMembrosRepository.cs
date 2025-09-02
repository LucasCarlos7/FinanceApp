using FinanceApp.Core.InputModels;

namespace FinanceApp.Core.Interfaces.Repositories;

public interface IMembrosRepository
{
    Task InserirAsync(MembrosInputModel membros);
}

