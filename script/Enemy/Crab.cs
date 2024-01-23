using System.Collections;
using UnityEngine;

public class Crab : MonoBehaviour
{
    public GameObject crabPrefab; // Prefab c?a con cua
    public float speed = 2f;
    public float range = 20f;
    public int maxCrabs = 3; // Gi?i h?n s? l??ng con cua
    float startX;
    int dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x;

        // B?t ??u Coroutine ?? xu?t hi?n con cua
        StartCoroutine(SpawnCrabAfterDelay(2f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCrab();
    }

    void MoveCrab()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * dir);
        if (transform.position.x < startX || transform.position.x > startX + range)
        {
            dir *= -1;
        }
    }

    IEnumerator SpawnCrabAfterDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

            // Ki?m tra s? l??ng con cua ?ã xu?t hi?n
            if (CountCrabs() < maxCrabs)
            {
                SpawnCrab();
              
            }
        }
    }

    void SpawnCrab()
    {
        // T?o m?t con cua m?i
        GameObject newCrab = Instantiate(crabPrefab, transform.position, Quaternion.identity);

        // ??t cha c?a con cua m?i là Crab (?? t? ??ng theo dõi chuy?n ??ng c?a cha)
        newCrab.transform.parent = transform;
    }

    int CountCrabs()
    {
        // ??m s? l??ng con cua hi?n t?i
        return transform.childCount;
    }
}
