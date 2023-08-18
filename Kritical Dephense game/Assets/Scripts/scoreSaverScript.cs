using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //gotta check current scene

//THIS CLASS + GAME OBJECT IS SAVED for gameover scene (where score count needs to be accessed)
public class scoreSaverScript : MonoBehaviour
{
    public int savedScore;

    //loads on first frame
    private void Start()
    {
        DontDestroyOnLoad(gameObject);//saves this game object (for other scenes)
    }

    // Update is called once per frame
    void Update()
    {
        //update saved score while game is still playing (scene index 1)
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            savedScore = GameObject.FindGameObjectWithTag("scoreObject").GetComponent<ScoreScript>().scoreCount;
        }
    }
}
