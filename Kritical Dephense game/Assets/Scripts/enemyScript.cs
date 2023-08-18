using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//change scenes when player is hit

public class enemyScript : MonoBehaviour
{

    public GameObject scoreObject;//we need to access the score (add to it when enemy is shot)
    //this is set in the spawnEnemy script

    public float moveSpeed = 1;

    //we need the player's position
    public Transform player; //this is set in the spawnEnemy script

    private Rigidbody2D rb;
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.position - transform.position;//vector the enemies need to meet player(position vector diff)

        //rotating the enemy so it faces the player
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;//turning the position vector into an angle in radians, then an angle in degrees

        rb.rotation = angle-90;//rotate the enemy rigidbody by the specified angle (90 to adjust properly)


        //moving the enemy towards the player
        direction.Normalize();//sets the direction to a value between negative 1 and positive 1
        movement = direction;
    }

    private void FixedUpdate()//like an update function that works in sync with built in unity physics
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));//btw current position needs to be defined as a Vector2 (will cause errr if left as 3)
        //sets the enemies position to the current + other vector
    }


    //collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if enemy collided with bullet
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);//destory this enemy (attached to this script)

            //increase score count
            scoreObject.GetComponent<ScoreScript>().scoreCount++;
        }

        //check if enemy collided with player
        if (collision.gameObject.tag == "player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//goes from gameScene to GameOver scene
            //destory game music
            Destroy(GameObject.FindGameObjectWithTag("gameMusicObject"));

            //save the player's high score
            //if it's a new record, save as high score (in saveDataScript)
            if (GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore > GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().highScore)
            {
                //set as new high score
                GameObject.FindGameObjectWithTag("saveDataObject").GetComponent<saveDataScript>().highScore = GameObject.FindGameObjectWithTag("savedScoreObject").GetComponent<scoreSaverScript>().savedScore;
            }
        }
    }
}
