using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula{Titulo = "Wakanda Forever", FechaLanzamiento = new DateTime(2022,11,11), Poster ="https://lumiere-a.akamaihd.net/v1/images/pp_disney_blackpanther_wakandaforever_1289_d3419b8f.jpeg"},
                new Pelicula{Titulo = "Wakanda Forever", FechaLanzamiento = new DateTime(2023,1,11),Poster ="https://lumiere-a.akamaihd.net/v1/images/pp_disney_blackpanther_wakandaforever_1289_d3419b8f.jpeg"},
                new Pelicula{Titulo = "Wakanda Forever", FechaLanzamiento = new DateTime(2023,08,1), Poster = "https://lumiere-a.akamaihd.net/v1/images/pp_disney_blackpanther_wakandaforever_1289_d3419b8f.jpeg" }
            };
        }
    }   
}
