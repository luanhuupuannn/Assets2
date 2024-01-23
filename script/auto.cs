using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auto : MonoBehaviour
{

    public GameObject fish;
    public float timeadd;
    float m_timeadd;


    public int speed = 1;
    private int flipmt;
    public float spf = 2; // Tốc độ di chuyển
    public float distance = 40.0f; // Khoảng cách di chuyển

    private Vector3 startPosition; // Vị trí ban đầu

    void Start()
    {
        m_timeadd = 0;

        startPosition = transform.position; // Lưu vị trí ban đầu

    }

    void Update()
    {
        m_timeadd -= Time.deltaTime;

        // Di chuyển qua lại theo trục x
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (m_timeadd <= 0)
        {
            addball();
            m_timeadd = timeadd;
        }

        // Kiểm tra xem đã đạt đến điểm cuối hay chưa
        if (transform.position.x >= startPosition.x + distance ||
            transform.position.x <= startPosition.x - distance)
        {
            // Đảo ngược hướng di chuyển
            speed = -speed;

            if (speed < 0)
            {
                Vector3 flipmt = transform.localScale; //xuay ảnh
                flipmt.x = -1;
                transform.localScale = flipmt;
            }
            else
            {
                Vector3 flipmt = transform.localScale; //xuay ảnh
                flipmt.x = 1;
                transform.localScale = flipmt;
            }
        }

    }
    public void addball()
    {
        Vector2 balladd = new Vector2(-15, Random.Range(-5,-12));

        if (fish)
        {
            Instantiate(fish, balladd, Quaternion.identity);
        }
    }

}
