using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePickUp : MonoBehaviour
{
    // variables
    public GameObject pickUpObject;
    public Material materialPickUpOne;
    public Material materialPickUpTwo;
    public bool isBlue = true;

    // positions of the pick up objects around the box
    public Vector3[] positionArray = new[] { new Vector3(0f, 1f, 4.5f), new Vector3(3.3f, 1f, 3.2f),
        new Vector3(4.5f, 1f, 0f), new Vector3(3.3f, 1f, -3.2f),new Vector3(0f, 1f, -4.5f),
        new Vector3(-3.3f, 1f, -3.2f), new Vector3(-4.5f, 1f, 0f),
        new Vector3(-3.3f, 1f, 3.2f)};

    void Start()
    {
        // for loop to create 8 pick up objects
        for (int i = 0; i < 8; i++)
        {
            // checking whether the pickup objects that needs to be instantiated is blue or yellow
            if (isBlue)
            {
                // setting the tag to be a blue pick up object
                pickUpObject.tag = "Blue Pick Up";

                // setting the color to a previously made material (blue)
                pickUpObject.GetComponent<MeshRenderer>().material = materialPickUpOne;

                // instantiating our new pick up object
                Instantiate(pickUpObject, positionArray[i], transform.rotation);

                // setting isBlue equal to false, so that we create a yellow object on the next loop
                isBlue = false;
            }
            else
            {
                // setting the tag to be a yellow pick up object
                pickUpObject.tag = "Yellow Pick Up";

                // setting the color to a previously made material (yellow)
                pickUpObject.GetComponent<MeshRenderer>().material = materialPickUpTwo;

                // instantiating our new pick up object
                Instantiate(pickUpObject, positionArray[i], transform.rotation);

                // setting isBlue equal to true, so that we create a blue object on the next loop
                isBlue = true;
            }
        }
    }
}
