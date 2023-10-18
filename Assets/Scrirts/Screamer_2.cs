using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer_2 : MonoBehaviour
{
   
      AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayDelayed(28.0f);
    }

   
}
