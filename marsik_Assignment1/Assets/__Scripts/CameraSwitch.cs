using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camOne, camTwo;
 

    // Start is called before the first frame update
    void Start()
    {
        camOne.enabled = true;                  // setting camera one view at the start
        camTwo.enabled = false;                 // setting camera two view at the start
    }

    // Update is called once per frame
    void Update()
    {
        // checking if the user has pressed down on the C key
        if (Input.GetKeyDown(KeyCode.C))
        {
            // switching the boolean values of the cameras to show one but not the other
            camOne.enabled = !camOne.enabled;
            camTwo.enabled = !camTwo.enabled;
        }

    }
}
