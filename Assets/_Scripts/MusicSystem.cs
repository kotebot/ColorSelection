using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSystem : MonoBehaviour {

    

    private static MusicSystem _instance;



    public static MusicSystem Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }

            // Do not modify _instance here. It will be assigned in awake
            return new GameObject("(singleton) SoundManager").AddComponent<MusicSystem>();
        }
    }

    public AudioSource background;
    public AudioSource choose;

    void Awake()
    {
        // Only one instance of SoundManager at a time!
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    
}
