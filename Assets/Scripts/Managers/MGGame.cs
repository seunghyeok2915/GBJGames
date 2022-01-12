using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGGame : MonoBehaviour
{
    // public MGTeam _gTeamManager;
    // public MGStage _gStageManager;
    // public MGMinion _gMinionManager;
    // public MGHero.MGHero _gHeroManager;

    List<CONEntity> enemyConList = new List<CONEntity>();

    void Awake()
    {
        GameSceneClass.gMGGame = this;

        // GameSceneClass._gColManager = new MGUCCollider2D();

        // _gTeamManager = new MGTeam();
        // _gStageManager = new MGStage();
        // _gMinionManager = new MGMinion();
        // _gHeroManager = new MGHero.MGHero();

        // Global._gameStat = eGameStatus.Playing;

        GameObject.Instantiate(Global.prefabsDic[ePrefabs.MainCamera]);

        enemyConList.Clear();
    }

    void OnEnable()
    {
        // GamePlayData.init();
        // MGGameStatistics.instance.initData();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CONEntity enemyCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.Enemy,new Vector2(25,Random.Range(-1,4)));
            enemyConList.Add(enemyCon);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (enemyConList.Count > 0)
            {
                enemyConList[enemyConList.Count - 1].SetActive(false);
                enemyConList.RemoveAt(enemyConList.Count - 1);
            }

        }



        // if (Global._gameStat == eGameStatus.Playing)
        // {
        //     if (Global._gameMode == eGameMode.Collect)
        //     {
        //         _gStageManager.UpdateCollect();
        //         _gMinionManager.UpdateCollect();
        //     }
        //     else if(Global._gameMode == eGameMode.Adventure)
        //     {
        //         _gStageManager.UpdateAdventure();
        //         _gMinionManager.UpdateAdventure();
        //         _gHeroManager.UpdateAdventure();
        //     }
        // }
    }

    void LateUpdate()
    {
        // GameSceneClass._gColManager.LateUpdate();
    }
}
