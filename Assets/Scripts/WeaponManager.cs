using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject bullet;
    Bullet go;
    // Update is called once per frame

  
    void Update()
    {



        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = BulletPooler.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                StartCoroutine("Disable"); 
                go.OnEnable();
                
            }
        }


    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(5);
        foreach (var any in BulletPooler.instance.pool)
        {
            any.SetActive(false);
        }
    }
}
