using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class EnemySpawnController : MonoBehaviour
    {
        public static EnemySpawnController instance = null;


        private List<CONEntity> enemyConList = new List<CONEntity>();
        public float spawnYMax = 0f;
        public float spawnYMin = 0f;
     
    



        private void Awake()
        {
            if (null == instance)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

            enemyConList.Clear();
        }

      

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                CreateEnemy();


            }

        }

        public void CreateEnemy()
        {
            CONEntity heroCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.Enemy, Random.insideUnitCircle);
            enemyConList.Add(heroCon);
        }

        public void RemoveEnemy()
        {
            if (enemyConList.Count > 0)
            {
                enemyConList[enemyConList.Count - 1].SetActive(false);
                enemyConList.RemoveAt(enemyConList.Count - 1);
            }
        }

        
      


        //public void SpawnEnemy()
        //{
        //    EnemySpawner enemySpawner = new EnemySpawner(enemy);
        //    Enemy newEnemy = enemySpawner.SpawnMonster() as Enemy;
        //    Instantiate(enemyObj, new Vector3(10, Random.Range(spawnYMin, spawnYMax), 0), Quaternion.identity);
        //    enemyList.Add(enemyObj);


       

        //}

     




    }
}
