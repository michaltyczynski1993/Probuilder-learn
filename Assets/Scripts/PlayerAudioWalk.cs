using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioWalk : MonoBehaviour
{
    private AudioSource walkaudio;
    void Start()
    {
        walkaudio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown( "Horizontal" ) || Input.GetButtonDown( "Vertical" ) )
        {
            walkaudio.Play();
        }

        else if ( !Input.GetButton( "Horizontal" ) && !Input.GetButton( "Vertical" ) && walkaudio.isPlaying )
        {
            walkaudio.Stop();
        }
    }
}
