using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotManager : MonoBehaviour
{
    PlayerManager player;
    float speed = 5f;
    int at = 1;
    public GameObject impactPrefab;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NewEnemy")
        {
            NewEnemyManager enemy = collision.gameObject.GetComponent<NewEnemyManager>();
            enemy.OnDamage(at);
            Instantiate(impactPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
