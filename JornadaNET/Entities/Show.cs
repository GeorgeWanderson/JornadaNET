using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JornadaNET.Entities
{
    public class Show : Evento
    {
        public Show(string artista, string tracklist, int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador) : base(id, titulo, descricao, dataInicio, dataFim, organizador)
        {
            Artista = artista;
            Tracklist = tracklist;
        }

        public string Artista { get; private set; }
        public string Tracklist { get; private set; }

        public override string GerarResumo()
        {
            var resumoBase = base.GerarResumo();

            return $"{resumoBase}, {Artista}, {Tracklist}";
        }
    }
}
