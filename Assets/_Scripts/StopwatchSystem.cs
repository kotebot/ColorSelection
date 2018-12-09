
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShermanLibr;

public class StopwatchSystem : MonoBehaviour
{

    public static StopwatchSystem instance;
    public int time = 10;
    [HideInInspector]
    public static ShermanLibr.Time timer;

    void Start()
    {
        instance = this;
        timer = (new GameObject("timer")).AddComponent<ShermanLibr.Time>();
        StartCoroutine(timer.TimerStart(10));
    }

    public void UpdateTimer()
    {
        Destroy(GameObject.Find("timer"));
        timer = (new GameObject("timer")).AddComponent<ShermanLibr.Time>();

    }

    private void Update()
    {
        if (!ColorSystem.instance.loose)
            UIManager.instance.time.text = timer.ToStringTimer();
        if (timer.TimerF < 4)
            UIManager.instance.time.color = new Color32(212, 65, 65, 255);
        else UIManager.instance.time.color = new Color32(226, 199, 199, 255);

        if (!timer.Timer)
        {
            ColorSystem.instance.loose = true;
            ColorSystem.instance.Loose();
        }

    }

}