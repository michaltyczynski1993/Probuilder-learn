using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private BoxCollider colTrigger;
    private Animator anim;
    void Start()
    {
        colTrigger = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
    }
    private void Update() 
    {
        if (GameControl.instance.isKeyCollected == true)
        {
            anim.SetBool("isDoorOpen", true);
        }    
    }
}
