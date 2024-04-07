using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] public int playerNumber;
    [SerializeField] SO_PlayerAttributes playerAttributes;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float shotInterval;
    [SerializeField] private float shotIntervalLeft;

    private void Start()
    {
        if (playerNumber == 1)
        {
            shotInterval = playerAttributes.player1ShotInterval;
        } else
        {
            shotInterval = playerAttributes.player2ShotInterval;
        }
        shotIntervalLeft = shotInterval;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && shotIntervalLeft == 0)
        {

            GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform);
            newBullet.transform.SetParent(null);
            Bullet bulletComponent = newBullet.GetComponent<Bullet>();
            bulletComponent.direction = transform.right;
            switch (playerNumber)
            {
                case 1:
                    bulletComponent.speed = playerAttributes.player1ShotSpeed;
                    bulletComponent.bulletDamage = playerAttributes.player1Damage;
                    break;
                case 2:
                    bulletComponent.speed = playerAttributes.player2ShotSpeed;
                    bulletComponent.bulletDamage = playerAttributes.player2Damage;
                    break;
            }
            shotIntervalLeft = shotInterval;
        } else
        {
            shotIntervalLeft -= Time.deltaTime;
        }
    }
}
