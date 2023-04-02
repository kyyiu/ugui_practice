using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour
{
    public GameObject on;
    public GameObject off;
    private Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        // ����Ĭ��ֵ
        toggle = GetComponent<Toggle>();
        OnValueChange(toggle.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChange(bool isOn)
    {
        on.SetActive(isOn);
        off.SetActive(!isOn);
    }
}
