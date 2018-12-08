using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ShermanLibr.ScoreSystem.Inicial();
        UIManager.instance.maxScore.text = ShermanLibr.ScoreSystem.MaxScore.ToString();
	}
	
	
	void Update () {
        UIManager.instance.score.text = ShermanLibr.ScoreSystem.Score.ToString();
    }
}
