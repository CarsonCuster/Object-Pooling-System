using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{
    public List<GameObject> pool;
    public GameObject bulletprefab;
    public static BulletPooler instance;
    // Start is called before the first frame update
    void awake()
    {
        instance = this;
    }

    public void Fire()
    {
        pool = new List<GameObject>();
        GameObject bullet = GameObject.Instantiate(bulletprefab);

        if (Input.GetButton("Jump"))
        {
            if (pool.Contains(bullet))
            {
                bullet.SetActive(true);
            }
            else
            {
                GameObject.Instantiate(bulletprefab);
                pool.Add(bulletprefab);
            }
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }
        return null;
    }
}

