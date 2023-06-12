using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation *= Quaternion.AngleAxis(2, Vector3.right);
    }
}
