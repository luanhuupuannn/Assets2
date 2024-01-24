using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Mathematics;
using System;


public class danhca : MonoBehaviour
{
    public TextMeshProUGUI textscore;
    public TextMeshProUGUI quest;
    int tong = 0;
    int nhiemvu =10;
    public GameObject hoanthanh ;
    // Start is called before the first frame update
    void Start()
    {
        hoanthanh.SetActive(false);
        nhiemvu = UnityEngine.Random.Range(10, 20);
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
            Destroy(collision.gameObject);  // Destroy the colliding object with the tag "ca1"
            congdiem(1);

        }
        if (collision.gameObject.tag == "ca2")
        {
            Destroy(collision.gameObject);  
            congdiem(2);

        }
        if (collision.gameObject.tag == "ca3")
        {
            Destroy(collision.gameObject); 
            congdiem(3);

        }
        if (collision.gameObject.tag == "ca4")
        {
            Destroy(collision.gameObject);  
            congdiem(4);

        }
        if (collision.gameObject.tag == "ca5")
        {
            Destroy(collision.gameObject); 
            congdiem(5);

        }
        if (collision.gameObject.tag == "ca6")
        {
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
            Time.timeScale = 0  ;
        }
    }

   
}
