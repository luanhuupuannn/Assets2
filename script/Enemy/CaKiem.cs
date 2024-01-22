using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaKiem : MonoBehaviour
{
    public float speed = 13.0f;
    public float range = 3;
    float startX;
    int dir = 1;

    void Start()
    {
        startX = transform.position.x;
        InvokeRepeating("ReverseDirection", 13f, 13f);

    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * dir);
    }

    void ReverseDirection()
    {
        dir *= -1;
        turning();
    }

    void turning()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
