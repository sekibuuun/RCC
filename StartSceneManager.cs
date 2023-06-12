using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetMouseButton(0))
        {
            StartCoroutine("SceneChange");
        }
    }

    IEnumerator SceneChange()
    {
        this.gameObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("HowToPlayScene1");
        Debug.Log("debug1");
    }
}
