using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using System;


public class danhca : MonoBehaviour
{
    public GameObject efx;
    public TextMeshProUGUI textscore;
    public TextMeshProUGUI quest;
    int tong = 0;
    int nhiemvu =10;
    public GameObject hoanthanh ;
    // Start is called before the first frame update
    void Start()
    {
        hoanthanh.SetActive(false);
        nhiemvu = UnityEngine.Random.Range(400, 500);
        quest.text = "/" + nhiemvu;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ca1")
        {
            gietca(); ;


            Destroy(collision.gameObject);  // Destroy the colliding object with the tag "ca1"
            congdiem(1);

        }
        if (collision.gameObject.tag == "ca2")
        {
            gietca(); ;

            Destroy(collision.gameObject);  
            congdiem(2);

        }
        if (collision.gameObject.tag == "ca3")
        {
            gietca(); ;

            Destroy(collision.gameObject); 
            congdiem(3);

        }
        if (collision.gameObject.tag == "ca4")
        {
            gietca(); ;

            Destroy(collision.gameObject);  
            congdiem(4);

        }
        if (collision.gameObject.tag == "ca5")
        {
            gietca(); ;

            Destroy(collision.gameObject); 
            congdiem(5);

        }
        if (collision.gameObject.tag == "ca6")
        {
            gietca(); ;

            Destroy(collision.gameObject); 
            congdiem(1);

        }
    }

    void congdiem(int diem)
    {
        tong += diem;
        textscore.text = "Điểm: " + tong;
        if (tong >= nhiemvu)
        {
            hoanthanh.SetActive(true);
           
        }
    }
    void gietca()
    {
        GameObject cachet = Instantiate(efx,
                       this.transform.position,
                       this.transform.rotation);
        Destroy(cachet, 0.5f);
    }

   
}
