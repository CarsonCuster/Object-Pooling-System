using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("Settings")]
    public GameObject bullet;
    float timer = 0;


    public float secondsbeforedisable;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer = timer+Time.deltaTime;
        if(Input.GetButton("Jump"))
        {
            GameObject bullet = BulletPooler.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Rigidbody2D>();
            }
        }

        if(timer > secondsbeforedisable)
        {
            bullet.SetActive(false);
        }


    }
}
