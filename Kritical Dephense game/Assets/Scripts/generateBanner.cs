using System.Collections;
using System.Collections.Generic;
using UnityEditor; // to access Asset database
using UnityEngine;

public class generateBanner : MonoBehaviour
{
    //variables
    public GameObject bannerPrefab100;
    public GameObject bannerPrefab200;
    public GameObject bannerPrefab300;
    private Vector2 bannerPos = new Vector2(0, 16);//banner's position on the screen
    // Start is called before the first frame update
    void Start()
    {
        //check if a banner is purchased (puts the best banner as default)
        bool[] BannerPurchase = {
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOneEquiped,
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoEquiped,
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreeEquiped};

        //check which banner was purchased
        if (BannerPurchase[0])
        {
            GameObject banner = Instantiate(bannerPrefab100, bannerPos, new Quaternion(0, 0, 0, 0));
        }
        else if (BannerPurchase[1])
        {
            GameObject banner = Instantiate(bannerPrefab200, bannerPos, new Quaternion(0, 0, 0, 0));
        }
        else if (BannerPurchase[2])
        {
            GameObject banner = Instantiate(bannerPrefab300, bannerPos, new Quaternion(0, 0, 0, 0));
        }

    }

    
}
