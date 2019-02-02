using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SphereMovement : MonoBehaviour
{
    public Text scoreText;

    public float sphereSpeed;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        setScoreText();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(new Vector3(xSpeed, 0, ySpeed) * sphereSpeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue Pick Up"))
        {
            other.gameObject.SetActive(false);

            score += 5;

            setScoreText();
        }
        else
        {
            other.gameObject.SetActive(false);

            score += 1;

            setScoreText();
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
