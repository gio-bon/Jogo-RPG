namespace Jogo_RPG.src.Entities
{
    public class Wizard : Hero // ':' faz com que herde da classe Hero (atributos e métodos)
    {

        public override string Attack(){
        return this.name + " lança magia de " + this.weapon;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6){
                return this.name + " Lança magia forte com bonus de " + Bonus;
            }else{
                return this.name + " Lança magia fraca com bonus de " + Bonus;
            }
        }

        public Wizard(string Name, int Level, string Weapon) : base (Name, Level, Weapon)
        {
            this.name = Name;
            this.level = Level;
            this.weapon = Weapon;
        }

    }
}