using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{


    
    public hp mau;
    public float luongmauhientai;
    public float luongmautoida = 10;

    // Start is called before the first frame update

    public float move1;
    public float move2;  // For vertical movement
    Animator animator;

    public GameObject tamdanh;
    private int flip;
    Rigidbody2D rb;

    public GameObject gameover;
  

    int speed = 5;
    void Start()
    {

        Time.timeScale = 1;
        luongmauhientai = luongmautoida;
        mau.capnhatthanhmau(luongmauhientai, luongmautoida);

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
       


    }

    // Update is called once per frame
    void Update()
    {

       

        // attack
        if ( Input.GetKey(KeyCode.L))
        {
            animator.SetBool("atdoc", true);
            tamdanh.SetActive(true);



        }
        else
        {
            tamdanh.SetActive(false);

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

        // bơi chéo
        if (move2 == 1 && (move1 == 1 || move1 == -1))
        {
            animator.SetBool("swcheo", true);
        }
        else
        {
            animator.SetBool("swcheo", false);
        }


     //if (move2 ==1&& move1 == 1|| move2 == 1 && move1 == -1)
     // {
       //     animator.SetBool("swcheo", true);
       // }

     //   if (move2 == 1 && move1 == 1 || move2 == 1 && move1 == -1)
     //   {
       //     animator.SetBool("swcheo", true);
      //  }
      //  else
      //  {
       //     animator.SetBool("swcheo", false);

      //  }
    }
    void FixedUpdate()
    {
        transform.Translate(move1 * speed * Time.deltaTime, move2 * speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D swmatnuoc)
    {
       

        if (swmatnuoc.gameObject.tag == "matnuoc")
        {
            animator.SetBool("idiamatnuoc", true);
        }
        // đụng phải cá mập
        if (swmatnuoc.gameObject.tag == "camap")
        {
            animator.SetBool("trumau", true);
            luongmauhientai = luongmauhientai - 2;
            mau.capnhatthanhmau(luongmauhientai, luongmautoida);
            Invoke("TatHieuUngTrungDon", 2f);

            if (luongmauhientai <= 0)
            {

                animator.SetBool("dead", true);
                gameover.SetActive(true);

                Time.timeScale = 0;
            }

        }


    }
   
    // tắt hiệu ứng trúng đòn 
    void TatHieuUngTrungDon()
    {
        animator.SetBool("trumau", false);
    }
    
    // rời khỏi mặt nước thì tất hiệu ứng 

    private void OnTriggerExit2D(Collider2D exitmatnuoc)
    {
        if (exitmatnuoc.gameObject.tag == "matnuoc")
        {
            animator.SetBool("idiamatnuoc", false);
        }
    }

}

