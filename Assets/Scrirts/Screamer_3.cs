using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer_3 : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayDelayed(30.0f);
    }


}
