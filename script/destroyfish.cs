using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


public class destroyfish : MonoBehaviour
{
    public TextMeshProUGUI textscore;
    int tong = 0;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "attack")
        {
            Destroy(this.gameObject);
            congdiem(1);

        }



    }
    void congdiem(int diem)
    {
        tong +=diem;
        textscore.text = ""+ tong;
    }





}
