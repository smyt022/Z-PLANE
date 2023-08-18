using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusicScript : MonoBehaviour
{

    /*this is used so that music audio objects dont get destroyed,
     */

    // Start is called before the first frame update
    void Awake()
    {
        // this object shouldn't be destoryed by default
        DontDestroyOnLoad(gameObject);

        //for menuMusic, this will be destoryed for the play scene (in the playSceneSwitch script)
        //for gameplayMusic, this will be destoryed in gameOverScene (enemyScript ->collision with player)

        //but if another menuMusic is CURRENTLY PLAYING (&& in a menuMusic scene, ex.gameOver (not gameScene)), destory this object
        if (GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().menuMusicOn
            && SceneManager.GetActiveScene().buildIndex != 1)
        {
            Destroy(gameObject); //this game object destorys itself
        } else if (SceneManager.GetActiveScene().buildIndex != 1)//if this is the right scene,
        {
            GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().menuMusicOn = true;
        }
        

        //if your in the gameScene, no menuMusic is playing anymore
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().menuMusicOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
