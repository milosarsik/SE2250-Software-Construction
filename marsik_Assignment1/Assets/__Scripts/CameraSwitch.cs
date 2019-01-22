using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camOne, camTwo;
 

    // Start is called before the first frame update
    void Start()
    {
        camOne.enabled = true;
        camTwo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camOne.enabled = !camOne.enabled;
            camTwo.enabled = !camTwo.enabled;
        }

    }
}
