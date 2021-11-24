using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        Destroy(gameObject);
        GameControl.instance.isKeyCollected = true;
    }
}
