using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{

    public class Enemy : MonoBehaviour
    {
        public int hp;
        private int maxHp = 100;
        public int speed = 3;
        //public EnemyHPBar hpBar;
        public Vector3 offset;

        private CONEnemyHPBar hpBar;

        public int attackDamage = 10;
        public int attackDelay = 1;
        private float attackTimer = 0;

        private void OnEnable()
        {
            hp = maxHp;

            //hp 바생성
            CONEntity hpBarCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.EnemyHPBar, Vector3.zero);
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

            if (transform.position.x < -13)
            {
                //공격
                Attack();
            }
            else
            {
            Move();

            }

            hpBar.SetValue((float)hp / maxHp);
            hpBar.SetPosition(ScreenTransform(offset));

        }


        public void Move()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        public void Attack()
        {
            if(Time.time > attackTimer)
            {
                //공격
                //tower.AddDamage(attackDamage);
                attackTimer = Time.time + attackDelay;
            }
        }
    }
}
