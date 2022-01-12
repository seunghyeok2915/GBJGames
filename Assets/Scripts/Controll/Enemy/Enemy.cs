using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    public int hp;
    private int maxHp = 10;
    public int speed = 3;
    //public EnemyHPBar hpBar;
    public Vector3 offset;

    private CONEnemyHPBar hpBar;

    public int attackDamage = 10;
    public int attackDelay = 1;
    private float attackTimer = 0;

    private void Start()
    {
        
        hp = 5;
        maxHp = hp;

    }

    private void OnEnable()
    {
       
    }

    public void Init()
    {
        CONEntity hpBarCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.EnemyHPBar, new Vector2(25, 0));
        hpBar = hpBarCon.GetComponent<CONEnemyHPBar>();
        hpBar.SetParent();

        hpBar.Reset(ScreenTransform(offset), 1);
    }

    public Vector3 ScreenTransform(Vector3 Correction)
    {
        Vector3 pos = GameSceneClass.mCam.WorldToScreenPoint(transform.position + Correction);
        return pos;
    }

    private void Update()
    {

        if (transform.position.x < -11)
        {
            //공격
            Attack();
        }
        else
        {
            Move();

        }

        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }

        hpBar.SetValue(hp ,maxHp);
        hpBar.SetPosition(ScreenTransform(offset));

    }


    public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void Attack()
    {
        if (Time.time > attackTimer)
        {
            //공격
            //tower.AddDamage(attackDamage);
            FindObjectOfType<UIRootGame>().hp -= 10;
            attackTimer = Time.time + attackDelay;
        }
    }
}

