using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public bool isKeyCollected;
    private void Awake() 
    {
        if (instance != null && instance != this)
             Destroy(this.gameObject);
         else
             instance = this;
    }
    void Start()
    {
        isKeyCollected = false;
    }

   
}
