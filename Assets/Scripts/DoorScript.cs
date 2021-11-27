using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private BoxCollider colTrigger;
    [SerializeField] private GameObject particles;
    void Start()
    {
        colTrigger = GetComponent<BoxCollider>();
    }
    private void Update() 
    {
        if (GameControl.instance.isKeyCollected == true)
        {
            particles.SetActive(true);
        }    
    }
}
