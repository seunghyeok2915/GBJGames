using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{

    public class Enemy : EnemyPrototype
    {
        public int hp;
        private int maxHp = 100;
        public int speed = 3;
        //public EnemyHPBar hpBar;
        public Vector3 offset;



        public Enemy(int hp, int speed)
        {
            this.maxHp = hp;
            this.speed = speed;

        }

        public override EnemyPrototype Clone()
        {
            return new Enemy(hp, speed);
        }

        private void OnEnable()
        {
            hp = maxHp;
          //  hpBar.Reset(ScreenTransform(offset), 1);
          
        }

        //public Vector3 ScreenTransform(Vector3 Correction)
        //{
        //    Vector3 pos = Camera.main.WorldToScreenPoint(transform.position + Correction);
        //    return pos;
        //}

        private void Update()
        {
            Move();

            //hpBar.SetValue(hp / maxHp);
            //hpBar.SetPosition(ScreenTransform(offset));
        }


        public override void Move()
        {

            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        public override void Attack()
        {

        }
    }
}
