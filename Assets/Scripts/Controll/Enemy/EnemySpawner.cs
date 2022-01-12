using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public class EnemySpawner
    {
        private EnemyPrototype monster;

        public EnemySpawner(EnemyPrototype entity)
        {
            this.monster = entity;
        }

        public EnemyPrototype SpawnMonster()
        {
            return monster.Clone();
        }

    }

}
