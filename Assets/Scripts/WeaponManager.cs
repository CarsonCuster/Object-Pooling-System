using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    private GameObject bullet;
    Bullet go;

  
    void Update()
    {



        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = BulletPooler.instance.GetPooledObject(); //We are pooling the bullet prefab from the list if one is available
            if (bullet != null) //If there is no bullet, we pull one
            {
                bullet.transform.position = transform.position; //We are setting the bullets location to the player when we press "Jump" which is by default spacebar
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true); //Set it to true in the hierarchy
                StartCoroutine("Disable"); //We want to disable the bullets after a certain amount of time so we can loop them back through, so we begin a "Disable" coroutine
                go.OnEnable();
                
            }
        }


    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(5); //After 5 seconds, we loop through the pool and if there are any bullets that are active, we deactivate them.
        foreach (var any in BulletPooler.instance.pool)
        {
            any.SetActive(false);
        }
    }
}
