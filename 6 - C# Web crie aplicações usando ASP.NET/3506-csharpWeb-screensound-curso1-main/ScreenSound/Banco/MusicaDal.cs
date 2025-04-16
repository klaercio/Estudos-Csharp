using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class MusicaDal
{
    private readonly ScreenSoundContext context = new ScreenSoundContext();

    public MusicaDal(ScreenSoundContext context)
    {
        this.context = context;
    }

    public void AdicionarMusica(Musica musica)
    {
        context.Add(musica);
        context.SaveChanges();
    }

    public IEnumerable<Musica> ListarMusicas()
    {
        return context.Musicas.ToList();
    }

    public void AtualizarMusica(Musica musica)
    {
        context.Musicas.Update(musica);
        context.SaveChanges();
    }

    public void ExcluirMusica(Musica musica)
    {
        context.Remove(musica);
        context.SaveChanges();
    }

    public Musica? RecuperarPeloNome(string nome)
    {
        return context.Musicas.FirstOrDefault(a => a.Nome.Equals(nome));

    }
}
