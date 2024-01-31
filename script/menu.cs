using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public float timelive = 125f;
    private float savedTimelive; // Biến thành viên để lưu trữ giá trị đã lưu

    // Start is called before the first frame update
    void Start()
    {
        savedTimelive = PlayerPrefs.GetFloat("myValue");
        timelive = savedTimelive;


    }

    // Update is called once per frame
    void Update()
    {
        // Không cần tải giá trị từ PlayerPrefs ở đây nữa
    }

    public void nextplay1()
    {

        if (timelive > 45f)
        {
            // Giảm timelive đi 100f
            timelive -= 10f;

            // Lưu giá trị cập nhật vào PlayerPrefs trước khi tải cảnh
            PlayerPrefs.SetFloat("myValue", timelive);


        }

        SceneManager.LoadScene(0);
    }
    public void playgain1()
    {


        // Đặt timelive về lại giá trị ban đầu
        timelive = 125f;

        // Lưu giá trị cập nhật vào PlayerPrefs
        PlayerPrefs.SetFloat("myValue", timelive);

        // Tải cảnh hiện tại
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
