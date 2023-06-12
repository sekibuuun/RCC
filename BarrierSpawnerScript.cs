using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawnerScript : MonoBehaviour
{
    public GameObject Barrier;
    
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
            Instantiate(Barrier, this.transform.position + new Vector3(Random.Range(-1, 2), 0, 0), this.transform.rotation);
            timer = 0;
        }

    }
}
