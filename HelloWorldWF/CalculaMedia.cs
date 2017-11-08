using System;

public class CalculaMedia
    {
        public string NomeAluno { get; set; }
        public int ContadorProvas { get; set; }
        public int ContadorPontos { get; set; }
        public decimal SomaPontos { get; set; }
        public decimal SomaProvas { get; set; }

        public void InserirNotaProva(decimal nota)
        {
        if (this.ContadorPontos < 3)
        {
            this.ContadorProvas++;
            this.SomaProvas += nota;

        }else
        {
            throw new Exception("Excedeu o limite de provas no ano");
        }
       
    }

        public void InserirPonto(decimal ponto)
        {
            if (this.ContadorPontos > 3) throw new Exception("Excedeu o limite de pontos no ano");
            this.ContadorPontos++;
            this.SomaPontos += ponto;
        }

        public decimal CalcularMedia()
        {
            decimal retorno = (SomaProvas + SomaPontos) / 4;
            return retorno;
        }
    }