using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Classe
    {
        public string IdClasse {  get; set; }
        public int Descricao {  get; set; }
        public IEquatable<Habilidade> habilidades { get; set; }
        public Classe() { }

    }
}
