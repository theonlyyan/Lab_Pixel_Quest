using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GeoControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 10000;
    public string nextLevel = "Scene_2";

    string String = "Hello ";
    int burger = 3;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        //Debug.Log("Hello World");
        string String2 = "World";
        // Debug.Log(String + String2);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(burger);
        burger++;
        // transform.position = transform.position + new Vector3(0.005f,0,0)
        // transform.position = transform.position += new Vector3(0.005f, 0, 0);
        //transform.position += new Vector3(0.005f, 0, 0);

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        // transform.position += new Vector3(0, 1, 0);

        // }

        // if (Input.GetKeyDown(KeyCode.S))
        // {
        // transform.position += new Vector3(0, -1, 0);
        //   }

        // if (Input.GetKeyDown(KeyCode.A))
        // {
        // transform.position += new Vector3(-1, 0, 0);

        // }

        //if (Input.GetKeyDown(KeyCode.D))
        //  {
        // transform.position += new Vector3(1, 0, 0);

        //  }

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        } 
    }   */

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    // Debug.Log("Player Has Died");
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
           case "Finish":
           
            {
                SceneManager.LoadScene(nextLevel);
                break;
            }
        }



    }
}
