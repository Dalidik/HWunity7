using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamerScript1 : MonoBehaviour
{
    public Collider Player;
    public AudioClip Sounds;
    public GameObject myScreamer;

    
    private void OnTriggerEnter(Collider other)
    {
        myScreamer.GetComponent<AudioSource>().PlayOneShot(Sounds);
        Destroy(gameObject);
        
    }

}
