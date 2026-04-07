using Projeto_BancoDados.Models;

namespace Projeto_BancoDados.Repositório.Contrato
{
    public interface IUsuarioRepository
    {
        //CRUD
        IEnumerable<Usuario> ObterTodosUsuarios();

        void CadastrarUsuario(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int Id);

        void Excluir(int Id);
    }
}
