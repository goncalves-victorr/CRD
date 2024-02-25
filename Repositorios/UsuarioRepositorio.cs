using CRD.Data;
using CRD.Models;
using CRD.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRD.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly GerenciamentoUsuarioDBContex _dbContex;

        public UsuarioRepositorio(GerenciamentoUsuarioDBContex gerenciamentoUsuarioDBContex)
        {
            _dbContex = gerenciamentoUsuarioDBContex;
        }

        public async Task<List<UsuarioModel>> ConsultarPorCPF(int cpf)
        {
            return await _dbContex.Usuarios.FirstOrDefaultAsync(x => x.CPF == cpf);
        }

        public async Task<List<UsuarioModel>> ConsultarTodos()
        {
            return await _dbContex.Usuarios.ToListAsync();
        }

        public async Task<List<UsuarioModel>> Adicionar(UsuarioModel usuario)
        {
            await _dbContex.Usuarios.AddAsync(usuario);
            await _dbContex.SaveChangesAsync();

            return usuario;
        }

            public async Task<bool> Apagar(int cpf)
        {
            UsuarioModel usuarioPorCPF = await ConsultarPorCPF(cpf);

            if (ConsultarPorCPF == null)
            {
                throw new Exception($"Usuário para o ID: {cpf} não foi encontrado no banco de dados.");
            }

            _dbContex.Usuarios.Remove(usuarioPorCPF);
            await _dbContex.SaveChangesAsync();

            return true;
        }
    }
}
