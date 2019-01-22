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
        int randomRotationX = Random.Range(-5, 5);
        int randomRotationZ = Random.Range(-3, 3);

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.eulerAngles = new Vector3(randomRotationX, 0, randomRotationZ);
        }
    }
}
