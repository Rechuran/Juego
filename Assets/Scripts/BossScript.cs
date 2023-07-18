using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public Transform target;
    public GameObject bulletPrefab;
    public float bulletSpeed = 5f;
    public float attackInterval = 3f;
    public int minBullets = 1;
    public int maxBullets = 5;
    public float timeBetweenBullets = 0.2f;

    private float attackTimer;

    void Update()
    {
        attackTimer += Time.deltaTime;
        if (attackTimer >= attackInterval)
        {
            Attack();
            attackTimer = 0f;
        }
    }

    void Attack()
    {
        int bulletCount = Random.Range(minBullets, maxBullets + 1);
        StartCoroutine(FireBullets(bulletCount));
    }

    IEnumerator FireBullets(int bulletCount)
    {
        for (int i = 0; i < bulletCount; i++)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x);
            float velocityX = bulletSpeed * Mathf.Cos(angle);
            float velocityY = bulletSpeed * Mathf.Sin(angle);

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);

            yield return new WaitForSeconds(timeBetweenBullets);
        }
    }
}

