using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;//enemy prefab
    private double time=0;//tracks time between enemy spawns (resets for each spawn)
    private int spawnAmount=1;// starts at 3, increases each spawn round

    //default rotation
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add to the time that passed since last spawn
        time += Time.deltaTime;// time passed since last update was called (in seconds)
        //for example 30 FPS yields a Time.deltaTime of 1/30

        if (time > 5)//if 5 seconds have passed since last spawn (its time to spawn again)
        {
            for(int i=0; i<spawnAmount; i++)
            {
                Spawn();
            }
            time = 0;//reset time

            spawnAmount++;//number of enemies being spawned will increase each wave
        }
    }

    void Spawn()
    {
        //spawn enemies every 5 seconds
        //Debug.Log("spawn enemies");

        //randomly generate position
        Vector2[] randPos = new Vector2[4];//4 different areas the enemy can spawn from (edges)
        //ex. top spawn area has a fixed height, but random along the x axis
        randPos[0] = new Vector2(-8, Random.Range(-5,5));//left edge
        randPos[1] = new Vector2(8, Random.Range(-5, 5));//right edge
        randPos[2] = new Vector2(Random.Range(-8,8), 5);//top edge
        randPos[3] = new Vector2(Random.Range(-8, 8), -5);//bottom edge

        //spawn posiiton (top, left, right, bottom) is chosen randomly out of the four
        Vector2 spawnPos = randPos[(int)Random.Range(0,4)];
        //create an instance of the enemy prefab
        GameObject enemy = Instantiate(enemyPrefab, spawnPos, new Quaternion(0, 0, 0,0));//Quaternion is some random rotation idk,,
        //will change anywayscuz enemy will face player

        //each enemy prefab is attached to the player transform needed so that the prefab can follow the player around
        enemy.GetComponent<enemyScript>().player = GameObject.FindWithTag("player").transform;

        //each enemy prefab is attached to the score (to +1 score when enemy dies)
        enemy.GetComponent<enemyScript>().scoreObject = GameObject.FindWithTag("scoreObject");
        
    }
}