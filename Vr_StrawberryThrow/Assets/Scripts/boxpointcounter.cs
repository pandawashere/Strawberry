using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxpointcounter : MonoBehaviour
{

    public int boxWorth;
    public GameController gameController;

    void Start()
    {
        gameController = GameController.singleton;
    }



    void OnTriggerEnter(Collider other)
    {
        gameController.AddScore(boxWorth);
        Destroy(other);
    }

}

