using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipScript : MonoBehaviour
{
    //reset any previous equiped banners to false
    public void clearBanners()
    {
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOneEquiped = false;
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoEquiped = false;
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreeEquiped = false;
    }

    //reset any previously equiped skins to false
    public void clearSkins()
    {
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinZeroEquiped = false;
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinOneEquiped = false;
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoEquiped = false;
    }

    //banner 1 equip button is pressed
    public void equipBanOne()
    {
        //check if the banner was purchased (unlocked)
        if (GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOnePurchased)
        {
            //clear any previously equiped banners
            clearBanners();

            //equip banner one
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOneEquiped = true;
        }
        else
        {
            //make button red (warns user that they have'nt purchased it)
        }
    }

    //banner 2 equip button is pressed
    public void equipBanTwo()
    {
        //check if the banner was purchased (unlocked)
        if (GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoPurchased)
        {
            //clear any previously equiped banners
            clearBanners();

            //equip banner one
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoEquiped = true;
        }
        else
        {
            //make button red (warns user that they have'nt purchased it)
        }
    }

    public void equipBanThree()
    {
        //check if the banner was purchased (unlocked)
        if (GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreePurchased)
        {
            //clear any previously equiped banners
            clearBanners();

            //equip banner one
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreeEquiped = true;
        }
        else
        {
            //make button red (warns user that they have'nt purchased it)
        }
    }


    public void equipSkinZero()
    {
        //no checks for purchases, since its the default skin

        //clear anything previously equiped
        clearSkins();

        //equip skin zero
        GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinZeroEquiped = true;
    }

    public void equipSkinOne()
    {
        //check if skin one was purchased
        if (GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinOnePurchased)
        {
            //clear anything previously equiped
            clearSkins();

            //equip skin one
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinOneEquiped = true;
        }
    }

    public void equipSkinTwo()
    {
        //check if skin one was purchased
        if (GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoPurchased)
        {
            //clear anything previously equiped
            clearSkins();

            //equip skin one
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoEquiped = true;
        }
    }
}
