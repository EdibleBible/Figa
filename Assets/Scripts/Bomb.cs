using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private int damageToPlayer = 1;
    [SerializeField] GameObject particleSystemPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            GameObject particleObject = Instantiate(particleSystemPrefab, transform);
            Destroy(gameObject);
        } else if (other.gameObject.CompareTag("Player"))
        {
            GameObject particleObject = Instantiate(particleSystemPrefab, transform);
            Destroy(gameObject);
            healthController.ChangePlayerHP(-damageToPlayer, other.gameObject);
        }
    }
}
