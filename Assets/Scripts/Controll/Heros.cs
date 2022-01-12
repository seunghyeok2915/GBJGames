using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heros : MonoBehaviour
{
    public float attackDelay = 0.2f;
    private float attackTimer = 0;

  
    private void Update()
    {
        if (Time.time > attackTimer)
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, 5, LayerMask.NameToLayer("Enemy"));
            if (collider != null)
            {
                Enemy enemy = collider.GetComponent<Enemy>();
                enemy.hp -= 1;
            }
            attackTimer = Time.time + attackDelay;
        }
    }

   
}
