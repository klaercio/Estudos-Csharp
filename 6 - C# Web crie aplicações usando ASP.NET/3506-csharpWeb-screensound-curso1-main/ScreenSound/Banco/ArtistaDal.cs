using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class ArtistaDal
{
    private readonly ScreenSoundContext context;

    public ArtistaDal(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();

        //var lista = new List<Artista>();
        //connectionBanco.Open();

        //string sql = "SELECT * FROM Artistas";

        //SqlCommand comand = new SqlCommand(sql, connectionBanco);
        //using SqlDataReader reader = comand.ExecuteReader();

        //while (reader.Read())
        //{
        //    string nomeArtista = Convert.ToString(reader["Nome"]);
        //    string bioArtista = Convert.ToString(reader["Bio"]);
        //    int idArtista = Convert.ToInt32(reader["Id"]);

        //    Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };
        //    lista.Add(artista);
        //}

        //return lista;
    }

    public void AdicionarArtista(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();

        //using var connection = new ScreenSoundContext().ObterCOnexao();
        //connection.Open();
        //string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";

        //SqlCommand comand = new SqlCommand(sql, connection);

        //comand.Parameters.AddWithValue("@nome", artista.Nome);
        //comand.Parameters.AddWithValue("bio", artista.Bio);
        //comand.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);

        //int retorno = comand.ExecuteNonQuery();

        //if (retorno > 0)
        //{
        //    Console.WriteLine($"{retorno} linhas afetadas");
        //}
    }

    public void AtualizarArtista(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();

        //using var connection = new ScreenSoundContext().ObterCOnexao();
        //connection.Open();

        //string sql = "UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";

        //SqlCommand command = new SqlCommand(sql, connection);

        //command.Parameters.AddWithValue("@Nome", artista.Nome);
        //command.Parameters.AddWithValue("@Bio", artista.Bio);
        //command.Parameters.AddWithValue("@Id", artista.Id);

        //int retorno = command.ExecuteNonQuery();

        //if (retorno > 0)
        //{
        //    Console.WriteLine($"{retorno} linhas afetadas na atualização do  artista");
        //}

    }

    public void DeletarArtista(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();

        //using var connection = new ScreenSoundContext().ObterCOnexao();
        //connection.Open();

        //string sql = "Delete from Artistas Where Id =  @id";

        //SqlCommand command = new SqlCommand(sql, connection);

        //command.Parameters.AddWithValue("@id", artista.Id);

        //int retorno = command.ExecuteNonQuery();

        //if (retorno > 0)
        //{
        //    Console.WriteLine($"{retorno} linha(s) afetada(s)");
        //}
    }

    public Artista RecuperarPeloNome(string nome)
    {
        return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome))!;
    }
}
