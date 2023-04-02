using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Scroll : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    private ScrollRect scroll;
    private float[] pagePosition = new float[4] { 0, 0.33f, 0.66f, 1 };
    private float targetPosition = 0;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        //¹ý¶É¶¯»­
        if (isMoving)
        {
            scroll.horizontalNormalizedPosition = Mathf.Lerp(scroll.horizontalNormalizedPosition, targetPosition, Time.deltaTime);
            if (Mathf.Abs(scroll.horizontalNormalizedPosition-targetPosition) < 0.001f)
            {
                isMoving = false;
                scroll.horizontalNormalizedPosition = targetPosition;
            }
        }
       
    }

    public void OnValueChange()
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float cur = scroll.horizontalNormalizedPosition;
        int idx = 0;
        float offset = cur - pagePosition[0];
        for(int i = 1; i < 4; i++)
        {
            float f = Mathf.Abs(cur - pagePosition[i]);
            if (f < offset)
            {
                idx = i;
                offset = f;
            }
        }
        isMoving = true;
        targetPosition = pagePosition[idx];
    }
}
