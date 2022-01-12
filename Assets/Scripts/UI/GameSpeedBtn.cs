using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSpeedBtn : MonoBehaviour
{
    private int gameSpeed;
    public Text gameSpeedTxt;
    public Button gameSpeedBtn;
  

    private bool fire = false;

    private void Awake()
    {
        gameSpeedBtn.onClick.AddListener(() => UpSpeed());
    }

    public void UpSpeed()
    {
       if(!fire)
        {
            Time.timeScale = 2f; 
            fire = true;
        }
       else
        {
            Time.timeScale = 1f;
            fire = false;
        }
        gameSpeedTxt.text = string.Format("X{0}", Time.timeScale);


    }
}
