using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purchaseScript : MonoBehaviour
{
    //purchase skin 1
    public void purchaseOne()
    {
        //check if they can afford (80 points) //AND it wasn't already purchased
        if (GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore >= 80
            && !GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinOnePurchased)
        {
            //decrease the point amount (40 points spent)
            GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore -= 80;
            //set the skin 1 purchased to TRUE 
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinOnePurchased = true;
        }
    }

    public void purchaseTwo()
    {
        //check if they can afford (50 points) //AND it wasn't already purchased
        if (GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore >= 240
            && !GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoPurchased)
        {
            //decrease the point amount (50 points spent)
            GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore -= 240;
            //set the skin 2 purchased to TRUE 
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoPurchased = true;
        }
    }

    public void purchaseBanOne()// to purchase the 100pt banner
    {
        //check if they can afford (100points) //AND that it wasn't already purchased
        if (GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore >= 100
            && !GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOnePurchased)
        {
            //decrease the point amount (100 points spent)
            GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore -= 100;
            //set banner 1 purchased to TRUE
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerOnePurchased = true;
        }
    }

    public void purchaseBanTwo()// to purchase the 100pt banner
    {
        //check if they can afford (200points) //AND that it wasn't already purchased
        if (GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore >= 200
            && !GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoPurchased)
        {
            //decrease the point amount (200 points spent)
            GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore -= 200;
            //set banner 2 purchased to TRUE
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerTwoPurchased = true;
        }
    }

    public void purchaseBanThree()// to purchase the 100pt banner
    {
        //check if they can afford (300points) //AND that it wasn't already purchased
        if (GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore >= 300
            && !GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreePurchased)
        {
            //decrease the point amount (300 points spent)
            GameObject.FindWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore -= 300;
            //set banner 3 purchased to TRUE
            GameObject.FindWithTag("saveDataObject").GetComponent<saveDataScript>().bannerThreePurchased = true;
        }
    }
}
