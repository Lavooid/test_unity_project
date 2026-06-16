using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), -2);
        GameObject t_coin = Instantiate(coin, pos, Quaternion.identity);

        Destroy(t_coin, 5f);
    }
}
