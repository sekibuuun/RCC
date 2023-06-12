using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnerScript : MonoBehaviour
{
    public GameObject Animal;

    float timer;

    public float SpawnSpeed;
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
            Instantiate(Animal, this.transform.position + new Vector3(Random.Range(-1, 2), 0, 0), this.transform.rotation);
            timer = 0;
        }

    }
}
