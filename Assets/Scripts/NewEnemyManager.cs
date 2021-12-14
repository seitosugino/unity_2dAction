using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyManager : MonoBehaviour
{
    Animator animator;
    public int hp = 3;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void OnDamage(int damage)
    {
        animator.SetTrigger("IsHit");
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        hp = 0;
        Destroy(this.gameObject);
    }
}
