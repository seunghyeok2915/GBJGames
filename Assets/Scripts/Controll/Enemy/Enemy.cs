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

        private void OnEnable()
        {
            hp = maxHp;

            //hp �ٻ���
            CONEntity hpBarCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.EnemyHPBar,new Vector2(25,0));
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
            Move();

            hpBar.SetValue((float)hp / maxHp);
            hpBar.SetPosition(ScreenTransform(offset));
        }


        public void Move()
        {

            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        public void Attack()
        {

        }
    }
}
