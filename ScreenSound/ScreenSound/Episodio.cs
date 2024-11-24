using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Episodio
    {   
        private List<string> convidados = new List<string>();
        public int Duracao { get;  }
        public int Ordem { get;  }
        public string Resumo => $"{Ordem}, {Titulo}, {Duracao} min - " +
            $"{string.Join(", ",convidados)}";
        public string Titulo { get; }

        public Episodio(int ordem,  int duracao, string titulo)
        {
            Ordem = ordem;
            Duracao = duracao;
            Titulo = titulo;
        }

        public void AdicionarConvidados(string nomeDoConvidado)
        {
            convidados.Add(nomeDoConvidado);
        }
    }
}
