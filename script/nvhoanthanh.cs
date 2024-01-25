using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvhoanthanh : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "thuyen")
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
