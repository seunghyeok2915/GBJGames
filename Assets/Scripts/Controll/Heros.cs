using System.Collections;
using System.Linq;
using UnityEngine;

public class Heros : MonoBehaviour
{
    public float attackDelay = 0.2f;
    private float attackTimer = 0;
    public int radius;
    public int power = 2;


    private void Start()
    {
        StartCoroutine(Shot());
    }

    private IEnumerator Shot()
    {
        while (true)
        {
            OnClickScreen();
            yield return new WaitForSeconds(0.2f);

            yield return null;
        }
    }

    public void OnClickScreen()
    {
        if (GameSceneClass.enemySpawner.Monsters.Count != 0)
        {
            GameSceneClass.enemySpawner.Monsters.OrderBy(go => go.transform.position);
            var enemy = GameSceneClass.enemySpawner.Monsters.First().GetComponent<Enemy>();
            if(Mathf.Abs(enemy.transform.position.x - transform.position.x) <= radius)
            {
                enemy.GetDamage(power);
            }
            
        }

    }

    void OnDrawGizmos()
    {


        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
