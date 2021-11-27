using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
  private BoxCollider col;
  private void Awake() 
  {
    col = GetComponent<BoxCollider>();    
  }
  private void OnTriggerEnter(Collider other) 
  {
    if (other.tag == "Player")
    {
        Debug.Log("Level Complete");
    }    
  }
}
