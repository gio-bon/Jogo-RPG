namespace Jogo_RPG.src.Entities
{
    public abstract class Hero //abstract é uma classe abstrata, servindo de modelo para classes que descendam dela
    {
        public Hero(string Name, int Level, string Weapon)  //atalho `ctor` + tab do método construtor
        {
            this.name = Name;
            this.level = Level;
            this.weapon = Weapon;
        }

        public string name;
        public int level;
        public string weapon;

        public override string ToString() //override é a sobrescrita de método que já existe
        {
            return this.name + " " + this.level + " " + this.weapon;
        }

        public virtual string Attack(){  //metodo virtual permite que classes filhos sobreponham seu comportamento
            return this.name + " ataca com " + this.weapon;
        }
    }
}