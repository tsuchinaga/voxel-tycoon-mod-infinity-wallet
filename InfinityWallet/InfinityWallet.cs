using VoxelTycoon;
using VoxelTycoon.Modding;

namespace InfinityWallet
{
    public class FullWallet : Mod
    {
        protected override void OnGameStarted()
        {
            CompanyManager.Current.CurrentCompany.AddMoney(double.PositiveInfinity, BudgetItem.Other);
        }
    }
}
