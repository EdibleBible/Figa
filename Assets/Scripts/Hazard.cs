using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int hazardDamage;
    public bool isBullet;
    public GameObject parent;
    public int hazardHealth;
    [SerializeField] GameObject particleSystemPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            hazardHealth -= other.gameObject.GetComponent<Bullet>().bulletDamage;
            Destroy(other.gameObject);
            if (hazardHealth < 1)
            {
                GameObject particleObject = Instantiate(particleSystemPrefab, transform);
                Destroy(parent);
            }
        }
    }
}
