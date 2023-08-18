using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveProgressScript : MonoBehaviour
{
    private GameObject saveDataObject;

    private void Start()
    {
        //assign saveDataObject to "dataObject" variable, for quick refrence
        saveDataObject = GameObject.FindGameObjectWithTag("saveDataObject");
    }

    //on click, save all the saveData locally (using playerPrefs)
    public void saveAllData()
    {
        //save the high score
        PlayerPrefs.SetInt("highScore", saveDataObject.GetComponent<saveDataScript>().highScore);

        //saving what was purchased (1 for true, 0 for false)
        PlayerPrefs.SetInt("skinOnePurchased", saveDataObject.GetComponent<saveDataScript>().skinOnePurchased ? 1 : 0);
        PlayerPrefs.SetInt("skinTwoPurchased", saveDataObject.GetComponent<saveDataScript>().skinTwoPurchased ? 1 : 0);
        PlayerPrefs.SetInt("bannerOnePurchased", saveDataObject.GetComponent<saveDataScript>().bannerOnePurchased ? 1 : 0);
        PlayerPrefs.SetInt("bannerTwoPurchased", saveDataObject.GetComponent<saveDataScript>().bannerTwoPurchased ? 1 : 0);
        PlayerPrefs.SetInt("bannerThreePurchased", saveDataObject.GetComponent<saveDataScript>().bannerThreePurchased ? 1 : 0);

        //saving what was equiped (1 for true, 0 for false)
        PlayerPrefs.SetInt("skinZeroEquiped", saveDataObject.GetComponent<saveDataScript>().skinZeroEquiped ? 1 : 0);
        PlayerPrefs.SetInt("skinOneEquiped", saveDataObject.GetComponent<saveDataScript>().skinOneEquiped ? 1 : 0);
        PlayerPrefs.SetInt("skinTwoEquiped", saveDataObject.GetComponent<saveDataScript>().skinTwoEquiped ? 1 : 0);
        PlayerPrefs.SetInt("bannerOneEquiped", saveDataObject.GetComponent<saveDataScript>().bannerOneEquiped ? 1 : 0);
        PlayerPrefs.SetInt("bannerTwoEquiped", saveDataObject.GetComponent<saveDataScript>().bannerTwoEquiped ? 1 : 0);
        PlayerPrefs.SetInt("bannerThreeEquiped", saveDataObject.GetComponent<saveDataScript>().bannerThreeEquiped ? 1 : 0);
        //save
        PlayerPrefs.Save();
    }
}
