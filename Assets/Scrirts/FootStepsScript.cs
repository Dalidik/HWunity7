using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsScript : MonoBehaviour
{
    public GameObject footstep;
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("s"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("d"))
        {
            footsteps();
        }




        if (Input.GetKeyUp("s"))
        {
            StopFootSteps();
        }
        if (Input.GetKeyUp("a"))
        {
            StopFootSteps();
        }

        if (Input.GetKeyUp("d"))
        {
            StopFootSteps();
        }

        if (Input.GetKeyUp("w"))
        {
            StopFootSteps();
        }
    }


    void footsteps()
    {
        footstep.SetActive(true);
    }

    void StopFootSteps()
    {
        footstep.SetActive(false);
    }
}
