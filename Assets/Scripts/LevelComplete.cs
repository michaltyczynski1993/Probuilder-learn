using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
  private SphereCollider col;
  private Scene scene;
  private void Awake() 
  {
    col = GetComponent<SphereCollider>();    
  }
  private void Start() 
  {
    scene = SceneManager.GetActiveScene();
  }
  private void OnTriggerEnter(Collider other) 
  {
    if (other.tag == "Player" && GameControl.instance.isKeyCollected == true)
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }    
  }
}
