using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    //
    public GameObject playerPrefabOne;
    public GameObject playerPrefabTwo;
    public GameObject playerPrefabThree;

    // Start is called before the first frame update
    void Start()
    {
        //check if skin 2 (first in shop), is purchased
        if (GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().skinTwoEquiped)
        {
            SpawnThree();//first skin purchase, second skin (including default)
        }
        else if(GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().skinOneEquiped)
        {
            SpawnTwo();
        }
        else
        {
            SpawnOne();
        }
    }

    void SpawnOne()
    {
        //spawn player (with default skin) at 0,0
        GameObject player = Instantiate(playerPrefabOne, new Vector2(0, 0), new Quaternion(0, 0, 0, 0));
    }

    void SpawnTwo()
    {
        //spawn player (with tier 1 skin) at 0,0
        GameObject player = Instantiate(playerPrefabTwo, new Vector2(0, 0), new Quaternion(0, 0, 0, 0));
    }

    void SpawnThree()
    {
        //spawn player (with tier 2 skin) at 0,0
        GameObject player = Instantiate(playerPrefabThree, new Vector2(0, 0), new Quaternion(0, 0, 0, 0));
    }
}
