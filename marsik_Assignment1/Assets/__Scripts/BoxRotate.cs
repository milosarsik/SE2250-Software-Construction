using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        // checking if the user has left clicked the mouse
        if (Input.GetMouseButtonDown(0))
        {
            float randomRotationX = Random.Range(-3, 3);              // getting a random value for the x axis
            float randomRotationZ = Random.Range(-3, 3);              // getting a random value for the z axis
            float randomRotationY = Random.Range(-3, 3);              // getting a random value for the y axis

            gameObject.transform.eulerAngles = new Vector3(randomRotationX, randomRotationY, randomRotationZ);        // changing the angle of the box to the random values
        }
    }
}
