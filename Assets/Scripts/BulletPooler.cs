using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{
    public static BulletPooler instance;
    public List<GameObject> pool;
    public GameObject bulletprefab;
    public int poolSize;
    public bool canGrow;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = GameObject.Instantiate(bulletprefab);
            bullet.SetActive(false);
            pool.Add(bullet);
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
        if (canGrow)
        {
            GameObject bullet = GameObject.Instantiate(bulletprefab);
            bullet.SetActive(false);
            pool.Add(bullet);
            return bullet;
        }
        else
        {
            return null;
        }
    }
}

