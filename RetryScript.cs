using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RetryScript : MonoBehaviour
{
    public void OnClickStartButton()
    {
        StartCoroutine("SceneChange");
    }

    IEnumerator SceneChange()
    {
        this.gameObject.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("GameScene");
        Debug.Log("Game");
    }
}
