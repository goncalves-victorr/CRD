using CRD.Models;

namespace CRD.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> ConsultarTodos();
        Task<List<UsuarioModel>> ConsultarPorCPF(int cpf);
        Task<List<UsuarioModel>> Adicionar(UsuarioModel usuario);
        Task<bool> Apagar(int cpf);

    }
}
