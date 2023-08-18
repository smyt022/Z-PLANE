using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueSceneSwitch : MonoBehaviour //switches scenes from game over scene to other scenes
{
    public void returnToMain()//returning player to main menu
    {
        //called to go from game over scene to main menu scene (check build indexes)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);


        //reset saved score
        GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore = 0;

    }
    
    public void goToShop()
    {
        //called to go from game over scene to shop scene (3rd scene in build to 4th)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void leaveShop()//returning player to gameOver screen (from shop)
    {
        //(from 4rd scene in build to 3rd) (shop to gameOver)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}