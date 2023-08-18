using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame (use to check player inputs)
    void Update()
    {

        // if mouse is clicked (shooting button)
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        //create a bullet at the firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        //apply a forceto bullet so it flies out
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); //get the bullet's rigid body
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
