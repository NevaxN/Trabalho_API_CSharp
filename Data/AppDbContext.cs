using Microsoft.EntityFrameworkCore;
using TrabalhoAPI.Data.Models;

namespace TrabalhoAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Catalogo> Catalogos { get; set; }
        public DbSet<CatalogoFilme> CatalogoFilmes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<GeneroUsuario> GeneroUsuarios { get; set; }
        public DbSet<GeneroFilme> GeneroFilmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relação Filme - Catalogo
            modelBuilder.Entity<Filme>()
                .Ignore(f => f.CatalogoIds);

            modelBuilder.Entity<CatalogoFilme>()
                .HasOne(f => f.Filme)
                .WithMany(cf => cf.CatalogoFilmes)
                .HasForeignKey(fi => fi.FilmeId);

            modelBuilder.Entity<CatalogoFilme>()
                .HasOne(c => c.Catalogo)
                .WithMany(cf => cf.CatalogoFilmes)
                .HasForeignKey(ci => ci.CatalogoId);

            //Relacão Filme - Usuario (Watchlist)
            modelBuilder.Entity<Usuario>()
                .Ignore(u => u.FilmeIds);

            modelBuilder.Entity<Watchlist>()
                .HasOne(u => u.Usuario)
                .WithMany(w => w.Watchlists)
                .HasForeignKey(ui => ui.UsuarioId);

            modelBuilder.Entity<GeneroUsuario>()
                .HasOne(u => u.Usuario)
                .WithMany(gu => gu.GeneroUsuarios)
                .HasForeignKey(ui => ui.UsuarioId);

            modelBuilder.Entity<GeneroFilme>()
                .HasOne(f => f.Filme)
                .WithMany(gf => gf.GeneroFilmes)
                .HasForeignKey(fi => fi.FilmeId);
        
            base.OnModelCreating(modelBuilder);
        }
    }
}