using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public GameObject arrow;
  

    public void shot()
    {
       // CONEntity enemyCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.Arrow,transform.position);

        Instantiate(arrow, transform.position, Quaternion.identity);
    }
}
