using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)//built in unity function (triggered on collisions)
    {
        //get rid of bullet on collision
        Destroy(gameObject);//calls the object this script is attached to, the bullet
    }
}
