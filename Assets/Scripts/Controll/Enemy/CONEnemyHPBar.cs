using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONEnemyHPBar : CONEntity
{

    public float reduceFactor = 4f;
    private Slider slider;
    private RectTransform rTr;


    private Coroutine co = null;
    public override  void Awake()
    {
        base.Awake();
        slider = GetComponent<Slider>();
        rTr = GetComponent<RectTransform>();
    }

    public void SetValue(float value)
    {
        if (co != null)
        {
            StopCoroutine(co);
        }
        co = StartCoroutine(DamageReduce(value));

    }

    public override void OnEnable()
    {
        base.OnEnable();
        transform.SetParent(GameSceneClass.gUiRoot.transform, false);
    }

    public override void OnDisable()
    {
        base.OnDisable();

        StopAllCoroutines();
    }



    IEnumerator DamageReduce(float value)
    {
        while (true)
        {
            slider.value = value; //Mathf.Lerp(slider.value, value,  reduceFactor);
            if (Mathf.Abs(slider.value - value) < 0.1f)
            {
                yield break; // ����
            }
            yield return null; // null ��ȯ
        }
    }


    public void Reset(Vector3 pos, float value) // �����̴� ��ġ ����
    {
        rTr.position = pos;
        slider.value = value;
    }

  

}