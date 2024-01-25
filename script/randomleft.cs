using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomleft : MonoBehaviour
{
    public GameObject tat;
    public GameObject fish;
   
    float timeToAddBall1 = 5f;
     public float thoigiantat = 15f; // Bộ đếm ngược để tắt tat
  

   public float x1;
    public float x2;
    public float y1;
    public float y2;

   public int solantao;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

        if (i<= solantao)
        {
            addball();
            i++;
        }
       
            
        



        

       // if (timeToAddBall1 > 0 && thoigiantat > 0) // Kiểm tra cả hai bộ đếm
       // {
         //   timeToAddBall1 -= Time.deltaTime;
         //   thoigiantat -= Time.deltaTime; // Giảm bộ đếm ngược
         //   if (timeToAddBall1 <= 0)
         //   {
        //        addball();
        //        timeToAddBall1 = 5f; // Đặt lại bộ đếm cho việc thêm bóng
        //    }
       // }

    }
   // IEnumerator Countdown()
    //{
      //  while (thoigiantat > 0)
     //   {
      //      yield return new WaitForSeconds(1f); // Chờ 1 giây
      //  }
    //    tat.SetActive(false); // Tắt tat sau 10 giây
   // }

    public void addball()
    {
        Vector2 balladd = new Vector2(Random.Range(x1,x2), Random.Range(y1, y2)); //-15 -14 -5 -12

        if (fish)
        {
            Instantiate(fish, balladd, Quaternion.identity);
        }
    }
}
