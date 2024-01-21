using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    public float move1;
    public float move2;  // For vertical movement
    Animator animator;

    private int flip;
    Rigidbody2D rb;


    int speed = 5;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.L))
        {
            animator.SetBool("atdoc", true);
        }
        else
        {
            animator.SetBool("atdoc", false);
        }
        // bơi qua lại
         if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            move1 = -1;
            Vector3 flip = transform.localScale; //xuay ảnh
            flip.x = -3;
            transform.localScale = flip;
            // ani
            animator.SetBool("swngang", true);

        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            move1 = 1;

            Vector3 flip = transform.localScale; //xuay ảnh
            flip.x = 3;
            transform.localScale = flip;

            animator.SetBool("swngang", true);

        }
        else
        {
            move1 = 0;
            animator.SetBool("swngang", false);


        }

        // bơi lên xuống 
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            move2 = 1;  // Move up
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            move2 = -1;  // Move down
        }
        else
        {
            move2 = 0;  // No vertical movement
        }

        if(move2 ==1&& move1 == 1|| move2 == 1 && move1 == -1)
        {
            animator.SetBool("swcheo", true);
        }
        else
        {
            animator.SetBool("swcheo", false);

        }
    }
    void FixedUpdate()
    {
        transform.Translate(move1 * speed * Time.deltaTime, move2 * speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D swmatnuoc)
    {
        if(swmatnuoc.gameObject.tag == "matnuoc")
        {
            animator.SetBool("idiamatnuoc", true);
        }
       
    }
    private void OnTriggerExit2D(Collider2D exitmatnuoc)
    {
        if (exitmatnuoc.gameObject.tag == "matnuoc")
        {
            animator.SetBool("idiamatnuoc", false);
        }
    }
}

