using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public float playerCooldownTime = 3f;
    public bool playerCooldown = false;
    [SerializeField] private HealthController healthController;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hazard") && playerCooldown == false)
        {
            int hpChange = other.gameObject.GetComponent<Hazard>().hazardDamage;
            healthController.ChangePlayerHP(-hpChange);
            playerCooldown = true;
            if (other.GetComponent<Hazard>().isBullet)
            {
                Destroy(other.gameObject.GetComponent<Hazard>().parent);
            }
            StartCoroutine(DelayedSwitch());
        }
    }

    IEnumerator DelayedSwitch()
    {
        yield return new WaitForSeconds(playerCooldownTime);

        playerCooldown = false;
    }
}
