using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
  private SphereCollider col;
  private void Awake() 
  {
    col = GetComponent<SphereCollider>();    
  }
  private void OnTriggerEnter(Collider other) 
  {
    if (other.tag == "Player")
    {
        Debug.Log("Level Complete");
    }    
  }
}
