namespace Pokemon_Battle_Simulator.Classes
{
    public class Battle
    {
        public Trainer trainer1;
        public Trainer trainer2;
        public int trainer1Win = 0;
        public int trainer2Win = 0;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public string GetBattleResult()
        {
            if (trainer1Win > trainer2Win)
                return $"\n{trainer1.Name} wint de battle met {trainer1Win} tegen {trainer2Win}!";
            else if (trainer2Win > trainer1Win)
                return $"\n{trainer2.Name} wint de battle met {trainer2Win} tegen {trainer1Win}!";
            else
                return "De battle eindigt in een gelijkspel!";
        }
    }
}