using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int healthPoints = 3;
    [SerializeField] private TextMeshProUGUI playerHpText;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private PlayerMovement playerMovementScript;

    private void Start()
    {
        playerHpText.text = healthPoints.ToString();
    }
    public void ChangePlayerHP(int hpChange)
    {
        healthPoints += hpChange;
        playerHpText.text = healthPoints.ToString();
        if (healthPoints == 0)
        {
            deathScreen.SetActive(true);
            playerMovementScript.movementSpeed = 0;
        }
    }
}
