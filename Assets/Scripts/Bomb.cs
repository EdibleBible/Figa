using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private int damageToPlayer = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            Destroy(gameObject);
        } else if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            healthController.ChangePlayerHP(-damageToPlayer, other.gameObject);
        }
    }
}
