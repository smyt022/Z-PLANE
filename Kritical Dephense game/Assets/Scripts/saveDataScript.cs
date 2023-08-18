using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveDataScript : MonoBehaviour
{
    //data that will be saved locally (even when game is closed)(saved throughout and after the game) ------------

    //purchases
    public bool skinOnePurchased = false;
    public bool skinTwoPurchased = false;
    public bool bannerOnePurchased = false;
    public bool bannerTwoPurchased = false;
    public bool bannerThreePurchased = false;

    //equiped items
    public bool skinZeroEquiped = true;
    public bool skinOneEquiped = false;
    public bool skinTwoEquiped = false;
    public bool bannerOneEquiped = false;
    public bool bannerTwoEquiped = false;
    public bool bannerThreeEquiped = false;

    //high score
    public int highScore = 0;

    //keeping track of menu music (so we dont accidently have multiple playing)
    public bool menuMusicOn = false;



    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);//saves this game object (for other scenes)

        //later on, make this class load saveData playerPrefs (if anything was previously saved) -------- !!

        //check if a high score was previously saved locally (if it has a high score saved, everything else was saved aswell)
        if (PlayerPrefs.HasKey("highScore"))
        {
            //set the locally saved high score
            highScore = PlayerPrefs.GetInt("highScore");

            //upload the locally saved purchase statuses (1->true, 0->false)
            skinOnePurchased = PlayerPrefs.GetInt("skinOnePurchased") == 1 ? true : false;
            skinTwoPurchased = PlayerPrefs.GetInt("skinTwoPurchased") == 1 ? true : false;
            bannerOnePurchased = PlayerPrefs.GetInt("bannerOnePurchased") == 1 ? true : false;
            bannerTwoPurchased = PlayerPrefs.GetInt("bannerTwoPurchased") == 1 ? true : false;
            bannerThreePurchased = PlayerPrefs.GetInt("bannerThreePurchased") == 1 ? true : false;

            //upload the locally saved equip statuses (1->true, 0->false)
            skinZeroEquiped = PlayerPrefs.GetInt("skinZeroEquiped") == 1 ? true : false;
            skinOneEquiped = PlayerPrefs.GetInt("skinOneEquiped") == 1 ? true : false;
            skinTwoEquiped = PlayerPrefs.GetInt("skinTwoEquiped") == 1 ? true : false;
            bannerOneEquiped = PlayerPrefs.GetInt("bannerOneEquiped") == 1 ? true : false;
            bannerTwoEquiped = PlayerPrefs.GetInt("bannerTwoEquiped") == 1 ? true : false;
            bannerThreeEquiped = PlayerPrefs.GetInt("bannerThreeEquiped") == 1 ? true : false;
        }

        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
