using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxpointcounter : MonoBehaviour {

    public int boxWorth;
    public GameController gameController; 
         
    void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        gameController.AddScore(boxWorth);
        Destroy(other);
    }


}
