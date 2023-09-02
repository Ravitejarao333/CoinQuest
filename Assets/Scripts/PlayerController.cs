using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody rb;

    int score = 0;
    public int WinScore;
    float xInput;
    float yInput;

    public GameObject winText;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f) 
        {
            SceneManager.LoadScene("Game");
         
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput*speed , 0 , yInput*speed );
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "COIN")
        {
            other.gameObject.SetActive(false);
            score++;
        }

        if(score >= WinScore)
        {
            winText.SetActive(true);
        }
    }


}
