using UnityEngine;
using TMPro;

public class UIEngine : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _UICoinCounter;
    [SerializeField] private TextMeshProUGUI _UIHealthCounter;
    [SerializeField] private PlayerStatList _playerStats;

    private void Update()
    {
        _UICoinCounter.text = $"coins: {_playerStats.coinCount.ToString()}";
        _UIHealthCounter.text = $"health: {_playerStats.healthCount.ToString()}";
    }
}
