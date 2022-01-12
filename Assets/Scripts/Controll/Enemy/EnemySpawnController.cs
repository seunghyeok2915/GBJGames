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
            // ���ϴ� ���͸� �����ϰ�, ���� �ϰ� �ض�
            if (Input.GetKeyDown(KeyCode.Space))
            {
                EnemySpawner enemySpawner = new EnemySpawner(enemy);
                Enemy newEnemy = enemySpawner.SpawnMonster() as Enemy;
                newEnemy.Move();
                newEnemy.Attack();
            }

            //// �������� ���͸� �����ϰ�, ���� �ϰ� �ض�.
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    Spawner randomSpawner = monsterSpawners[Random.Range(0, monsterSpawners.Length)];
            //    Monster randomMonster = randomSpawner.SpawnMonster();
            //    randomMonster.Talk();
            //}
        }





    }
}
