using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("Settings")]
    public GameObject bullet;
    float timer = 5;
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if(Input.GetButtonDown("Jump"))
        {
            GameObject bullet = BulletPooler.instance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                bullet.GetComponent<Rigidbody2D>();
                StartCoroutine("Disable");
            }
        }


    }

    IEnumerator Disable()
    {
        yield return new WaitForSeconds(5);
        bullet.SetActive(false);
        Debug.Log("agfiwa");
    }
}
