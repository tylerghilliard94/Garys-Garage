namespace GaryGarage
{
    public interface IElectric
    {
        int CurrentChargePercentage { get; set; }

        void ChargeBattery();
    }
}