using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Personagem
    {

        public string IdPersonagem { get; set; }
        public string Nome { get; set; }
        public Raca Raca { get; set; }
        public Classe Classe { get; set; }
        public Subclasse Subclasse { get; set; }
        public int Nivel { get; set; }
        public int Xp { get; set; }
        public int Vida { get; set; }
        public int? VidaExtra { get; set; }
        public Alinhamento Alinhamento { get; set; }
        public bool IsDead { get; set; }

        public Personagem(string idPersonagem, string nome, Raca raca, Classe classe, 
            Subclasse subclasse, int nivel, int xp, int vida, int? vidaExtra, 
            Alinhamento alinhamento, bool isDead)
        {
            IdPersonagem = idPersonagem ?? throw new ArgumentNullException(nameof(idPersonagem));
            if (idPersonagem.Length > 36)
                throw new ArgumentException($"Argumento {nameof(idPersonagem)} " +
                    $"acima do limite de caracteres.");
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            if (nome.Length > 36)
                throw new ArgumentException($"Argumento {nameof(nome)} " +
                    $"acima do limite de caracteres.");
            Raca = Enum.IsDefined(typeof(Raca), raca) ? raca
                : throw new ArgumentException(
                    $"Argumento {nameof(raca)} inválido. Passe uma raça existente");
            Classe = classe ?? throw new ArgumentNullException(nameof(classe));
            Subclasse = subclasse ?? throw new ArgumentNullException(nameof(subclasse));
            Nivel = nivel >= 0 ? nivel
                : throw new ArgumentException($"Argumento {nameof(nivel)} não pode ser negativo");
            Xp = xp >= 0 ? xp
                : throw new ArgumentException($"Argumento {nameof(xp)} não pode ser negativo");
            Vida = vida >= 0 ? vida
                : throw new ArgumentException($"Argumento {nameof(vida)} não pode ser negativo");
            VidaExtra = vidaExtra;
            Alinhamento = alinhamento;
            IsDead = isDead;
        }

        public Personagem()
        {
        }

    }
}
