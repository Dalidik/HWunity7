using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    [SerializeField] Transform teleport;
    [SerializeField] GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Teleport());   
    }

    IEnumerator Teleport()
    {
        yield return new WaitForSeconds(0);
        player.transform.position = new Vector3(
            teleport.transform.position.x,
            teleport.transform.position.y,
            teleport.transform.position.z);
    }
}
