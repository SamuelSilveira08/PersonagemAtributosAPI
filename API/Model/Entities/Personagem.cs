using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Personagem : IEntity, IEquatable<Personagem>
    {

        public string Id { get; set; }
        public string Nome { get; set; }
        public Raca Raca { get; set; }
        public Classe Classe { get; set; }
        public Subclasse Subclasse { get; set; }
        public int Nivel { get; set; }
        public int Xp { get; set; }
        public int Vida { get; set; }
        public int? VidaExtra { get; set; }
        public Alinhamento Alinhamento { get; set; }
        public bool EstaMorto { get; set; }

        public Personagem(string idPersonagem, string nome, Raca raca, Classe classe, 
            Subclasse subclasse, int nivel, int xp, int vida, int? vidaExtra, 
            Alinhamento alinhamento, bool isDead)
        {
            Id = idPersonagem ?? throw new ArgumentNullException(nameof(idPersonagem));
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
            Nivel = nivel >= 1 ? nivel
                : throw new ArgumentException($"Argumento {nameof(nivel)} não pode ser negativo");
            Xp = xp >= 0 ? xp
                : throw new ArgumentException($"Argumento {nameof(xp)} não pode ser negativo");
            Vida = vida >= 0 ? vida
                : throw new ArgumentException($"Argumento {nameof(vida)} não pode ser negativo");
            VidaExtra = vidaExtra;
            Alinhamento = alinhamento;
            EstaMorto = isDead;
        }

        public Personagem()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Personagem);
        }

        public bool Equals(Personagem other)
        {
            return !(other is null) &&
                   Id == other.Id &&
                   Nome == other.Nome &&
                   Raca == other.Raca &&
                   EqualityComparer<Classe>.Default.Equals(Classe, other.Classe) &&
                   EqualityComparer<Subclasse>.Default.Equals(Subclasse, other.Subclasse) &&
                   Nivel == other.Nivel &&
                   Xp == other.Xp &&
                   Vida == other.Vida &&
                   VidaExtra == other.VidaExtra &&
                   Alinhamento == other.Alinhamento &&
                   EstaMorto == other.EstaMorto;
        }

        public override int GetHashCode()
        {
            int hashCode = 1203186678;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Raca.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Classe>.Default.GetHashCode(Classe);
            hashCode = hashCode * -1521134295 + EqualityComparer<Subclasse>.Default.GetHashCode(Subclasse);
            hashCode = hashCode * -1521134295 + Nivel.GetHashCode();
            hashCode = hashCode * -1521134295 + Xp.GetHashCode();
            hashCode = hashCode * -1521134295 + Vida.GetHashCode();
            hashCode = hashCode * -1521134295 + VidaExtra.GetHashCode();
            hashCode = hashCode * -1521134295 + Alinhamento.GetHashCode();
            hashCode = hashCode * -1521134295 + EstaMorto.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Personagem left, Personagem right)
        {
            return EqualityComparer<Personagem>.Default.Equals(left, right);
        }

        public static bool operator !=(Personagem left, Personagem right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"[Id: {this.Id}, Nome: {this.Nome}, Raça: {this.Raca}, Classe: {this.Classe.Descricao}," +
                $" Subclasse: {this.Subclasse.Descricao}, Nível: {this.Nivel}, XP: {this.Xp}, " +
                $"Vida: {this.Vida}, Vida extra: {this.VidaExtra}, Alinhamento: {this.Alinhamento}, " +
                $"Vivo: {(this.EstaMorto ? "Não" : "Sim")}]";
        }
    }
}
