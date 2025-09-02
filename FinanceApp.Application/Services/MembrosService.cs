using FinanceApp.Core.InputModels;
using FinanceApp.Core.Interfaces.Repositories;
using FinanceApp.Core.Interfaces.Services;

namespace FinanceApp.Application.Services;

public class MembrosService : IMembrosService
{
    private readonly IMembrosRepository _membrosRepository;

    public MembrosService(IMembrosRepository membrosRepository)
    {
        _membrosRepository = membrosRepository;
    }

    public async Task InserirAsync(MembrosInputModel membros)
    {
        await _membrosRepository.InserirAsync(membros);
    }
}

