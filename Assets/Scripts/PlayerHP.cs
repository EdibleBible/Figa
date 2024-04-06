using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public int healthPoints;
    public float playerCooldownTime = 3f;
    public bool playerCooldown = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hazard") && playerCooldown == false)
        {
            Debug.Log(true);
            playerCooldown = true;
            StartCoroutine(DelayedSwitch());
        }
    }
    IEnumerator DelayedSwitch()
    {
        yield return new WaitForSeconds(playerCooldownTime);

        playerCooldown = false;
    }
}
