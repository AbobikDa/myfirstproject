using UnityEngine;
using TMPro;

public class UIEngine : MonoBehaviour
{
    public TextMeshProUGUI UICoinCounter;
    public PlayerStatList playerStatList;

    private void Update()
    {
        UICoinCounter.text = $"coins: {playerStatList.coinCount.ToString()}";
    }
}
