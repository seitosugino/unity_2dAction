using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPoint : MonoBehaviour
{
    int at = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NewEnemy")
        {
            NewEnemyManager enemy = collision.gameObject.GetComponent<NewEnemyManager>();
            enemy.OnDamage(at);
        }
    }
}
