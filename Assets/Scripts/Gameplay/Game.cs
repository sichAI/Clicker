using UnityEngine;

namespace Gameplay
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Clicker _clicker;
        [SerializeField] private TemporaryBonus _temporaryBonus;
        [SerializeField] private Wallet _wallet;
        [SerializeField] private WalletView _walletView;
        [Space]
        [SerializeField] private int _initialClickValue;
        [SerializeField] private int _initialBonusValue;

        private void Start()
        {
            _clicker.Construct(_initialClickValue);
            _temporaryBonus.Construct(_initialBonusValue);
            _wallet.Construct(_clicker, _temporaryBonus);
            _walletView.Construct(_wallet);
        }
    }
}