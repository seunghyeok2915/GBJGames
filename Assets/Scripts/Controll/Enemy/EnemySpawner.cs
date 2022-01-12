using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnYMax = 0f;
    public float spawnYMin = 0f;

    public float spawnDelay = 1f;

    private float timer = 5f;

    public bool canSpawnMonster = false;
    public bool isBoss = false;
    public int monsterCount = 0;
    private int stageLevel = 0;

    public List<CONEntity> Monsters = new List<CONEntity>();

    private void Update()
    {
        if (Time.time > timer)
        {
            if (Monsters.Count < 8 && monsterCount < 10)
            {
                if (canSpawnMonster == true)
                {
                    SpawnMonster();
                }
            }
            else if (Monsters.Count == 0 && monsterCount == 10)
            {
                if (stageLevel % 10 == 9 && !isBoss)
                {
                    SpawnBoss();
                }
                monsterCount = 0;
                stageLevel++;
            }
            timer = Time.time + spawnDelay;
        }
    }

    private void Awake()
    {
        GameSceneClass.enemySpawner = this;

    }
    private void Start()
    {
        StartGame();

    }

    public void SpawnMonster()
    {
        monsterCount++;

        CONEntity enemyCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.Enemy, new Vector3(23, Random.Range(spawnYMin, spawnYMax), 0));
        Enemy enemy = enemyCon.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.Init();
            //enemy.onDead = () =>
            //{
            //    Monsters.Remove(enemyCon);
            //};
        }
        Monsters.Add(enemyCon);


        //tempMonsterCs.hpSliderGO = temphpSlider;
    }

    public void SpawnBoss()
    {
        canSpawnMonster = false;
        isBoss = true;

        //_boss = Instantiate(boss, new Vector3(7, Random.Range(spawnYMin, spawnYMax), 0), Quaternion.identity).GetComponent<Boss>();
        //GameObject temphpSlider = Instantiate(hpSlider, _boss.transform.position, Quaternion.identity, GameObject.Find("Canvas").transform);
        //_boss.hpSliderGO = temphpSlider;
    }

    public void StartGame()
    {
        canSpawnMonster = true;
        monsterCount = 0;
        stageLevel = 1;
        //_player = Instantiate(player, playerSpawnPoint, Quaternion.identity);
    }
}
