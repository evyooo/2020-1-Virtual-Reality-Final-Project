using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    private Text scoreText;
    public string LevelToLoad;

    // Start is called before the first frame update
    void Start()
    {
		scoreText = GetComponent<Text> ();

    }

     // Update is called once per frame
    void Update () 
    {
        scoreText.text = "ITEM FOUND " + GlobalVariable.score.ToString("f0") + "/10";
        
        if (GlobalVariable.score >= 10){
            Application.LoadLevel (LevelToLoad);

        }

	}
    
}
