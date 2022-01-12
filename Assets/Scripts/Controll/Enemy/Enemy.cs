using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{

    public class Enemy : EnemyPrototype
    {
        public int hp;
        public int speed;


        public Enemy(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;

        }

        public override EnemyPrototype Clone()
        {
            return new Enemy(hp, speed);
        }


        public override void Move()
        {

        }

        public override void Attack()
        {

        }
    }
}
