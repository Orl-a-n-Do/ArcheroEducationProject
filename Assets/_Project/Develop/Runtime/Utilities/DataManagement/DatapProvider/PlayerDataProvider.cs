using System.Collections.Generic;
using Assets._Project.Develop.Runtime.Meta.Features.Wallet;

namespace Assets._Project.Develop.Runtime.Utilities.DataManagement.DatapProvider
{
    public class PlayerDataProvider : DataProvider<PlayerData>
    {
        public PlayerDataProvider(ISaveLoadService saveLoadService) : base(saveLoadService)
        {
        }

        protected override PlayerData GetOriginData()
        {
            return new PlayerData()
            {

                WalletData = InitWalletData(),

            };
        }

        private Dictionary<CurrencyTypes, int> InitWalletData() //Стартовые данные кошелька 
        {
            Dictionary<CurrencyTypes, int> walletData = new ();

            walletData.Add(CurrencyTypes.Gold, 100);
            walletData.Add(CurrencyTypes.Diamond, 20);

            return walletData;
        }
    }


}
