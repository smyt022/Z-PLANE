using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highScoreUIScript : MonoBehaviour
{

    public TextMeshProUGUI highScoreTxt;

    public int highScoreNum;

    // 
    void Start()
    {
        highScoreNum = GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().highScore;
        highScoreTxt.text = "high score: " + highScoreNum.ToString();
    }

}
