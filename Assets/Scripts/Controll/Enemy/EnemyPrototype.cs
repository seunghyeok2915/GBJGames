using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype
{
    public abstract class EnemyPrototype
    {
        public abstract EnemyPrototype Clone();

        public abstract void Move();

        public abstract void Attack();
    }

}
