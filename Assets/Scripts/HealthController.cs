using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private SO_PlayerAttributes playerAttributes;
    [SerializeField] private TextMeshProUGUI player1HpText;
    [SerializeField] private TextMeshProUGUI player2HpText;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private PlayerMovement playerMovementScript;

    private void Start()
    {
            player1HpText.text = playerAttributes.player1Health.ToString();
            player2HpText.text = playerAttributes.player2Health.ToString();
    }
    public void ChangePlayerHP(int hpChange, GameObject playerObject)
    {
        if (playerObject.GetComponent<PlayerShoot>().playerNumber == 1)
        {
            playerAttributes.player1Health += hpChange;
            player1HpText.text = playerAttributes.player1Health.ToString();
            if (playerAttributes.player1Health < 1)
            {
                deathScreen.SetActive(true);
                playerObject.GetComponent<PlayerMovement>().movementSpeed = 0;
            }
        }
        else if (playerObject.GetComponent<PlayerShoot>().playerNumber == 2)
        {
            playerAttributes.player2Health += hpChange;
            player2HpText.text = playerAttributes.player2Health.ToString();
            if (playerAttributes.player2Health < 1)
            {
                deathScreen.SetActive(true);
                playerObject.GetComponent<PlayerMovement>().movementSpeed = 0;
            }
        }
    }
}
