using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{
    List<GameObject> pool;
    public GameObject bulletprefab;
    // Start is called before the first frame update
    public void Start()
    {
        pool = new List<GameObject>();
        GameObject bullet = GameObject.Instantiate(bulletprefab);

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

    // Update is called once per frame
    void Update()
    {

    }
}
