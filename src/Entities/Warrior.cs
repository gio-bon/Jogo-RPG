namespace Jogo_RPG.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string Name, int Level, string Weapon) : base (Name, Level, Weapon) //uso de ': base' para reaproveitar o comportamento do construtor da classe pai
        {
            this.name = Name;
            this.level = Level;
            this.weapon = Weapon;
        }

        public override string Attack(){
        return this.name + " ataca com " + this.weapon;
        }
    }
}