using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heros : MonoBehaviour
{
    public float attackDelay = 0.2f;
    private float attackTimer = 0;
    public int radius;


    private void Start()
    {
        StartCoroutine(Shot());
    }

    private IEnumerator Shot()
    {
        while(true)
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, radius, LayerMask.NameToLayer("Enemy"));
            if (collider != null )
            {
                Enemy enemy = collider.GetComponent<Enemy>();
                enemy.hp -= 1;
            }
            yield return new WaitForSeconds(0.2f);
       
        yield return null;
        }
    }

    void OnDrawGizmos()
    {
       

        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
