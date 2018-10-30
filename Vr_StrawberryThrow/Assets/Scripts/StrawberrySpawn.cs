using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberrySpawn : MonoBehaviour
{


    public GameObject strawberry;
    public GameObject spawnarea;
    public int spawnlimit;
    public static int spawnnum;
    public int objs = 0;



    void Start()
    {
        for (int i = 0; i < spawnlimit; i++)
        {
            Instantiate(strawberry, spawnarea.transform.position, spawnarea.transform.rotation);
            objs++;
        }
    }

    void spawn()
    {
        if (objs < spawnlimit) Instantiate(strawberry, spawnarea.transform.position, spawnarea.transform.rotation);
    }
}
