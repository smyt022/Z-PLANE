using System.Collections;
using System.Collections.Generic;
using TMPro;    //need to import this to use textmesh pro
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int scoreCount=0;//score count
    public TextMeshProUGUI scoreText;//text UI component (that we will manipulate)
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: "+scoreCount.ToString();//set the UI text to the score count (but turn int to string)

    }
}
