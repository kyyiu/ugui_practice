using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_J : MonoBehaviour
{
    // cd效果
    public float coldTime = 2;
    private float timer = 0;
    private bool isColding = false;
    private Image cdMask;
    
    // Start is called before the first frame update
    void Start()
    {
        // transform.Find("CdMask")获取子组件
        cdMask = transform.Find("CdMask").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        checkCommon();
        checkBtnClick();
    }

    public void checkCommon()
    {
        if (isColding)
        {
            timer += Time.deltaTime;
            cdMask.fillAmount = (coldTime - timer) / coldTime;
            if (timer > coldTime)
            {
                isColding = false;
                cdMask.fillAmount = 0;
                timer = 0;
            }
        }
    }

    public void checkBtnClick()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Handle_J();
        }
    }

    public void Handle_J()
    {
        if (!isColding)
        {
            isColding = true;
            timer = 0;
            cdMask.fillAmount = 1;
        }
    }

    public void OnSkillClick()
    {
        Handle_J();
    }
}

public class KeyDownEvent
{
    static public void exe(KeyCode k)
    {
        //if (t.GetMethod(name) != null)
        //{
        //    Debug.Log("AA");
        //    t.GetMethod(name).Invoke(null, new object[] { });
        //}
    }
    private void OnClick_J()
    {
        Debug.Log("按了j");
    }
}