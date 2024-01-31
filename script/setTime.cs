using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class setTime : MonoBehaviour
{
    public TextMeshProUGUI time;
    public float myValue ;
    public GameObject gameovertime;
    // Start is called before the first frame update
    void Start()
    {// Lấy số lần nhấp từ script menu


        myValue = PlayerPrefs.GetFloat("myValue");


        // PlayerPrefs.SetFloat("myValue", timelive);
        //timelive = UnityEngine.Random.Range(100, 200);
        //  myValue = PlayerPrefs.GetFloat("myValue");
    }

    // Update is called once per frame
    void Update()
    {
        if (myValue > 0)
        {
            myValue -= Time.deltaTime;
            time.text = "thời gian " + myValue;
        }
        else if(myValue < 0)
        {
            gameovertime.SetActive(true);
            Time.timeScale = 0;
        
        }
        

        
    }



}
