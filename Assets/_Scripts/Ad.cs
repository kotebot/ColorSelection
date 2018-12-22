using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ad : MonoBehaviour {

    public static Ad instance;

    private const string gameID = "2964321";
    public static int countReload = 0;
    private bool flag=true;
    [HideInInspector]
    public ushort countAd=0;

    private void Awake()
    {
        instance = this;    
    }

    void Start () {
        countReload++;
        Advertisement.Initialize(gameID,false);
        if(countReload==5)
        {
            Advertisement.Show("dead");
            countReload = 0;
        }
            
	}
	
    public void ReloadLvl()
    {
        if(ColorSystem.instance.finishPanel.activeSelf&&countAd<3)
        {
            countAd++;
            StopwatchSystem.instance.UpdateTimer();
            StartCoroutine(StopwatchSystem.timer.TimerStart(120));
            Advertisement.Show("rewardedVideo");
            StartCoroutine(timeStop());
            ColorSystem.instance.finsih.Play("Reload");
            ColorSystem.instance.UpdateColor();
            for (int i = 0; i < ColorSystem.instance.blocks.Length; i++)
            {
                ColorSystem.instance.blocks[i].UpdateBlock();
            }
            ColorSystem.instance.flag = false;
            ColorSystem.instance.loose = false;
            ColorSystem.instance.finishPanel.SetActive(false);
            
            
        }
    }
    IEnumerator timeStop()
    {
        while (Advertisement.isShowing)
        {
            yield return new WaitForSeconds(0.05f);
        }
        StopwatchSystem.instance.UpdateTimer();
        StartCoroutine(StopwatchSystem.timer.TimerStart(StopwatchSystem.instance.time));
    }

}
