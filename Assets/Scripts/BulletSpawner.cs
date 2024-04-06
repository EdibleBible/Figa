using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletInterval = 3f;
    [SerializeField] private float bulletSpeed = 1f;
    [SerializeField] private Vector3 bulletDirection = Vector3.left;

    void Start()
    {
        StartCoroutine(RunFunctionEveryFiveSeconds());
    }

    IEnumerator RunFunctionEveryFiveSeconds()
    {
        while (true)
        {
            YourFunction();
            yield return new WaitForSeconds(bulletInterval);
        }
    }

    void YourFunction()
    {
        GameObject newBullet = Instantiate(bulletPrefab, transform);
        newBullet.transform.SetParent(null);
        Bullet bulletComponent = newBullet.GetComponent<Bullet>();
        bulletComponent.speed = bulletSpeed;
        bulletComponent.direction = bulletDirection;
    }
}
