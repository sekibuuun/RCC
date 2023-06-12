using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneySpawnerScript1000 : MonoBehaviour
{
    public GameObject Money;

    float timer;

    public int SpawnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > SpawnSpeed)
        {
            Instantiate(Money, this.transform.position + new Vector3(Random.Range(-1, 2), 0, 0), this.transform.rotation);
            timer = 0;
        }
        
    }
}