namespace GaryGarage
{
    public interface IGas
    {
        int CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}