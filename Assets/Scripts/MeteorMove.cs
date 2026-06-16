using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public GameObject mateor;
    Rigidbody2D rb;
    Vector3 pos;
    float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), -2);
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position = Vector3.MoveTowards(rb.transform.position, pos, speed * Time.deltaTime);

        if (Vector3.Distance(rb.transform.position, pos) < 0.1f)
        {
            ChooseNewPoint();
        }
    }

    void ChooseNewPoint()
    {
        pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 8f), -2);
    }
}
