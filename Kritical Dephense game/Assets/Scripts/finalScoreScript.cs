using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class finalScoreScript : MonoBehaviour
{

    public TextMeshProUGUI finalScoreText;//link to UI in game over scene (in unity)
    

    private int finalScore;//score count from the game Scene (integer)


    private void Update()
    {
        finalScore = GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore;
        //set UI text
        finalScoreText.text = "points: " + finalScore.ToString();

        //this is in the update method incase user buys a skin and points are to be decreased
    }



}
