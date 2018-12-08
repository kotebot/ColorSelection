using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ShermanLibr;

public class Block : MonoBehaviour {

    [SerializeField]
    private int NumBlock;

    private Image MyColor;
    

    private void Start()
    {
        MyColor = GetComponent<Image>();
        UpdateBlock();
    }

    

    public void UpdateBlock()
    {
        if (NumBlock == ColorSystem.instance.NumBlock)
        {
            MyColor.color = ColorSystem.instance.MainBlock.color;
            // Debug.Log("!!!");
        }
        else
        {
            MyColor.color = ColorSystem.instance.PohozhColor(ColorSystem.instance.MainBlock.color, 25);
            //Debug.Log("???");
        }
    }
}
