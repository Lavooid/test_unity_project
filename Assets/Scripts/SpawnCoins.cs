using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 3f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), 8, -2);
        GameObject meteor = Instantiate(meteors[Random.Range(0, meteors.Length)], pos, Quaternion.identity);

        Destroy(meteor, 10f);
    }
}
