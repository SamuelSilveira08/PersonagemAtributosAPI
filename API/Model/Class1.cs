using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Atributos
    {
        public Personagem Personagem { get; set; }
        public int Forca {  get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }

        public Atributos()
        {
        }

        public Atributos(Personagem personagem, int forca, int destreza, int constituicao, int inteligencia, int sabedoria, int carisma)
        {
            Personagem = personagem ?? throw new ArgumentNullException(nameof(personagem));
            Forca = forca >= 0 ? forca 
                : throw new ArgumentException($"Argumento {nameof(forca)} não pode ser negativo");
            Destreza = destreza >= 0 ? forca
                : throw new ArgumentException($"Argumento {nameof(destreza)} não pode ser negativo");
            Constituicao = constituicao >= 0 ? destreza
                : throw new ArgumentException($"Argumento {nameof(constituicao)} não pode ser negativo");
            Inteligencia = inteligencia >= 0 ? inteligencia
                : throw new ArgumentException($"Argumento {nameof(inteligencia)} não pode ser negativo");
            Sabedoria = sabedoria >= 0 ? sabedoria
                : throw new ArgumentException($"Argumento {nameof(sabedoria)} não pode ser negativo");
            Carisma = carisma >= 0 ? carisma
                : throw new ArgumentException($"Argumento {nameof(carisma)} não pode ser negativo");
        }
    }
}
