using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [Header("Settings")]
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

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
                bullet.GetComponent<Rigidbody2D>();
                StartCoroutine("Disable");
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
