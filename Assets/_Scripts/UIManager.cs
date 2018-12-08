using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public TextMeshProUGUI score;
    public TextMeshProUGUI maxScore;
    public TextMeshProUGUI time;

    void Awake () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
