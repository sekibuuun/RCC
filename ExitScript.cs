using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void ButtonExit()
    {
        StartCoroutine("SceneChange");
    }

    IEnumerator SceneChange()
    {
        this.gameObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("StartScene");
        Debug.Log("debug1");
    }
}
