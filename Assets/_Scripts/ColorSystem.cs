using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColorSystem : MonoBehaviour {

    public static ColorSystem instance;

    public Image MainBlock;
    public byte Procent;
    public Block[] blocks;
    public Animation finsih;
    public GameObject finishPanel;

    [Space]
    public GameObject On;
    public GameObject Off;

    [HideInInspector]
    public int NumBlock;

    [HideInInspector]
    public byte p;

   // [HideInInspector]
    public bool loose;
    [HideInInspector]
    public bool flag;

    private void Awake()
    {
        instance = this;
        Procent++;
        UpdateColor();

        
        
    }

    private void Start()
    {
        if (MusicSystem.Instance.background.mute == true)
        {
            On.SetActive(false);
            Off.SetActive(true);
        }
        else
        {
            On.SetActive(true);
            Off.SetActive(false);
        }
    }

    private void Update()
    {
        if (loose)
        {
            finishPanel.SetActive(true);
            if (Ad.instance.countAd > 2)
                UIManager.instance.playAd.SetActive(false);
            if (!flag)
            {
                finsih.Play("ScoreFinish");
                flag = true;
            }
           
        }
            
    }

    public void UpdateColor()
    {
        Procent--;
        if(Procent<=1)
        {
            Procent = 1;
        }
        NumBlock = Random.Range(0, 4);
        p = (byte)(255 / 100 * Procent);
        MainBlock.color = RandomColor();
    }

    public Color32 RandomColor()
    {
        Color32 randColor = new Color32();
        randColor.r = (byte)Random.Range(p, -p+255);
        randColor.g = (byte)Random.Range(p, -p+255);
        randColor.b = (byte)Random.Range(p, -p+255);
        randColor.a = 255;
        return randColor;
    }

    public Color32 PohozhColor(Color32 inputColor, byte procent = 10)
    {
        Color32 color = new Color32(0, 0, 0, 255);

        color.r = (byte)(inputColor.r+Random.Range(-p, p));

        color.g = (byte)((inputColor.g - 0) + Random.Range(-p/2, p/2));
        color.b = (byte)((inputColor.b - 0) + Random.Range(-p / 2, p / 2));

        return color;
    }

    public void CheckColor(int NumBlock)
    {
        if(!loose)
        {
            StopwatchSystem.instance.UpdateTimer();

            StartCoroutine(StopwatchSystem.timer.TimerStart(StopwatchSystem.instance.time));
            if (NumBlock == this.NumBlock)
            {
                MusicSystem.Instance.choose.Play();
                ShermanLibr.ScoreSystem.PlusScore();
                UpdateColor();
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i].UpdateBlock();
                }
            }
            else loose = true;
        }
        
    }

    public void Loose()
    {
        if (!loose)
            return;
        ShermanLibr.ScoreSystem.UpdateMaxScore();
        ShermanLibr.ScoreSystem.Save();
        SceneManager.LoadScene(0);
    }

    public void MusicOnOff()
    {
        if (On.activeSelf)
        {
            On.SetActive(false);
            Off.SetActive(true);
            MusicSystem.Instance.background.mute=true;
            MusicSystem.Instance.choose.mute = true;
        }
        else
        {
            On.SetActive(true);
            Off.SetActive(false);
            MusicSystem.Instance.background.mute = false;
            MusicSystem.Instance.choose.mute = false;
        }
    }
}
