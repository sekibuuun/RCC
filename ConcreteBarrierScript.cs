using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteBarrierScript : MonoBehaviour
{
    public GameObject Barrier;

    public float speed = 5;

    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, Time.deltaTime * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(this.gameObject);
            //ライフが0個になったらゲームオーバー
        }
    }
}
