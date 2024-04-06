using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHeal : MonoBehaviour
{

    [SerializeField] private HealthController healthController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HP"))
        {
            healthController.ChangePlayerHP(2);
            Destroy(other.gameObject);
        }
    }
}
