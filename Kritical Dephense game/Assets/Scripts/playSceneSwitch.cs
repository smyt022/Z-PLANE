using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playSceneSwitch : MonoBehaviour
{
    // when "play" button is pressed in main menu
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//loads the scene with the index before this scene's index
        //the scene with the game was made before the main menu scene

        //destory all the menuMusic objects that exist
        GameObject[] menuMusicObjects = GameObject.FindGameObjectsWithTag("menuMusicObject");
        for(int i=0; i < menuMusicObjects.Length; i++)
        {
            Destroy(menuMusicObjects[i]);
        }
    }

    //when "equip" button is pressed in main menu
    public void enterEquipScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        //goes from main menu scene to equip scene
    }

    //when "exit" button is pressed in the equip scene
    public void exitEquipScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        //goes from the equip scene to main menu scene
    }

    public void enterCreditsScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        //goes from main menu scene to credits scene
    }

    public void exitCreditsScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        //goes from the credits scene to main menu scene
    }
}
