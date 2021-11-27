using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameControl.instance.isKeyCollected = true;
        }
    }
}
