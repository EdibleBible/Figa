using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    [SerializeField] public int healingPlayerAmount = 2;
    [SerializeField] public TextMeshProUGUI moneyText;
    [SerializeField] private SO_PlayerAttributes playerAttributes;
    [SerializeField] private HealthController healthController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HP"))
        {
            healthController.ChangePlayerHP(healingPlayerAmount, this.gameObject);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Money"))
        {
            playerAttributes.moneyCollected++;
            moneyText.text = playerAttributes.moneyCollected.ToString();
            Destroy(other.gameObject);
        }
    }
}
