using TMPro;
using UnityEngine;

namespace Gameplay
{
    public class WalletView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _moneyView;

        public void Construct(Wallet wallet)
        {
            wallet.MoneyChanged += DisplayAmount;
        }

        private void DisplayAmount(int money)
        {
            _moneyView.text = money.ToString();
        }
    }
}