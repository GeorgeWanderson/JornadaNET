using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JornadaNET.Entities
{

    // Programação Orientada a Objetos
    public class Evento
    {
        public Evento(int id, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, string organizador)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Organizador = organizador;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Organizador { get; private set; }

        public virtual string GerarResumo()
        {
            return $"Evento {Titulo}, {DataInicio}, {DataFim}, {Descricao}, {Organizador}";
        }


        // Simulando a classe Progrmam
        public static void ExibirAulaOOP()
        {
            Evento evento = new Evento(1, "Jornada .NET", "Um evento incrível!", DateTime.Now, DateTime.Now.AddDays(7), "LuisDev");
            var show = new Show("LuisDev", "Musicas A, B E C", 2, "Show Jornada .NET", "Jornada .NET", DateTime.Now, DateTime.Now.AddHours(4), "LuisDev");


            Console.WriteLine(evento.GerarResumo());

            var eventos = new List<Evento> { evento, show };

            foreach(var item in eventos)
            {
                Console.WriteLine(item.GerarResumo());
            }
        }
    }



}
