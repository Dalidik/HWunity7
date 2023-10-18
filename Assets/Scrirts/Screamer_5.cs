using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer_5 : MonoBehaviour
{
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayDelayed(55.0f);
    }


}
