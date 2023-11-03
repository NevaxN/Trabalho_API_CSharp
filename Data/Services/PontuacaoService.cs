using TrabalhoAPI.Data.Models;
using TrabalhoAPI.Data.ViewModels;

namespace TrabalhoAPI.Data.Services
{
    public class PontuacaoService
    {
        private readonly AppDbContext _context;
        public PontuacaoService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarPontuacao(PontuacaoVM pontuacao)
        {
            var _pontuacao = new Pontuacao(){
                Score = pontuacao.Score,
                UsuarioId = pontuacao.UsuarioId, 
                FilmeId = pontuacao.FilmeId
            };
            _context.Add(_pontuacao);
            _context.SaveChanges();
        }

        public List<Pontuacao> ListarPontuacao()
        {
            return _context.Pontuacoes.ToList();
        }

        public Pontuacao ListarPontuacaoPorId(int pontuacaoId)
        {
            return _context.Pontuacoes.FirstOrDefault(p => p.Id == pontuacaoId) ?? new Pontuacao();
        }

        public Pontuacao UpdatePontuacaoPorId(int pontuacaoId, PontuacaoVM pontuacao)
        {
            var _pontuacao = _context.Pontuacoes.FirstOrDefault(p => p.Id == pontuacaoId);
            if(_pontuacao != null)
            {
                _pontuacao.Score = pontuacao.Score;

                _context.SaveChanges();
            }

            return _pontuacao ?? new Pontuacao();
        }

        public void DeletarPontuacaoPorId(int pontuacaoId)
        {
            var _pontuacao = _context.Pontuacoes.FirstOrDefault(p => p.Id == pontuacaoId);
            
            if(_pontuacao != null)
            {
                _context.Pontuacoes.Remove(_pontuacao);
                _context.SaveChanges();
            }
        }
    }
}