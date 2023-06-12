using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRoop2 : MonoBehaviour
{
    private float speed = 3;

    public GameObject Player;

    void Update()
    {
        transform.position -= new Vector3(0, 0, Time.deltaTime * speed);

        if (transform.position.z <= Player.transform.position.z * -1.0f)
        {
            transform.position = new Vector3(0, 0, 35);
        }
    }
}