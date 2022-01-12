using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRootGame : MonoBehaviour
{
    [SerializeField]
    private Image testImage;

    public Text hpText;
    public Slider slider;
    public int hp;
    private int maxHp;

    void Awake()
    {
        GameSceneClass.gUiRootGame = this;
        hp = 1000;
        maxHp = hp;
    }

    private void Update()
    {
        hpText.text = string.Format("HP        {0}",hp);
        slider.value = (float)hp / (float)maxHp;
    }

    //private void Update() 
    //{
    //    if(Input.GetKeyDown(KeyCode.Space))
    //    {
    //        List<string> keyList = new List<string>(Global.spritesDic.Keys);
    //        int randomIdx = Random.Range(0, keyList.Count - 1);

    //        testImage.sprite = Global.spritesDic[keyList[randomIdx]];
    //        testImage.SetNativeSize();
    //    }
    //}

    public void TestFunc()
    {
        print("call UIRootGame");
    }
}
