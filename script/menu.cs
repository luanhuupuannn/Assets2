using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public float timelive = 400f;
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

    public void playagain()
    {
        // Giảm timelive đi 100f
        timelive -= 100f;

        // Lưu giá trị cập nhật vào PlayerPrefs trước khi tải cảnh
        PlayerPrefs.SetFloat("myValue", timelive);

        SceneManager.LoadScene(0);
    }
}
