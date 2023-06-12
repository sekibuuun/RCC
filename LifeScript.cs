using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public GameObject Life;

    public void Break()
    {
        Destroy(Life);
    }
}
