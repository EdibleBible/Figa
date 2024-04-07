using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction = Vector3.left;
    public float speed = 2f;
    public int bulletDamage;

    void Update()
    {
        Vector3 movement = direction.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
