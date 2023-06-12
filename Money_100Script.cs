using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money_100Script : MonoBehaviour
{
    public GameObject Money;

    public float speed = 3;

    public AudioClip clip;

    private void Update()
    {
        transform.position -= new Vector3(0, 0, Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {   
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(this.gameObject);

        }
    }
}
