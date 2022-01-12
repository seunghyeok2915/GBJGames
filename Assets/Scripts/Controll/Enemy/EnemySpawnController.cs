using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class EnemySpawnController : MonoBehaviour
    {
        private Enemy enemy;

        private EnemySpawner[] enemySpawners;



        private void Start()
        {
            enemy = new Enemy(100, 10);

            enemySpawners = new EnemySpawner[]
            {
                new EnemySpawner(enemy)
            };
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnemySpawner enemySpawner = new EnemySpawner(enemy);
                Enemy newEnemy = enemySpawner.SpawnMonster() as Enemy;
                    
                newEnemy.Move();
                newEnemy.Attack();
            }

        }



        //public IEnumerator CreateEnemy()
        //{

        //}





    }
}
