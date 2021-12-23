using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public bool isKeyCollected;
    public GameObject objectiveText;

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
        StartCoroutine(HideAfterTime(8, objectiveText));
    }
    IEnumerator HideAfterTime(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
   
}
